using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zubos.System.Business
{
    /// <summary>
    /// Room object class.
    /// </summary>
    public class Room
    {
        public int                              ID { get; }
        public SortedList<int, Customer>        myCustomers { get; set; }
        public SortedList<int, RoomContainer>   myRoomContainers { get; set; }

        /// <summary>
        /// Default constructor for Room object.
        /// </summary>
        /// <param name="ID_param"></param>
        public Room(int ID_param)
        {
            ID = ID_param;
        }
    }
}
