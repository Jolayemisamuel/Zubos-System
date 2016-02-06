﻿using System;
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

        /// <summary>
        /// Method to initialise application for boot up.
        /// </summary>
        public static void InitialiseApplication()
        {

        }
        /// <summary>
        /// Method to finalise for application exit.
        /// </summary>
        public static void FinaliseApplication()
        {
            bool isError = !DataAccess.CloseSQLConnection();

            Logger.FinaliseLogger();

            if(!isError)
            {
                Environment.Exit(0);
            }
        }

        public static void test()
        {
            Logger.WriteLine("WARNING", "TESTING TEST TESTSFNSGJDNGJG");
            Logger.WriteLine("ERROR", "TESTING TEST TESTSFNSGJDNGJG");
            Logger.WriteLine("DEBUG", "TESTING TEST TESTSFNSGJDNGJG");
            Logger.WriteLine("EVENT", "TESTING TEST TESTSFNSGJDNGJG");
            Logger.WriteLine(null, "TESTING TEST TESTSFNSGJDNGJG");
        }
    }
}
