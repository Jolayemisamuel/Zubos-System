using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace Zubos.System.Data
{
    public static class HelperMethods
    {
        public static string ToSafeString(this object obj)
        {
            return (obj ?? string.Empty).ToString();
        }
        /// <summary>
        /// Will build a string out of passed in column names for select queries.
        /// </summary>
        /// <param name="pColumns"></param>
        /// <returns></returns>
        public static string BuildSQLColumnCmdString(List<string> pColumns)
        {
            string SqlCmdColumnBuilder = null;
            if (pColumns.Count != 0)
            {
                for (int ColumnIndex = 0; ColumnIndex < pColumns.Count; ColumnIndex++)
                {
                    if (ColumnIndex == 0)
                    {
                        SqlCmdColumnBuilder += "[" + pColumns[ColumnIndex] + "]";
                    }
                    else
                    {
                        SqlCmdColumnBuilder += ",[" + pColumns[ColumnIndex] + "]";
                    }
                }
                return SqlCmdColumnBuilder;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 1=String, 2=Int, 3=DateTime, 4=Double, 5=List(T), 6=SortedList(Int,T)
        /// </summary>
        /// <param name="pProperty"></param>
        /// <param name="TypeInt"></param>
        /// <returns></returns>
        public static bool isTypeSafeForDataMap<T>(PropertyInfo pProperty, out int TypeInt)
        {
            if (pProperty.PropertyType == typeof(string)) { TypeInt = 1; return true; }
            else if (pProperty.PropertyType == typeof(int)) { TypeInt = 2; return true; }
            else if (pProperty.PropertyType == typeof(DateTime)) { TypeInt = 3; return true; }
            else if (pProperty.PropertyType == typeof(double)) { TypeInt = 4; return true; }
            else if (pProperty.PropertyType == typeof(List<T>)) { TypeInt = 5; return false; }
            else if(pProperty.PropertyType == typeof(SortedList<int, T>)) { TypeInt = 6; return false; }
            //-----//
            TypeInt = 0;
            return false;
        }

        public static List<PropertyInfo> RemoveUnwantedProperties(List<string> pColumnsListToSearchFor, List<PropertyInfo> pColumnsListToRemoveFrom)
        {
            List<PropertyInfo> ProcessedColumnsList = new List<PropertyInfo>();

            foreach (PropertyInfo varProperty in pColumnsListToRemoveFrom)
            {
                if(pColumnsListToSearchFor.Count == 0) { break; }
                foreach (string column in pColumnsListToSearchFor)
                {
                    if (varProperty.Name == column)
                    {
                        pColumnsListToSearchFor.Remove(column);
                        ProcessedColumnsList.Add(varProperty);
                        break;
                    }
                }
            }
            return (ProcessedColumnsList.Count != 0) ? ProcessedColumnsList : null;
        }
    }
}
