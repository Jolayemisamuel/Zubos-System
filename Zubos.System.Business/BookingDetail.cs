using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Zubos.System.Data;

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
        public string                           myCustomers { get; set; }
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
                            string pMyCustomers,
                            string pNotes)
        {
            BookingDetailID = pID;
            DateStart = pDateStart;
            Days = pDays;
            PaymentAmount = pPaymentAmount;
            myRoom = pMyRoom;
            myCustomers = pMyCustomers;
            Notes = pNotes;
        }

        public static void CreateBooking(string pName, int pHouseNumber, string pHouseName, string pStreet, string pPostcode, DateTime pDateFrom, int pDaysDuration, double pPaymentAmount, Room pMyRoom, string pNotes)
        {
            bool customerExists = DataAccess.ExecuteBoolReturnQuery("ODS",
                                                                    "SELECT CASE WHEN EXISTS (SELECT * FROM [Customer] WHERE Name = '" + pName + "' AND HouseNumber = " + pHouseNumber +
                                                                    " AND HouseName = '" + pHouseName + "' AND Street = '" + pStreet + "' AND Postcode = '" + pPostcode +
                                                                    "') THEN 1 ELSE 0 END;");
            Customer CustomerToBeAssigned;
            if (!customerExists)
            {//No customer exists, create one.
                CustomerToBeAssigned = Customer.CreateCustomer(pName, pHouseNumber, pHouseName, pStreet, pPostcode);

                List<string> CustomersAttributes = new List<string>()
                {
                  CustomerToBeAssigned.CustomerID.ToString(),
                  CustomerToBeAssigned.Name,
                  CustomerToBeAssigned.HouseNumber.ToSafeString(),
                  CustomerToBeAssigned.HouseName,
                  CustomerToBeAssigned.Street,
                  CustomerToBeAssigned.Postcode
                };
                List<PropertyInfo> ColumnsToBeAddedTo = typeof(Customer).GetProperties().ToList();
                ColumnsToBeAddedTo.RemoveAt(0);
                int rowsAffected = DataAccess.ExecuteInsertQuery("ODS", "Customer", ColumnsToBeAddedTo, CustomersAttributes);

                if (rowsAffected == 1) { Logger.WriteLine("DEBUG", "Customer created and added to database."); }
                else if(rowsAffected == 0) { Logger.WriteLine("ERROR", "Customer was created but failed to update the database, removing customer."); CustomerToBeAssigned = null; return; }
            }
            else
            {//Customer exists, get data from database.
                int CustomerID = DataAccess.ExecuteIntegerReturnQuery("ODS", "SELECT [CustomerID] FROM [Customer] WHERE Name = '" + pName + "' AND HouseNumber = " + pHouseNumber +
                                                                                "AND HouseName = '" + pHouseName + "' AND Street = '" + pStreet + "' AND Postcode = '" + pPostcode + ");");
                CustomerToBeAssigned = DataAccess.ReturnObjectByID<Customer>("ODS", "Customer", CustomerID);
            }

            BookingDetail createdBooking = new BookingDetail(HelperMethods.GetNextID<BookingDetail>(),
                                                            pDaysDuration, pDateFrom, pPaymentAmount,
                                                            pMyRoom, CustomerToBeAssigned.CustomerID.ToSafeString(), pNotes);

        }
    }
}
