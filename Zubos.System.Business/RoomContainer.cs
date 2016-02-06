using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zubos.System.Business
{
    /// <summary>
    /// Class to hold (or categorize) room objects.
    /// </summary>
    public class RoomContainer
    {
        public int                              ID { get; }
        public static SortedList<int, Room>     myRooms { get; }

        /// <summary>
        /// Default constructor for RoomContainer
        /// </summary>
        /// <param name="ID_Param"></param>
        public RoomContainer(int ID_Param)
        {
            ID = ID_Param;
        }
    }
}
