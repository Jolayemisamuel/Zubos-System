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
        public int                              BookingDetailID { get; set; }
        public DateTime                         DateStart { get; set; }
        public DateTime                         DateComplete { get; set; }
        public double                           PaymentAmount { get; set; }
        public Room                             myRoom { get; set; }
        public SortedList<int, Customer>        myCustomers { get; set; }

        /// <summary>
        /// Default constructor for BookingDetail object.
        /// </summary>
        public BookingDetail()
        {

        }

        public BookingDetail
                            (int pID, 
                            DateTime pDateStart,
                            double pPaymentAmount,
                            Room pMyRoom,
                            SortedList<int, Customer> pMyCustomers)
        {
            BookingDetailID = pID;
            DateStart = pDateStart;
            PaymentAmount = pPaymentAmount;
            myRoom = pMyRoom;
            myCustomers = pMyCustomers;
        }
    }
}
