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
        /// Holds a SQL connection.
        /// </summary>
        private static SqlConnection _SQLConnection;

        public static SqlConnection SQLConnection
        {
            get
            {
                if (_SQLConnection == null)
                {
                    _SQLConnection = GetSQLConnection();
                    return _SQLConnection;
                }
                else
                {
                    return _SQLConnection;
                }
            }
        }
        /// <summary>
        /// A method to create a new SQL connection using ODS connection string.
        /// </summary>
        /// <returns>Returns a SQL connection if none exist</returns>
        private static SqlConnection GetSQLConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ODS"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            return connection;
        }
        /// <summary>
        /// A method to close SQL connection.
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
                MessageBox.Show("An exception with SQL has occured. \n" + sqlEx.LineNumber + "::" + sqlEx.Message, "SQL Exception:" + sqlEx.Number + "::" + sqlEx.Server);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("An exception has occured. \n" + Ex.Message);
            }
            return (SQLConnection == null) ? true : false;
        }

    }
}
