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
        private static void AddToAllConnections(string pConnectionKey, SqlConnection pConnection)
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
            {//Connection string exists in config.
                try
                {
                    SqlConnection connection = new SqlConnection(connectionString);

                    connection.Open();
                    AddToAllConnections(pConnectionStringConfigurationName, connection);
                    
                    return (connection.State == ConnectionState.Open) ? connection : null;
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
        private static int CheckConnectionIsReady(ref SqlConnection pConnectionToCheck, string pConnectionConfigurationName)
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
                Logger.WriteLine("DEBUG", "No connection, trying to create one...");
                int maximumRetrys = 3;
                for (int connectionRetrys = 1; connectionRetrys <= maximumRetrys; connectionRetrys++)
                {
                    pConnectionToCheck = CreateSQLConnection(pConnectionConfigurationName);
                    if (pConnectionToCheck != null && pConnectionToCheck.State == ConnectionState.Open)
                    {//Connection created and Ready to use
                        Logger.WriteLine("DEBUG", "Retry: " + connectionRetrys + ", Connection established successfully.");
                        return 1;
                    }
                    Logger.WriteLine("DEBUG", "Retry: " + connectionRetrys + ", Attempt to establish connection failed.");
                }
                if(pConnectionToCheck == null)
                {//Connection still null after 3 tries to create.
                    Logger.WriteLine("DEBUG", "Application has failed to create a connection.");
                    return 3;
                }
            }
            Logger.WriteLine("DEBUG", "Unknown error occured. Application has failed to create a connection.");
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
        public static List<T> ReturnAllResultsAsList<T>(string pConnectionToUse, string pTableName) where T : new()
        {
            SqlConnection SQL_CONNECTION = LookupConnection(pConnectionToUse);
            if (CheckConnectionIsReady(ref SQL_CONNECTION, "ODS") == 1)
            {
                SqlCommand sqlCmd = new SqlCommand("SELECT * FROM " + pTableName, SQL_CONNECTION);
                sqlCmd.CommandType = CommandType.Text;
                SqlDataReader DataReader = sqlCmd.ExecuteReader();

                if (DataReader.HasRows)
                {//Some Data exists
                    Logger.WriteLine("DEBUG", "Retrieving data...");
                    List<PropertyInfo> TProperties = typeof(T).GetProperties().ToList();
                    List<T> resultsList = new List<T>();
                    string readValue = null;
                    int outType = 0;

                    while (DataReader.Read())
                    {
                        var GenericObject = new T();
                        foreach (var property in TProperties)
                        {
                            outType = 0;
                            readValue = null;
                            if (DataReader[property.Name] != DBNull.Value)
                            {
                                readValue = DataReader[property.Name].ToString();
                            }
                            if (!String.IsNullOrEmpty(readValue))
                            {
                                if (HelperMethods.isTypeSafeForDataMap<T>(property, out outType))
                                {
                                    property.SetValue(GenericObject, Convert.ChangeType(readValue, property.PropertyType), null);
                                }
                            }
                        }
                        resultsList.Add(GenericObject);
                    }
                    Logger.WriteLine("DEBUG", "Propertys mapped, returning table results list.");
                    DataReader.Close();
                    return resultsList;
                }
            }
            else
            {
                Logger.WriteLine("ERROR", "No open connection, query execution failed.");
            }
            //-------//
            return null;
        }
        /// <summary>
        /// This method will execute a SELECT all columns in pColumnsToSelect FROM pTableName and return the results of a list of type T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="pConnectionToUse"></param>
        /// <param name="pTableName"></param>
        /// <param name="pColumnsToSelect"></param>
        /// <returns></returns>
        public static List<T> ReturnSelectiveResultsAsList<T>(string pConnectionToUse, string pTableName, List<string> pColumnsToSelect) where T : new()
        {
            SqlConnection SQL_CONNECTION = LookupConnection(pConnectionToUse);
            if (CheckConnectionIsReady(ref SQL_CONNECTION, "ODS") == 1)
            {
                string columnsToSelect = HelperMethods.BuildSQLColumnCmdString(pColumnsToSelect);
                SqlCommand sqlCmd = new SqlCommand("SELECT " + columnsToSelect + " FROM " + pTableName, SQL_CONNECTION);
                sqlCmd.CommandType = CommandType.Text;
                SqlDataReader DataReader = sqlCmd.ExecuteReader();

                if (DataReader.HasRows)
                {//Some Data Exists
                    Logger.WriteLine("DEBUG", "Retrieving data...");
                    List<PropertyInfo> TProperties = HelperMethods.RemoveUnwantedProperties(pColumnsToSelect, typeof(T).GetProperties().ToList());
                    List<T> resultsList = new List<T>();
                    string readValue;
                    int outType;

                    while (DataReader.Read())
                    {
                        var GenericObject = new T();

                        foreach (var property in TProperties)
                        {
                            readValue = null;
                            outType = 0;
                            if (DataReader[property.Name] != DBNull.Value)
                            {
                                readValue = DataReader[property.Name].ToString();
                            }
                            if (!String.IsNullOrEmpty(readValue))
                            {
                                if(HelperMethods.isTypeSafeForDataMap<T>(property, out outType))
                                {
                                    property.SetValue(GenericObject, Convert.ChangeType(readValue, property.PropertyType), null);
                                }
                            }
                        }
                        resultsList.Add(GenericObject);
                    }
                    Logger.WriteLine("DEBUG", "Propertys mapped, returning table results list.");
                    DataReader.Close();
                    return resultsList;
                }
            }
            else
            {
                Logger.WriteLine("ERROR", "No open connection, query execution failed.");
            }
            //-------//
            return null;
        }
        /// <summary>
        /// Will return a sorted list of objects with objects ID as key and object as value.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="pConnectionToUse"></param>
        /// <param name="pTableName"></param>
        /// <param name="pColumnsToSelect"></param>
        /// <returns></returns>
        public static SortedList<int, T> ReturnAllResultsAsSortedList<T>(string pConnectionToUse, string pTableName) where T : new()
        {
            SqlConnection SQL_CONNECTION = LookupConnection(pConnectionToUse);
            if (CheckConnectionIsReady(ref SQL_CONNECTION, "ODS") == 1)
            {
                SqlCommand sqlCmd = new SqlCommand("SELECT * FROM " + pTableName, SQL_CONNECTION);
                sqlCmd.CommandType = CommandType.Text;
                SqlDataReader DataReader = sqlCmd.ExecuteReader();

                if (DataReader.HasRows)
                {//Some Data Exists
                    Logger.WriteLine("DEBUG", "Retrieving data...");
                    List<PropertyInfo> TProperties = typeof(T).GetProperties().ToList();
                    SortedList<int, T> resultsList = new SortedList<int, T>();
                    int PropertyIndex;
                    int ObjectsID;
                    int outType;
                    string readValue;

                    while (DataReader.Read())
                    {
                        var GenericObject = new T();
                        outType = 0;
                        PropertyIndex = 0;
                        ObjectsID = 0;

                        foreach (var property in TProperties)
                        {
                            readValue = null;
                            PropertyIndex++;
                            if (DataReader[property.Name] != DBNull.Value)
                            {
                                readValue = DataReader[property.Name].ToString();
                                if(PropertyIndex == 1) { ObjectsID = Convert.ToInt32(readValue); }
                            }
                            if (!String.IsNullOrEmpty(readValue))
                            {
                                if (HelperMethods.isTypeSafeForDataMap<T>(property, out outType))
                                {
                                    property.SetValue(GenericObject, Convert.ChangeType(readValue, property.PropertyType), null);
                                }
                            }
                        }
                        resultsList.Add(ObjectsID, GenericObject);
                        PropertyIndex = 0;
                    }
                        Logger.WriteLine("DEBUG", "Propertys mapped, returning table results list.");
                        DataReader.Close();
                        return resultsList;
                }
            }
            else
            {
                Logger.WriteLine("ERROR", "No open connection, query execution failed.");
            }
            //-------//
            return null;
        }
        /// <summary>
        /// This method will execute a SELECT * FROM table as parameter and return results as a datatable.
        /// </summary>
        /// <param name="pConnectionToUse"></param>
        /// <param name="pTableName"></param>
        /// <returns></returns>
        public static DataTable ReturnAllResultsAsDataTable(string pConnectionToUse, string pTableName)
        {
            SqlConnection SQL_CONNECTION = LookupConnection(pConnectionToUse);
            if (CheckConnectionIsReady(ref SQL_CONNECTION, "ODS") == 1)
            {
                SqlCommand sqlCmd = new SqlCommand("SELECT * FROM " + pTableName, SQL_CONNECTION);
                sqlCmd.CommandType = CommandType.Text;
                SqlDataReader DataReader = sqlCmd.ExecuteReader();

                if (DataReader.HasRows)
                {//Some Data exists
                    Logger.WriteLine("DEBUG", "Retrieving data...");
                    DataTable resultsDataTable = new DataTable();
                    resultsDataTable.Load(DataReader);
                    Logger.WriteLine("DEBUG", "DataTable loaded, returning table results list.");
                    DataReader.Close();
                    return resultsDataTable;
                }
            }
            else
            {
                Logger.WriteLine("ERROR", "No open connection, query execution failed.");
            }
            //-------//
            return null;
        }
        
        public static T ReturnObjectByID<T>(string pConnectionToUse, string pTableName, int pID) where T : new()
        {
            SqlConnection SQL_CONNECTION = LookupConnection(pConnectionToUse);
            if (CheckConnectionIsReady(ref SQL_CONNECTION, "ODS") == 1)
            {
                List<PropertyInfo> TProperties = typeof(T).GetProperties().ToList();

                SqlCommand sqlCmd = new SqlCommand("SELECT TOP 1 * FROM " + pTableName + " WHERE " + TProperties[0].Name + " = " + pID, SQL_CONNECTION);
                sqlCmd.CommandType = CommandType.Text;
                SqlDataReader DataReader = sqlCmd.ExecuteReader();

                if (DataReader.HasRows)
                {//Some Data Exists
                    Logger.WriteLine("DEBUG", "Retrieving data...");
                    int outType = 0;
                    string readValue;
                    var GenericObject = new T();

                    while (DataReader.Read())
                    {
                        foreach (var property in TProperties)
                        {
                            readValue = null;
                            if (DataReader[property.Name] != DBNull.Value)
                            {
                                readValue = DataReader[property.Name].ToString();
                            }
                            if (!String.IsNullOrEmpty(readValue))
                            {
                                if (HelperMethods.isTypeSafeForDataMap<T>(property, out outType))
                                {
                                    property.SetValue(GenericObject, Convert.ChangeType(readValue, property.PropertyType), null);
                                }
                            }
                        }
                    }
                    Logger.WriteLine("DEBUG", "Propertys mapped, returning object.");
                    DataReader.Close();
                    return GenericObject;
                }
            }
            else
            {
                Logger.WriteLine("ERROR", "No open connection, query execution failed.");
            }
            //-------//
            return default(T);
        }
        /// <summary>
        /// Will return the next ID for use for creating new objects.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="pConnectionToUse"></param>
        /// <returns></returns>
        public static int ReturnNextID<T>(string pConnectionToUse)
        {
            SqlConnection SQL_CONNECTION = LookupConnection(pConnectionToUse);
            if (CheckConnectionIsReady(ref SQL_CONNECTION, "ODS") == 1)
            {
                List<PropertyInfo> TProperties = typeof(T).GetProperties().ToList();
                string TableName = typeof(T).Name;
                SqlCommand sqlCmd = new SqlCommand("IF EXISTS((SELECT TOP 1" + TProperties[0].Name +
                                                     " FROM " + TableName + ")) BEGIN SELECT MAX(" +
                                                     TProperties[0].Name + ") FROM " +
                                                    TableName + " END ELSE BEGIN SELECT 1 END;", SQL_CONNECTION);

                sqlCmd.CommandType = CommandType.Text;

                Logger.WriteLine("DEBUG", "Retrieving next ID...");
                int NextID;
                try
                {
                    NextID = (int)sqlCmd.ExecuteScalar();
                    if (NextID != 1) { NextID++; }
                }
                catch (SqlException sqlEx)
                {
                    string[] errorMsgs = new string[] { "A SQL exception occurred.", sqlEx.Message };
                    Logger.WriteLine("ERROR", errorMsgs);
                    return 0;
                }
                catch (Exception Ex)
                {
                    string[] errorMsgs = new string[] { "An exception occured.", Ex.Message };
                    Logger.WriteLine("ERROR", errorMsgs);
                    return 0;
                }
                Logger.WriteLine("DEBUG", "Next ID query successful.");
                return NextID;
            }
            else
            {
                Logger.WriteLine("ERROR", "No open connection, query execution failed.");
            }
            //-------//
            return 0;
        }
        /// <summary>
        /// Executes a query and tries to return a boolean value from it.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="pConnectionToUse"></param>
        /// <param name="pQuery"></param>
        /// <returns></returns>
        public static bool ExecuteBoolReturnQuery(string pConnectionToUse, SqlCommand pQuery)
        {
            SqlConnection SQL_CONNECTION = LookupConnection(pConnectionToUse);
            if (CheckConnectionIsReady(ref SQL_CONNECTION, "ODS") == 1)
            {
                pQuery.Connection = SQL_CONNECTION; 
                pQuery.CommandType = CommandType.Text;

                Logger.WriteLine("DEBUG", "Executing bool query...");
                bool returnBoolean;
                try
                {
                    returnBoolean = ((int)pQuery.ExecuteScalar() == 1);
                }
                catch (SqlException sqlEx)
                {
                    string[] errorMsgs = new string[] { "A SQL exception occurred.", sqlEx.Message };
                    Logger.WriteLine("ERROR", errorMsgs);
                    return false;
                }
                catch (Exception Ex)
                {
                    string[] errorMsgs = new string[] { "An exception occured.", Ex.Message };
                    Logger.WriteLine("ERROR", errorMsgs);
                    return false;
                }
                Logger.WriteLine("DEBUG", "Boolean value returned successfully.");
                return returnBoolean;
            }
            else
            {
                Logger.WriteLine("ERROR", "No open connection, query execution failed.");
            }
            //-------//
            return false;
        }
        /// <summary>
        /// This method will attempt to execute a query and return an integer.
        /// </summary>
        /// <param name="pConnectionToUse"></param>
        /// <param name="pQuery"></param>
        /// <returns></returns>
        public static int ExecuteIntegerReturnQuery(string pConnectionToUse, SqlCommand pQuery)
        {
            SqlConnection SQL_CONNECTION = LookupConnection(pConnectionToUse);
            if (CheckConnectionIsReady(ref SQL_CONNECTION, "ODS") == 1)
            {
                pQuery.Connection = SQL_CONNECTION;
                pQuery.CommandType = CommandType.Text;

                Logger.WriteLine("DEBUG", "Executing integer query...");
                int returnInt;
                try
                {
                    returnInt = (int)pQuery.ExecuteScalar();
                }
                catch (SqlException sqlEx)
                {
                    string[] errorMsgs = new string[] { "A SQL exception occurred.", sqlEx.Message };
                    Logger.WriteLine("ERROR", errorMsgs);
                    return 0;
                }
                catch (Exception Ex)
                {
                    string[] errorMsgs = new string[] { "An exception occured.", Ex.Message };
                    Logger.WriteLine("ERROR", errorMsgs);
                    return 0;
                }
                Logger.WriteLine("DEBUG", "Integer value returned successfully.");
                return returnInt;
            }
            else
            {
                Logger.WriteLine("ERROR", "No open connection, query execution failed.");
            }
            //-------//
            return 0;
        }
        /// <summary>
        /// Executes an update query and returns the amount of rows affected.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="pConnectionToUse"></param>
        /// <param name="pQueryText"></param>
        /// <returns></returns>
        public static int ExecuteUpdateQuery(string pConnectionToUse, string pTableName, List<string> pColumnsToUpdate, List<string> pColumnValues, string pCondition)
        {
            SqlConnection SQL_CONNECTION = LookupConnection(pConnectionToUse);
            if (CheckConnectionIsReady(ref SQL_CONNECTION, "ODS") == 1)
            {

                string processedColumnString = HelperMethods.BuildSQLUpdateColumnValueString(pColumnsToUpdate, pColumnValues);

                SqlCommand sqlCmd = new SqlCommand("UPDATE [" + pTableName + "] SET " + processedColumnString + " " + pCondition, SQL_CONNECTION);
                sqlCmd.CommandType = CommandType.Text;

                Logger.WriteLine("DEBUG", "Executing update query...");
                int returnInt;
                try
                {
                    returnInt = (int)sqlCmd.ExecuteNonQuery();
                }
                catch (SqlException sqlEx)
                {
                    string[] errorMsgs = new string[] { "A SQL exception occurred.", sqlEx.Message };
                    Logger.WriteLine("ERROR", errorMsgs);
                    return 0;
                }
                catch (Exception Ex)
                {
                    string[] errorMsgs = new string[] { "An exception occured.", Ex.Message };
                    Logger.WriteLine("ERROR", errorMsgs);
                    return 0;
                }
                Logger.WriteLine("DEBUG", "Update query executed successfully.");
                return returnInt;
            }
            else
            {
                Logger.WriteLine("ERROR", "No open connection, query execution failed.");
            }
            //-------//
            return 0;
        }
        /// <summary>
        /// Will execute an insert query to insert columns and values into table and returns amount of rows affected.
        /// </summary>
        /// <param name="pConnectionToUse"></param>
        /// <param name="pTableName"></param>
        /// <param name="pColumnsToUpdate"></param>
        /// <param name="pColumnValues"></param>
        /// <returns></returns>
        public static int ExecuteInsertQuery(string pConnectionToUse, string pTableName, List<PropertyInfo> pColumnsToUpdate, List<Tuple<Type, string>> pColumnValues)
        {
            SqlConnection SQL_CONNECTION = LookupConnection(pConnectionToUse);
            if (CheckConnectionIsReady(ref SQL_CONNECTION, "ODS") == 1)
            {
                string processedColumnString = HelperMethods.BuildSQLInsertIntoColumnValueString(pColumnsToUpdate, pColumnValues);

                SqlCommand sqlCmd = new SqlCommand("INSERT INTO [" + pTableName + "] " + processedColumnString, SQL_CONNECTION);
                sqlCmd.CommandType = CommandType.Text;

                Logger.WriteLine("DEBUG", "Executing insert query...");
                int returnInt;
                try
                {
                    returnInt = (int)sqlCmd.ExecuteNonQuery();
                }
                catch (SqlException sqlEx)
                {
                    string[] errorMsgs = new string[] { "A SQL exception occurred.", sqlEx.Message };
                    Logger.WriteLine("ERROR", errorMsgs);
                    return 0;
                }
                catch (Exception Ex)
                {
                    string[] errorMsgs = new string[] { "An exception occured.", Ex.Message };
                    Logger.WriteLine("ERROR", errorMsgs);
                    return 0;
                }
                Logger.WriteLine("DEBUG", "Insert query executed successfully.");
                return returnInt;
            }
            else
            {
                Logger.WriteLine("ERROR", "No open connection, query execution failed.");
            }
            //-------//
            return 0;
        }
        /// <summary>
        /// This method will add parameters to a passed in SQLcommand object.
        /// </summary>
        /// <param name="pSQLCommandObj"></param>
        /// <param name="pParametersAndValues"></param>
        /// <returns></returns>
        public static void AddParametersToSQLCMD(ref SqlCommand pSQLCommandObj, SortedList<string, object> pParametersAndValues)
        {
            if(pSQLCommandObj != null)
            {
                for (int Indexer = 0; Indexer < pParametersAndValues.Count; Indexer++)
                {
                    if(pParametersAndValues.Keys[Indexer].StartsWith("@"))
                    {
                        pSQLCommandObj.Parameters.Add(new SqlParameter(pParametersAndValues.Keys[Indexer], pParametersAndValues.Values[Indexer]));
                    }
                    else
                    {
                        pSQLCommandObj.Parameters.Add(new SqlParameter("@" + pParametersAndValues.Keys[Indexer], pParametersAndValues.Values[Indexer]));
                    }
                }
            }
        }
    }
}
