using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zubos.System.Data;

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
        public Customer(int pID, string pName, int pHouseNumber, string pHouseName, string pStreet, string pPostCode)
        {
            CustomerID = pID;
            Name = pName;
            HouseNumber = pHouseNumber;
            HouseName = pHouseName;
            Street = pStreet;
            Postcode = pPostCode;
        }

        public static Customer CreateCustomer(string pName, int pHouseNumber, string pHouseName, string pStreet, string pPostcode)
        {
            Customer createdCustomer = new Customer(HelperMethods.GetNextID<Customer>(), pName, pHouseNumber, pHouseName, pStreet, pPostcode);
            return createdCustomer;
        }
    }
}
