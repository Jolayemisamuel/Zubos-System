using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Zubos.System.Data;
using System.Data.SqlClient;
using System.Data;

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
        public Room                             myRoom { get; set; }
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
                            Room pMyRoom,
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
                int customerRowsAffected = Customer.CreateCustomerRecord(varCustomer);

                if (customerRowsAffected == 1) { Logger.WriteLine("DEBUG", "Customer created and added to database successfully."); }
                else if (customerRowsAffected == 0) { Logger.WriteLine("ERROR", "Failed to update the database with new customer."); return false; }
            }
            else
            {//Customer already exists, get data from database.
                CustomerID = Customer.SearchForCustomerID(varCustomer);
            }

            if(CustomerID != 0)
            {//Customer ID exists
                //NEED TO ADD -
                                //UPDATE BOOKING DETAILID ON ROOM IN SQL FROM NEWLY CREATED BOOKINGID
                //DataAccess.ExecuteUpdateQuery("ODS", "Room", new List<string>() { "BookingDetailID" }, new List<string>() { Convert.ToString(HelperMethods.GetNextID<BookingDetail>()) });
                List<Tuple<Type, string>> BookingAttributes = new List<Tuple<Type, string>>()
                {
                    new Tuple<Type, string>(typeof(int), pDaysDuration.ToSafeString() ),
                    new Tuple<Type, string>(typeof(DateTime), HelperMethods.FormatDateForSQLInsert(pDateFrom.ToShortDateString()) ),
                    new Tuple<Type, string>(typeof(double), pPaymentAmount.ToSafeString() ),
                    new Tuple<Type, string>(typeof(int), pMyRoom.RoomID.ToSafeString() ),
                    new Tuple<Type, string>(typeof(int), CustomerID.ToSafeString() ),
                    new Tuple<Type, string>(typeof(string), pNotes )
                };
                List<PropertyInfo> ColumnsToBeAddedTo = new List<PropertyInfo>()
                {
                    typeof(BookingDetail).GetProperty("Days"),
                    typeof(BookingDetail).GetProperty("DateStart"),
                    typeof(BookingDetail).GetProperty("PaymentAmount"),
                    typeof(BookingDetail).GetProperty("myRoom"),
                    typeof(BookingDetail).GetProperty("myCustomer"),
                    typeof(BookingDetail).GetProperty("Notes")
                };
                int BookingRowsAffected = DataAccess.ExecuteInsertQuery("ODS", "BookingDetail", ColumnsToBeAddedTo, BookingAttributes);
                if (BookingRowsAffected == 1) { Logger.WriteLine("DEBUG", "Booking created and added to database successfully."); return true; }
                else if (BookingRowsAffected == 0) { Logger.WriteLine("ERROR", "Failed to update the database with new booking."); return false; }
            }
            /////////////
            return false;
        }
    }
}
