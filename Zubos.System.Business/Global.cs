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
    /// Global static class, top level.
    /// </summary>
    public static class Global
    {

        /// <summary>
        /// Method to initialise application for boot up.
        /// </summary>
        public static void InitialiseApplication()
        {
            Logger.InitialiseLogger();
            Logger.WriteLine("EVENT", "Application Started.");
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

        public static void test()
        {
            
        }
    }
}
