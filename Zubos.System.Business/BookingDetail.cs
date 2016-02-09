using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zubos.System.Business
{
    /// <summary>
    /// Class to hold details about a booking.
    /// </summary>
    public class BookingDetail
    {
        public int                              BookingReference { get; }
        public SortedList<int, Customer>        myCustomers { get; set; }
        public Room                             myRoom { get; set; }
        public DateTime                         DateStart { get; }
        public DateTime                         DateComplete { get; }
        public double                           PaymentAmount { get; }

        /// <summary>
        /// Default constructor for BookingDetail object.
        /// </summary>
        /// <param name="ID_param"></param>
        /// <param name="Customers_param"></param>
        /// <param name="Room_param"></param>
        public BookingDetail
                            (int                        ID_param, 
                            SortedList<int, Customer>   Customers_param,
                            Room                        Room_param,
                            DateTime                    DateStart_param)
        {
            BookingReference = ID_param;
            myCustomers = Customers_param;
            myRoom = Room_param;
        }
    }
}
