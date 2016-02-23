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
        /// <param name="pID"></param>
        /// <param name="pCustomers"></param>
        /// <param name="pRoom"></param>
        public BookingDetail
                            (int                        pID, 
                            SortedList<int, Customer>   pCustomers,
                            Room                        pRoom,
                            DateTime                    pDateStart,
                            double                      pPaymentAmount)
        {
            BookingReference = pID;
            myCustomers = pCustomers;
            myRoom = pRoom;
            DateStart = pDateStart;
            PaymentAmount = pPaymentAmount;
        }
    }
}
