using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Reflection;
using Zubos.System.Data;
using System.Windows.Forms;

namespace Zubos.System.Business
{
    public class Customer
    {
        /// <summary>
        /// Customer object class to hold data about the customer.
        /// </summary>
        public int          CustomerID { get; set; }
        public string       Name { get; set; }
        public int          HouseNumber { get; set; }
        public string       HouseName { get; set; }
        public string       Street { get; set; }
        public string       Postcode { get; set; }

        /// <summary>
        /// Default constructor for customer object.
        /// </summary>
        public Customer()
        {

        }
        /// <summary>
        /// Constructor for customer object.
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pHouseNumber"></param>
        /// <param name="pHouseName"></param>
        /// <param name="pStreet"></param>
        /// <param name="pPostCode"></param>
        public Customer(string pName, int pHouseNumber, string pHouseName, string pStreet, string pPostCode)
        {
            Name = pName;
            HouseNumber = pHouseNumber;
            HouseName = pHouseName;
            Street = pStreet;
            Postcode = pPostCode;
        }

        public static bool CheckCustomerExists(Customer pCustomer)
        {
            string sqlCmdConditions = HelperMethods.BuildSQLConditionsWithParams
            (new SortedList<string, string>()
            {
                { "Name", pCustomer.Name },
                { "HouseNumber", Convert.ToString(pCustomer.HouseNumber) },
                { "HouseName", pCustomer.HouseName },
                { "Street", pCustomer.Street },
                { "Postcode", pCustomer.Postcode }
            });
            SqlCommand SqlCmd0 = new SqlCommand("SELECT CASE WHEN EXISTS((SELECT TOP 1 * FROM " +
                                                Global.DBConfig["CustomerTN"] + 
                                                sqlCmdConditions + 
                                                ")) THEN 1 ELSE 0 END;");
            SqlCmd0.Parameters.Add(new SqlParameter("@pName", pCustomer.Name));
            SqlCmd0.Parameters.Add(new SqlParameter("@pHouseNumber", pCustomer.HouseNumber));
            SqlCmd0.Parameters.Add(new SqlParameter("@pHouseName", pCustomer.HouseName));
            SqlCmd0.Parameters.Add(new SqlParameter("@pStreet", pCustomer.Street));
            SqlCmd0.Parameters.Add(new SqlParameter("@pPostcode", pCustomer.Postcode));

            return DataAccess.ExecuteBoolReturnQuery("ODS", SqlCmd0);
        }
        /// <summary>
        /// Will attempt to insert customers data into SQL.
        /// </summary>
        /// <param name="pCustomer"></param>
        /// <returns></returns>
        public static int CreateCustomerRecord(Customer pCustomer)
        {
            List<Tuple<Type, string>> CustomersAttributes = new List<Tuple<Type, string>>()
            {
                new Tuple<Type, string>( typeof(string), pCustomer.Name ),
                new Tuple<Type, string>( typeof(int), pCustomer.HouseNumber.ToSafeString() ),
                new Tuple<Type, string>( typeof(string), pCustomer.HouseName ),
                new Tuple<Type, string>( typeof(string), pCustomer.Street ),
                new Tuple<Type, string>( typeof(string), pCustomer.Postcode )
            };
            List<PropertyInfo> CustomerColumnsToBeAddedTo = typeof(Customer).GetProperties().ToList();
            CustomerColumnsToBeAddedTo.RemoveAt(0); //RemoveID as it will be automatically assigned by SQL.

            return DataAccess.ExecuteInsertQuery("ODS", Global.DBConfig["CustomerTN"], CustomerColumnsToBeAddedTo, CustomersAttributes);
        }
        /// <summary>
        /// Will attempt to retrive customers ID from all fields in customer.
        /// </summary>
        /// <param name="pCustomer"></param>
        /// <returns></returns>
        public static int SearchForCustomerID(Customer pCustomer)
        {
            SqlCommand SqlCmd2 = new SqlCommand("SELECT TOP 1 [CustomerID] FROM " +
            Global.DBConfig["CustomerTN"] +
            HelperMethods.BuildSQLConditionsWithParams(new SortedList<string, string>()
            {
                { "Name", pCustomer.Name },
                { "HouseNumber", Convert.ToString(pCustomer.HouseNumber) },
                { "HouseName", pCustomer.HouseName },
                { "Street", pCustomer.Street },
                { "Postcode", pCustomer.Postcode }
            }));
            SqlCmd2.Parameters.Add(new SqlParameter("@pName", pCustomer.Name));
            SqlCmd2.Parameters.Add(new SqlParameter("@pHouseNumber", pCustomer.HouseNumber));
            SqlCmd2.Parameters.Add(new SqlParameter("@pHouseName", pCustomer.HouseName));
            SqlCmd2.Parameters.Add(new SqlParameter("@pStreet", pCustomer.Street));
            SqlCmd2.Parameters.Add(new SqlParameter("@pPostcode", pCustomer.Postcode));

            return DataAccess.ExecuteIntegerReturnQuery("ODS", SqlCmd2);
        }


        /// <summary>
        /// This method will return the room with the specified ID.
        /// </summary>
        /// <param name="pRoomID"></param>
        /// <returns></returns>
        public static Customer GetCustomerByID(int pCustomerID)
        {
            Customer CustomerToReturn = DataAccess.ReturnObjectByID<Customer>("ODS", Global.DBConfig["CustomerTN"], pCustomerID);
            if (CustomerToReturn != null)
            {
                return CustomerToReturn;
            }
            else
            {
                MessageBox.Show("An error occured retrieving room data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }
    }
}
