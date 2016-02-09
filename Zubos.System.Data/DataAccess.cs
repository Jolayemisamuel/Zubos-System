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
                    _SQLConnection = GetNewSQLConnection();
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
        private static SqlConnection GetNewSQLConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ODS"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            return connection;
        }
        /// <summary>
        /// A method to close the SQL connection.
        /// </summary>
        /// <returns>Returns true if closed successfully.</returns>
        public static bool CloseSQLConnection()
        {
            if (SQLConnection != null)
            {
                try
                {
                    SQLConnection.Close();
                    SQLConnection.Dispose();
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("An exception with SQL has occured. " + Environment.NewLine + sqlEx.LineNumber + "::" + sqlEx.Message, "SQL Exception:" + sqlEx.Number + "::" + sqlEx.Server);
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("An exception has occured. \n" + Environment.NewLine + Ex.Message);
                }
            }
            return (SQLConnection.State == ConnectionState.Closed) ? true : false;
        }

        public static List<T> ExecuteQuery(SqlConnection Connection_param, string Query_param)
        {
            using (Connection_param)
            {
                SqlCommand sqlCmd = new SqlCommand(Query_param, Connection_param);
                sqlCmd.CommandType = CommandType.Text;

                SqlDataReader cmdReader = sqlCmd.ExecuteReader();

                if(cmdReader.HasRows)
                {
                    while(cmdReader.Read())
                    {

                    }
                }
                cmdReader.Close();
            }
        }
    }
}
