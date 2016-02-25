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
        /// Holds SQL connections.
        /// </summary>
        private static SortedList<string, SqlConnection> allConnections = new SortedList<string, SqlConnection>();
        /// <summary>
        /// Method to lookup connection and pass it back if found.
        /// </summary>
        /// <param name="pKeyToSearchFor"></param>
        /// <returns></returns>
        public static SqlConnection LookupConnection(string pKeyToSearchFor)
        {
            int connectionIndex = allConnections.Keys.IndexOf(pKeyToSearchFor);
            if (connectionIndex != -1 && allConnections.Values[connectionIndex] != null)
            {
                return allConnections.Values[allConnections.Keys.IndexOf(pKeyToSearchFor)];
            }
            return null;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pConnectionToAdd"></param>
        /// <returns></returns>
        public static void AddToAllConnections(string pConnectionKey, SqlConnection pConnection)
        {
            int connectionIndex = allConnections.Keys.IndexOf(pConnectionKey);
            if (connectionIndex == -1)
            {
                allConnections.Add(pConnectionKey, pConnection);
            }
        }
        /// <summary>
        /// A method to create a new SQL connection using passed in config parameter connection string.
        /// </summary>
        /// <returns>Returns a SQL connection if none exist</returns>
        private static SqlConnection CreateSQLConnection(string pConnectionStringConfigurationName)
        {
            string connectionString = ConfigurationManager.ConnectionStrings[pConnectionStringConfigurationName].ConnectionString;

            if (!String.IsNullOrEmpty(connectionString))
            {
                if (LookupConnection(pConnectionStringConfigurationName) == null)
                {
                    try
                    {
                        SqlConnection connection = new SqlConnection(connectionString);

                        connection.Open();
                        AddToAllConnections(pConnectionStringConfigurationName, connection);

                        SqlConnection createdConnection = (LookupConnection(pConnectionStringConfigurationName));
                        return (createdConnection.State == ConnectionState.Open) ? 
                                 createdConnection : null;
                    }
                    catch (SqlException sqlEx)
                    {
                        string[] errorMsgs = new string[] { "A SQL exception occurred.", sqlEx.Message };
                        Logger.WriteLine("ERROR", errorMsgs);
                    }
                    catch (Exception Ex)
                    {
                        string[] errorMsgs = new string[] { "An exception occured.", Ex.Message };
                        Logger.WriteLine("ERROR", errorMsgs);
                    }
                }
            }
            return null;
        }
        /// <summary>
        /// A method to close the SQL connection.
        /// </summary>
        /// <returns>Returns true if closed successfully.</returns>
        public static bool CloseSQLConnection(SqlConnection pConnectionToClose)
        {
            if (pConnectionToClose != null)
            {
                try
                {
                    pConnectionToClose.Close();
                    pConnectionToClose.Dispose();
                }
                catch (SqlException sqlEx)
                {
                    string[] errorMsgs = new string[] { "A SQL exception occurred.", sqlEx.Message };
                    Logger.WriteLine("ERROR", errorMsgs);
                }
                catch (Exception Ex)
                {
                    string[] errorMsgs = new string[] { "An exception occured.", Ex.Message };
                    Logger.WriteLine("ERROR", errorMsgs);
                }
            }
            return (pConnectionToClose.State == ConnectionState.Closed) ? true : false;
        }
        /// <summary>
        /// This method will return 1 if the connection is ready to use, 2 if connection not null but not open, 3 if null and 4 otherwise.
        /// </summary>
        /// <param name="pConnectionToCheck"></param>
        /// <returns></returns>
        public static int CheckConnectionIsReady(ref SqlConnection pConnectionToCheck, string pConnectionConfigurationName)
        {
            if(pConnectionToCheck != null && pConnectionToCheck.State == ConnectionState.Open)
            {//Connection Ready to use
                return 1;
            }
            else if(pConnectionToCheck != null && pConnectionToCheck.State != ConnectionState.Open)
            {//Connection Busy
                return 2;
            }
            else if(pConnectionToCheck == null)
            {//No connection, try to create one.
                int maximumRetrys = 3;
                for (int connectionRetrys = 1; connectionRetrys < maximumRetrys; connectionRetrys++)
                {
                    pConnectionToCheck = CreateSQLConnection(pConnectionConfigurationName);
                    if (pConnectionToCheck != null && pConnectionToCheck.State == ConnectionState.Open)
                    {
                        return 1;
                    }
                }
                if(pConnectionToCheck == null)
                {
                    return 3;
                }
                //Connection still null after 3 tries to create.
            }
            return 4;
        }
        /// <summary>
        /// Method to close all SQL connections.
        /// </summary>
        /// <param name="pConnectionToClose"></param>
        /// <returns></returns>
        public static void CloseAllSQLConnections()
        {
            try
            {
                foreach (SqlConnection varConnectionToClose in allConnections.Values)
                {
                    varConnectionToClose.Close();
                    varConnectionToClose.Dispose();
                }
            }
            catch (SqlException sqlEx)
            {
                string[] errorMsgs = new string[] { "A SQL exception occurred.", sqlEx.Message };
                Logger.WriteLine("ERROR", errorMsgs);
            }
            catch (Exception Ex)
            {
                string[] errorMsgs = new string[] { "An exception occured.", Ex.Message };
                Logger.WriteLine("ERROR", errorMsgs);
            }
        }
        /// <summary>
        /// This method will execute a SELECT * FROM a table taken as a parameter and return the results as a List of type T.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="pConnectionToUse"></param>
        /// <param name="pTableName"></param>
        /// <returns></returns>
        public static List<T> ReturnTableResultsAsList<T>(string pConnectionToUse, string pTableName) where T : new()
        {
            SqlConnection SQL_CONNECTION = LookupConnection(pConnectionToUse);
            if (CheckConnectionIsReady(ref SQL_CONNECTION, "ODS") == 1)
            {
                SqlCommand Verify_Table_Cmd = new SqlCommand("SELECT CASE WHEN EXISTS((SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = '"
                                                            + pTableName + "')) THEN 1 ELSE 0 END;", SQL_CONNECTION);
                int DoesTableExists = (int)Verify_Table_Cmd.ExecuteScalar();

                if (DoesTableExists == 1)
                {
                    SqlCommand sqlCmd = new SqlCommand("SELECT * FROM " + pTableName, SQL_CONNECTION);
                    sqlCmd.CommandType = CommandType.Text;
                    SqlDataReader DataReader = sqlCmd.ExecuteReader();

                    if (DataReader.HasRows)
                    {
                        List<PropertyInfo> TProperties = typeof(T).GetProperties().ToList();
                        List<T> resultsList = new List<T>();
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
                                    property.SetValue(GenericObject, Convert.ChangeType(readValue, property.PropertyType), null);
                                }
                            }
                            resultsList.Add((T)GenericObject);
                        }
                        Logger.WriteLine("DEBUG", "Propertys mapped, returning table results list.");
                        DataReader.Close();
                        return resultsList;
                    }
                }
                Logger.WriteLine("ERROR", "Could not find table, query execution failed. Table may not exist.");
            }
            else
            {
                Logger.WriteLine("ERROR", "No open connection, query execution failed.");
            }
            //-------//
            return null;
        }
    }
}
