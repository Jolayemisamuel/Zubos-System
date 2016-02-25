using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Diagnostics;
using System.Windows.Forms;
using Zubos.System.Data;

namespace Zubos.System.Business
{
    /// <summary>
    /// Global static class, top level.
    /// </summary>
    public static class Global
    {
        public static SortedList<int, RoomContainer> AllRoomContainers { get; }
        public static SortedList<int, Customer> AllCustomers { get; }

        /// <summary>
        /// Method to initialise application for boot up.
        /// </summary>
        public static void InitialiseApplication()
        {
            Logger.InitialiseLogger();
        }
        /// <summary>
        /// Method to finalise for application exit.
        /// </summary>
        public static void FinaliseApplication()
        {
            Logger.FinaliseLogger();
            DataAccess.CloseAllSQLConnections();

            Environment.Exit(0);
        }
        public static void OpenTodaysLog()
        {
            Process.Start(Logger.GetCurrentLogPath());
        }

        public static void test()
        {
            List<Room> newRoomList = DataAccess.ReturnResultsAsList<Room>("ODS", "Room", new List<string> { "RoomID", "Name", "Price" });
            List<Room> newRoomList2 = DataAccess.ReturnTableResultsAsList<Room>("ODS", "Room");
            int i2 = 0;
            foreach (var item in newRoomList2)
            {

                Logger.WriteLine("EVENT", newRoomList2[i2].RoomID.ToSafeString());
                Logger.WriteLine("EVENT", newRoomList2[i2].Name.ToSafeString());
                Logger.WriteLine("EVENT", newRoomList2[i2].Price.ToSafeString());
                Logger.WriteLine("EVENT", newRoomList2[i2].AdditionalInfo.ToSafeString());
                Logger.WriteLine("EVENT", newRoomList2[i2].myCustomers.ToSafeString());
                Logger.WriteLine("EVENT", newRoomList2[i2].myRoomContainers.ToSafeString());
                i2++;
            }
            List<Customer> newlist = DataAccess.ReturnTableResultsAsList<Customer>("ODS", "Customer");
            int i = 0;
            foreach (var item in newlist)
            {

                Logger.WriteLine("EVENT", newlist[i].CustomerID.ToSafeString());
                Logger.WriteLine("EVENT", newlist[i].Name.ToSafeString());
                Logger.WriteLine("EVENT", newlist[i].HouseNumber.ToSafeString());
                Logger.WriteLine("EVENT", newlist[i].HouseName.ToSafeString());
                Logger.WriteLine("EVENT", newlist[i].Street.ToSafeString());
                Logger.WriteLine("EVENT", newlist[i].Postcode.ToSafeString());
                i++;
                    }

        }
    }
}
