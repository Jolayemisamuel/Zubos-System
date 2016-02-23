using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Zubos.System.Data
{
    public static class DataAccess
    {
        /// <summary>
        /// Holds a SQL connection.
        /// </summary>
        private static SqlConnection _ODSConnection;
        public static SqlConnection ODSConnection
        {
            get { return _ODSConnection; }
            set { _ODSConnection = value; }
        }
        /// <summary>
        /// A method to create a new SQL connection using ODS connection string.
        /// </summary>
        /// <returns>Returns a SQL connection if none exist</returns>
        private static SqlConnection GetNewODSConnection()
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
        public static bool CloseSQLConnection(SqlConnection ConnectionToClose_param)
        {
            if (ConnectionToClose_param != null)
            {
                try
                {
                    ConnectionToClose_param.Close();
                    ConnectionToClose_param.Dispose();
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
            return (ConnectionToClose_param.State == ConnectionState.Closed) ? true : false;
        }
        /// <summary>
        /// This method will return true if the passed in SQL connection is Open and ready for use, else false.
        /// </summary>
        /// <param name="ConnectionToCheck"></param>
        /// <returns></returns>
        public static bool CheckConnectionIsAlive(SqlConnection ConnectionToCheck)
        {
            return true;
        }

        /// <summary>
        /// This method will execute a SELECT * FROM a table taken as a parameter and return the results as a List of type T.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Connection_param"></param>
        /// <param name="TableName_param"></param>
        /// <returns></returns>
        public static List<T> ReturnTableResultsAsList<T>(SqlConnection Connection_param, string TableName_param) where T : new()
        {
            SqlCommand Verify_Table = new SqlCommand("SELECT CASE WHEN EXISTS((SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = '" 
                                                        + TableName_param + "')) THEN 1 ELSE 0 END;", Connection_param);
            int DoesTableExists = (int)Verify_Table.ExecuteScalar();

            if (DoesTableExists == 1)
            {
                List<PropertyInfo> TProperties = typeof(T).GetProperties().ToList();

                SqlCommand sqlCmd = new SqlCommand("SELECT * FROM d" + TableName_param, Connection_param);
                sqlCmd.CommandType = CommandType.Text;

                SqlDataReader DataReader = sqlCmd.ExecuteReader();

                List<T> resultsList = new List<T>();
                if (DataReader.HasRows)
                {
                    while (DataReader.Read())
                    {
                        var GenericObject = new T();
                        string readValue = null;

                        foreach (var property in TProperties)
                        {
                            readValue = null;
                            if (DataReader[property.Name] != DBNull.Value)
                            {
                                readValue = DataReader[property.Name].ToString();
                            }

                            if (!String.IsNullOrEmpty(readValue))
                            {
                                property.SetValue(GenericObject, readValue, null);
                            }
                        }
                        resultsList.Add((T)GenericObject);
                    }
                }
                DataReader.Close();
                return resultsList;
            }
            Logger.WriteLine("ERROR", "Could not find table, query execution failed.");
            return null;
        }
    }
}
