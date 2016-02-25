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
        public int                              RoomContainerID { get; set; }
        public string                           Name { get; set; }
        public string                           Description { get; set; }
        public static SortedList<int, Room>     myRooms { get; set; }

        /// <summary>
        /// Default constructor for RoomContainer
        /// </summary>
        public RoomContainer()
        {
        }
        
        public RoomContainer(int pID, 
                             string pName,
                             string pDescription,
                             SortedList<int, Room> pMyRooms)
        {
            RoomContainerID = pID;
            Name = pName;
            Description = pDescription;
            myRooms = pMyRooms;
        }
    }
}
