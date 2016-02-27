using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zubos.System.Data;

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

        /// <summary>
        /// Returns a string of RoomID and Name.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Name.ToString();
        }

        public static List<Room> GetAllRoomsSelectiveAsList(List<string> pRoomFieldNames)
        {
            List<Room> ResultsList = DataAccess.ReturnSelectiveResultsAsList<Room>("ODS", "Room", pRoomFieldNames);
            if (ResultsList != null)
            {
                return ResultsList;
            }
            else
            {
                MessageBox.Show("An error occured retrieving rooms data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public static List<Room> GetAllRoomsAsList()
        {
            List<Room> ResultsList = DataAccess.ReturnAllResultsAsList<Room>("ODS", "Room");
            if (ResultsList != null)
            {
                return ResultsList;
            }
            else
            {
                MessageBox.Show("An error occured retrieving rooms data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public static SortedList<int, Room> GetAllRoomsAsSortedList()
        {
            SortedList<int, Room> ResultsSortedList = DataAccess.ReturnAllResultsAsSortedList<Room>("ODS", "Room");
            if (ResultsSortedList != null)
            {
                return ResultsSortedList;
            }
            else
            {
                MessageBox.Show("An error occured retrieving rooms data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public static DataTable GetAllRoomsAsDataTable()
        {
            DataTable ResultsDataTable = DataAccess.ReturnAllResultsAsDataTable("ODS", "Room");
            if (ResultsDataTable != null)
            {
                return ResultsDataTable;
            }
            else
            {
                MessageBox.Show("An error occured retrieving rooms data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public static Room GetRoomByID(int pRoomID)
        {
            Room RoomToReturn = DataAccess.ReturnObjectByID<Room>("ODS", "Room", pRoomID);
            if (RoomToReturn != null)
            {
                return RoomToReturn;
            }
            else
            {
                MessageBox.Show("An error occured retrieving room data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
           
        }
    }
}
