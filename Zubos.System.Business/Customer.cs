using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zubos.System.Business
{
    public class Customer
    {
        /// <summary>
        /// Customer object class to hold data about the customer.
        /// </summary>
        public int          ID { get; }
        public string       Name { get; set; }
        public string       HouseNumber { get; set; }
        public string       HouseName { get; set; }
        public string       Street { get; set; }
        public string       Postcode { get; set; }

        /// <summary>
        /// Default constructor for customer object.
        /// </summary>
        public Customer()
        {
           
        }

        public void CreateCustomer(string Name_param, string HouseNumber_param, string HouseName_param, string Street_param, string PostCode_param)
        {
            Customer cust = new Customer();
            cust.Name = Name_param;
            cust.HouseNumber = HouseNumber_param;
            cust.HouseName = HouseName_param;
            cust.Street = Street_param;
            cust.Postcode = PostCode_param;

        }
    }
}
