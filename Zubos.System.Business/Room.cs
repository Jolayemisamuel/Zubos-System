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
        public int                              RoomID { get; set; }
        public string                           Name { get; set; }
        public double                           Price { get; set; }
        public string                           AdditionalInfo { get; set; }
        public SortedList<int, Customer>        myCustomers { get; set; }
        public SortedList<int, RoomContainer>   myRoomContainers { get; set; }

        /// <summary>
        /// Default constructor for Room object.
        /// </summary>
        public Room()
        {
            
        }

        public Room(int pID, 
                    string pName,
                    double pPrice,
                    string pAdditionalInfo,
                    SortedList<int, Customer> pMyCustomers, 
                    SortedList<int, RoomContainer> pMyRoomContainers)
        {
            RoomID = pID;
            Name = pName;
            Price = pPrice;
            AdditionalInfo = pAdditionalInfo;
            myCustomers = pMyCustomers;
            myRoomContainers = pMyRoomContainers;
        }

        public string RoomToString()
        {
            return "[ " + this.RoomID.ToString() + " ] " + this.Name.ToString();
        }
    }
}
