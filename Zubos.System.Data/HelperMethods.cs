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
            StringBuilder SB = new StringBuilder();
            if (pColumns.Count != 0)
            {
                for (int ColumnIndex = 0; ColumnIndex < pColumns.Count; ColumnIndex++)
                {
                    if (ColumnIndex == 0)
                    {
                        SB.Append("[" + pColumns[ColumnIndex] + "]");
                    }
                    else
                    {
                        SB.Append(",[" + pColumns[ColumnIndex] + "]");
                    }
                }
                return SB.ToString();
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// This method will build a string of column = value for each value in collection.
        /// </summary>
        /// <param name="pColumns"></param>
        /// <param name="pValues"></param>
        /// <returns></returns>
        public static string BuildSQLUpdateColumnValueString(List<string> pColumns, List<string> pValues)
        {
            StringBuilder SB = new StringBuilder();
            if (pColumns.Count != 0 && pColumns.Count == pValues.Count)
            {
                for (int ColumnIndex = 0; ColumnIndex < pColumns.Count; ColumnIndex++)
                {
                    if (ColumnIndex == 0)
                    {
                        SB.Append("[" + pColumns[ColumnIndex] + "] = " + pValues[ColumnIndex]);
                    }
                    else
                    {
                        SB.Append(",[" + pColumns[ColumnIndex] + "] = " + pValues[ColumnIndex]);
                    }
                }
                return SB.ToString();
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// This method will build columns and values string to be inserted into a table. (COLUMN, COLUMN) VALUES ('VALUE', 'VALUE')
        /// </summary>
        /// <param name="pColumns"></param>
        /// <param name="pValues"></param>
        /// <returns></returns>
        public static string BuildSQLInsertIntoColumnValueString(List<PropertyInfo> pColumns, List<Tuple<Type,string>> pValues)
        {
            StringBuilder SB = new StringBuilder();
            if (pColumns.Count != 0 && pColumns.Count == pValues.Count)
            {//Columns to insert to.
                for (int ColumnIndex = 0; ColumnIndex < pColumns.Count; ColumnIndex++)
                {
                    if (ColumnIndex == 0)
                    {
                        SB.Append("(" + pColumns[ColumnIndex].Name);
                    }
                    else
                    {
                        SB.Append(", " + pColumns[ColumnIndex].Name);
                    }
                    if(ColumnIndex == (pColumns.Count - 1))
                    {
                        SB.Append(") VALUES ");
                    }
                }
                //Values to be inserted.
                //ITEM 1 = Type
                //ITEM 2 = Value
                for (int ValueIndex = 0; ValueIndex < pValues.Count; ValueIndex++)
                {
                    if(ValueIndex == 0)
                    {//First value
                        if (pValues[ValueIndex].Item1 == typeof(int))
                        {//Integer value
                            SB.Append("(" + pValues[ValueIndex].Item2);
                        }
                        else
                        {//Quoted value ''
                            SB.Append("('" + pValues[ValueIndex].Item2 + "'");
                        }
                    }
                    else
                    {//Not first value
                        if (pValues[ValueIndex].Item1 == typeof(int))
                        {//Integer value
                            SB.Append(", " + pValues[ValueIndex].Item2);
                        }
                        else
                        {//Quoted value ''
                            SB.Append(", '" + pValues[ValueIndex].Item2 + "'");
                        }
                    }
                    if (ValueIndex == (pValues.Count - 1))
                    {//Last value to be added.
                        SB.Append(");");
                    }
                }
                return SB.ToString();
            }
            else
            {
                Logger.WriteLine("DEBUG", "Failed to match values to columns, mismatch in totals.");
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
        /// <summary>
        /// Returns a combined list but only where property doesnt exist in both.
        /// </summary>
        /// <param name="pColumnsListToSearchFor"></param>
        /// <param name="pColumnsListToRemoveFrom"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Will return the next the next ID for allocation to new objects.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static int GetNextID<T>()
        {
            return DataAccess.ReturnNextID<T>("ODS");
        }
        /// <summary>
        /// This method will return a string of ID's e.g 99;65;2009;394;55
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="pObjects"></param>
        /// <returns></returns>
        public static string GetObjectIDsAsString<T>(List<T> pObjects)
        {
            StringBuilder SB = new StringBuilder();
            for (int ObjectIndex = 0; ObjectIndex < pObjects.Count; ObjectIndex++)
            {
                if(ObjectIndex == 0)
                {
                    SB.Append(pObjects[ObjectIndex].GetType().GetProperties()[0].GetValue(pObjects[ObjectIndex], null));
                }
                else
                {
                    SB.Append(";" + pObjects[ObjectIndex].GetType().GetProperties()[0].GetValue(pObjects[ObjectIndex], null));
                }
            }
            return SB.ToString();
        }
        /// <summary>
        /// This method will build WHERE [Key = Column] = @p[Key], Pass in values [Value = Value to search for].
        /// </summary>
        /// <param name="pColumnConditions"></param>
        /// <returns></returns>
        public static string BuildSQLConditionsWithParams(SortedList<string, string> pColumnConditions)
        {
            StringBuilder SB = new StringBuilder();
            bool whereAdded = false;
            for (int ParamIndex = 0; ParamIndex < pColumnConditions.Count; ParamIndex++)
            {
                if (ParamIndex == 0)
                {
                    if (!String.IsNullOrEmpty(pColumnConditions.Values[ParamIndex]))
                    {
                        whereAdded = true;
                        SB.Append(" WHERE " + pColumnConditions.Keys[ParamIndex] + " = @p" + pColumnConditions.Keys[ParamIndex]);
                    }
                }
                else
                {
                    if (!String.IsNullOrEmpty(pColumnConditions.Values[ParamIndex]))
                    {
                        if(whereAdded)
                        {
                            SB.Append(" AND " + pColumnConditions.Keys[ParamIndex] + " = @p" + pColumnConditions.Keys[ParamIndex]);
                        }
                        else
                        {
                            whereAdded = true;
                            SB.Append(" WHERE " + pColumnConditions.Keys[ParamIndex] + " = @p" + pColumnConditions.Keys[ParamIndex]);
                        }
                    }
                }
            }
            return SB.ToString();
        }
        /// <summary>
        /// This method will return a date that SQL accepts from a dd/mm/yyyy format to a yyyy-mm-dd
        /// </summary>
        /// <param name="pDateTime"></param>
        /// <returns></returns>
        public static string FormatDateForSQLInsert(string pDateTime)
        {
            string day = pDateTime.Substring(0, 2);
            string month = pDateTime.Substring(3, 2);
            string year = pDateTime.Substring(6, 4);
            return year + "-" + month + "-" + day;
        }
    }
}
