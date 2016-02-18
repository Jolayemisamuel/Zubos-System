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

        public static List<T> ExecuteSelectQuery<T>(SqlConnection Connection_param, string Query_param) where T : new()
        {
            using (Connection_param)
            {
                List<PropertyInfo> TProperties = typeof(T).GetProperties().ToList();

                SqlCommand check_table = new SqlCommand("select case when exists((select * from information_schema.tables where table_name = 'Zubos.Customer')) then 1 else 0 end",Connection_param);
                int IsTableExists = (int)check_table.ExecuteScalar();

                SqlCommand sqlCmd = new SqlCommand(Query_param, Connection_param);
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
                }


                DataReader.Close();
                return resultsList;
            }

        }
    }
}
