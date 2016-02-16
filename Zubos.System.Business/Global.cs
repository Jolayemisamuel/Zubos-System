using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
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
        public static List<Form> AllOpenForms { get; } = new List<Form>();

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

            bool isError = !DataAccess.CloseSQLConnection();

            if(!isError)
            {
                Environment.Exit(0);
            }
        }

        public static void test()
        {
            List<Customer> newlist = DataAccess.ExecuteSelectQuery<Customer>(DataAccess.SQLConnection, "SELECT * FROM Zubos.Customer");
            int i = 0;
            foreach (var item in newlist)
            {

                Logger.WriteLine("EVENT", newlist[i].ID.ToString());
                Logger.WriteLine("EVENT", newlist[i].Name.ToString());
                Logger.WriteLine("EVENT", newlist[i].HouseNumber.ToString());
                Logger.WriteLine("EVENT", newlist[i].HouseName.ToString());
                Logger.WriteLine("EVENT", newlist[i].Street.ToString());
                Logger.WriteLine("EVENT", newlist[i].Postcode.ToString());
                i++;
                    }

        }
    }
}
