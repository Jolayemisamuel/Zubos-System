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
        public string       Gender { get; set; }

        /// <summary>
        /// Default constructor for customer object.
        /// </summary>
        /// <param name="ID_Param"></param>
        public Customer(int ID_Param)
        {
            ID = ID_Param;
        }
    }
}
