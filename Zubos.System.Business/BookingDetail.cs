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
        public int                              ID { get; }
        public SortedList<int, Customer>        myCustomers { get; set; }
        public Room                             myRoom { get; set; }
        public DateTime                         DateStart { get; }
        public DateTime                         DateComplete { get; }

        /// <summary>
        /// Default constructor for BookingDetail object.
        /// </summary>
        /// <param name="ID_Param"></param>
        public BookingDetail(int ID_Param)
        {
            ID = ID_Param;
        }
    }
}
