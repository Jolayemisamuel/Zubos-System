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
using System.IO;
using Zubos.System.Data;

namespace Zubos.System.Business
{
    /// <summary>
    /// Global static class, public to all.
    /// </summary>
    public static class Global
    {
        public static Dictionary<string, string> DBConfig = new Dictionary<string, string>();
        /// <summary>
        /// Method to initialise application for boot up.
        /// </summary>
        public static void InitialiseApplication()
        {
            Logger.InitialiseLogger();
            Logger.WriteLine("EVENT", "Application Started.");
            if(LoadDBConfigValues()) { Logger.WriteLine("EVENT", "Database configuration settings loaded successfully."); }
            else { Logger.WriteLine("ERROR", "Failed to load database configuration settings."); }
        }
        /// <summary>
        /// Method to finalise for application exit.
        /// </summary>
        public static void FinaliseApplication()
        {
            Logger.WriteLine("EVENT", "Application Ended.");
            Logger.FinaliseLogger();
            DataAccess.CloseAllSQLConnections();

            Environment.Exit(0);
        }
        public static void OpenTodaysLog()
        {
            string logPath = Logger.GetCurrentLogPath();
            if (File.Exists(logPath))
            {
                Process.Start(logPath);
            }
        }
        public static bool LoadDBConfigValues()
        {
            try
            {
                DBConfig.Add("RoomsTN", ConfigurationHelper.ReadSettingAsString("Rooms_TableName"));
                DBConfig.Add("BookingTN", ConfigurationHelper.ReadSettingAsString("Booking_TableName"));
                DBConfig.Add("CustomerTN", ConfigurationHelper.ReadSettingAsString("Customer_TableName"));
                DBConfig.Add("RoomContainerTN", ConfigurationHelper.ReadSettingAsString("RoomContainer_TableName"));
            }
            catch (Exception Ex)
            {
                string[] errorMsgs = new string[] { "An exception occured.", Ex.Message };
                Logger.WriteLine("ERROR", errorMsgs);
                return false;
            }
            return true;
        }

        public static void test()
        {
            
        }
    }
}
