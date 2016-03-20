using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Zubos.System.Data;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Zubos.System.Business
{
    /// <summary>
    /// Class to hold details about a booking.
    /// </summary>
    public class BookingDetail
    {
        public int                              BookingDetailID { get; set; }
        public int                              Days { get; set; }
        public DateTime                         DateStart { get; set; }
        public DateTime                         DateComplete { get; set; }
        public double                           PaymentAmount { get; set; }
        public int                              myRoom { get; set; }
        public int                              myCustomer { get; set; }
        public string                           Notes { get; set; }

        /// <summary>
        /// Default constructor for BookingDetail object.
        /// </summary>
        public BookingDetail()
        {

        }

        public BookingDetail(int pID, 
                            int pDays,
                            DateTime pDateStart,
                            double pPaymentAmount,
                            int pMyRoom,
                            int pMyCustomer,
                            string pNotes)
        {
            BookingDetailID = pID;
            DateStart = pDateStart;
            Days = pDays;
            PaymentAmount = pPaymentAmount;
            myRoom = pMyRoom;
            myCustomer = pMyCustomer;
            Notes = pNotes;
        }

        public static bool CreateBooking(string pName, int pHouseNumber, string pHouseName, string pStreet, string pPostcode, DateTime pDateFrom, int pDaysDuration, double pPaymentAmount, Room pMyRoom, string pNotes)
        {
            int CustomerID = 0;
            Customer varCustomer = new Customer(pName, pHouseNumber, pHouseName, pStreet, pPostcode);

            if (!Customer.CheckCustomerExists(varCustomer))
            {//No customer exists, create one and update database.
                int CustomerRowsAffected = Customer.CreateCustomerRecord(varCustomer);

                if (CustomerRowsAffected == 1) { Logger.WriteLine("DEBUG", "Customer created and added to database successfully."); }
                else if (CustomerRowsAffected == 0) { Logger.WriteLine("ERROR", "Failed to update the database with new customer."); return false; }
                CustomerID = Customer.SearchForCustomerID(varCustomer);
            }
            else
            {//Customer already exists, get data from database.
                CustomerID = Customer.SearchForCustomerID(varCustomer);
            }

            if(CustomerID != 0)
            {//Customer ID exists
                List<Tuple<Type, string>> BookingAttributes = new List<Tuple<Type, string>>()
                {//Create list of values to be inserted.
                    new Tuple<Type, string>(typeof(int), pDaysDuration.ToSafeString() ),
                    new Tuple<Type, string>(typeof(DateTime), HelperMethods.FormatDateForSQL(pDateFrom.ToShortDateString()) ),
                    new Tuple<Type, string>(typeof(double), pPaymentAmount.ToSafeString() ),
                    new Tuple<Type, string>(typeof(int), pMyRoom.RoomID.ToSafeString() ),
                    new Tuple<Type, string>(typeof(int), CustomerID.ToSafeString() ),
                    new Tuple<Type, string>(typeof(string), pNotes )
                };
                List<PropertyInfo> ColumnsToBeAddedTo = new List<PropertyInfo>()
                {//Get BookingDetail object propertys
                    typeof(BookingDetail).GetProperty("Days"),
                    typeof(BookingDetail).GetProperty("DateStart"),
                    typeof(BookingDetail).GetProperty("PaymentAmount"),
                    typeof(BookingDetail).GetProperty("myRoom"),
                    typeof(BookingDetail).GetProperty("myCustomer"),
                    typeof(BookingDetail).GetProperty("Notes")
                };
                int BookingRowsAffected = DataAccess.ExecuteInsertQuery("ODS", Global.DBConfig["BookingTN"], ColumnsToBeAddedTo, BookingAttributes);

                if (BookingRowsAffected == 1) { Logger.WriteLine("DEBUG", "Booking created and added to database successfully."); }
                else if (BookingRowsAffected == 0) { Logger.WriteLine("ERROR", "Failed to update the database with new booking."); return false; }

                if(!SyncRoomRecord(pDaysDuration, pDateFrom, pPaymentAmount, pMyRoom.RoomID, CustomerID, pNotes)) { return false; }
            }
            else { return false; }
            return true;
        }

        private static bool SyncRoomRecord(int pDaysDuration, DateTime pDateFrom, double pPaymentAmount, int pMyRoomID, int pMyCustomerID, string pNotes)
        {
            SqlCommand SqlCmd = new SqlCommand("SELECT TOP 1 [BookingDetailID] FROM "+
                Global.DBConfig["BookingTN"] +
            HelperMethods.BuildSQLConditionsWithParams(new SortedList<string, string>()
            {
                { "Days", pDaysDuration.ToSafeString() },
                { "DateStart", HelperMethods.FormatDateForSQL(pDateFrom.ToShortDateString()) },
                { "PaymentAmount", pPaymentAmount.ToSafeString() },
                { "myRoom", pMyRoomID.ToSafeString() },
                { "myCustomer", pMyCustomerID.ToSafeString() },
                { "Notes", pNotes }
            }));
            SqlCmd.Parameters.Add(new SqlParameter("@pDays", pDaysDuration));
            SqlCmd.Parameters.Add(new SqlParameter("@pDateStart", pDateFrom));
            SqlCmd.Parameters.Add(new SqlParameter("@pPaymentAmount", pPaymentAmount));
            SqlCmd.Parameters.Add(new SqlParameter("@pmyRoom", pMyRoomID));
            SqlCmd.Parameters.Add(new SqlParameter("@pmyCustomer", pMyCustomerID));
            SqlCmd.Parameters.Add(new SqlParameter("@pNotes", pNotes));

            int BookingID = DataAccess.ExecuteIntegerReturnQuery("ODS", SqlCmd);

            int RoomRowsAffected = DataAccess.ExecuteUpdateQuery("ODS", Global.DBConfig["RoomsTN"], 
                                                                new SortedList<string, string>() { { "BookingDetailID", BookingID.ToSafeString() } },
                                                                "WHERE RoomID = " + pMyRoomID);
            if (RoomRowsAffected == 1) { Logger.WriteLine("DEBUG", "Room record updated with booking detail ID succesfully."); return true; }
            else if (RoomRowsAffected == 0) { Logger.WriteLine("ERROR", "Failed to update the room record with booking detail ID."); return false; }
            return false;
        }
        /// <summary>
        /// This method will return all bookings as a DataTable
        /// </summary>
        /// <returns></returns>
        public static DataTable GetAllBookingsAsDataTable()
        {
            DataTable ResultsList = DataAccess.ReturnAllResultsAsDataTable("ODS", Global.DBConfig["BookingTN"]);
            if (ResultsList != null)
            {
                return ResultsList;
            }
            else
            {
                MessageBox.Show("An error occured retrieving rooms data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        /// <summary>
        /// This method will return the bookingdetail with the specified ID.
        /// </summary>
        /// <param name="pBookingID"></param>
        /// <returns></returns>
        public static BookingDetail GetBookingByID(int pBookingID)
        {
            BookingDetail BookingToReturn = DataAccess.ReturnObjectByID<BookingDetail>("ODS", Global.DBConfig["BookingTN"], pBookingID);
            if (BookingToReturn != null)
            {
                return BookingToReturn;
            }
            else
            {
                MessageBox.Show("An error occured retrieving booking detail data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }
    }
}
