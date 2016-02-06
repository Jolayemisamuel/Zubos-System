using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zubos.System.Data
{
    public static class DataAccess
    {
        /// <summary>
        /// Holds a SQL connection for use by Business layer.
        /// </summary>
        public static SqlConnection SQLConnection
        {
            get {
                   return (SQLConnection == null) ? GetSQLConnection() : SQLConnection;
                }
        }

        /// <summary>
        /// A method to get a SQL connection.
        /// </summary>
        /// <returns></returns>
        public static SqlConnection GetSQLConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ODS"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            return connection;
        }
        /// <summary>
        /// A method to close ODS SQL connection.
        /// </summary>
        /// <returns>Returns true if closed successfully.</returns>
        public static bool CloseSQLConnection()
        {
            try
            {
                SQLConnection.Close();
                SQLConnection.Dispose();
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("An exception has occured. \n" + sqlEx.LineNumber + "::" + sqlEx.Message, "SQL Exception:" + sqlEx.Number + "::" + sqlEx.Server);
            }
            return (SQLConnection == null) ? true : false;
        }

    }
}
