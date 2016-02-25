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
            Logger.WriteLine("DEBUG", "This is a test log.");
            Logger.WriteLine("WARNING", "This is a test log.");
            Logger.WriteLine("ERROR", "This is a test log.");
            Logger.WriteLine("EVENT", "This is a test log.");
            List<Customer> newlist = DataAccess.ReturnTableResultsAsList<Customer>("ODS", "Customer");
            int i = 0;
            foreach (var item in newlist)
            {

                Logger.WriteLine("EVENT", newlist[i].ID.ToSafeString());
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
