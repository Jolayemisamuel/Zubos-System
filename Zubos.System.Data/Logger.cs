using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Diagnostics;
using System.Reflection;

namespace Zubos.System.Data
{
    public static class Logger
    {
        private static string LogDirectory = Application.StartupPath + "\\_Logs\\";
        private static string CurrentLogPath;
        private static bool isDebugMode;

        /// <summary>
        /// Initialises log directory and log file with date.
        /// </summary>
        /// <returns></returns>
        public static void InitialiseLogger()
        {
            char padValue = '0';

            if (!Directory.Exists(LogDirectory))
            {
                Directory.CreateDirectory(LogDirectory);
            }
            isDebugMode = (ConfigurationHelper.ReadSettingAsString("isDebugMode").ToLower() == "true");

            if (CurrentLogPath == null)
            {
                string TempString = DateTime.Now.Day.ToString().PadLeft(2, padValue) + "-" +
                                     DateTime.Now.Month.ToString().PadLeft(2, padValue) + "-" +
                                     DateTime.Now.Year.ToString().PadLeft(4, padValue);

                CurrentLogPath = LogDirectory + "zubos_log_" + TempString + ".log";
            }
        }
        /// <summary>
        /// Method to Finalise loggers.
        /// </summary>
        public static void FinaliseLogger()
        {

        }
        /// <summary>
        /// Writes a line to log file. Types: DEBUG/WARNING/ERROR/EVENT(Default)
        /// </summary>
        /// <param name="LoggerType"></param>
        /// <param name="LogMessage"></param>
        public static void WriteLine(string LoggerType, string LogMessage)
        {
            if(!isDebugMode && LoggerType.ToUpper() == "DEBUG")
            {
                return;
            }
            else if(String.IsNullOrEmpty(LoggerType))
            {
                LoggerType = "EVENT";
            }
            if (CurrentLogPath != null)
            {
                File.AppendAllText(CurrentLogPath, LoggerType.ToUpper().PadLeft(7) + @"/" + GetTimeStampAsString() + GetCallingMethodName(2) + LogMessage + Environment.NewLine);
            }
        }
        /// <summary>
        /// Writes several lines to log file. Types: DEBUG/WARNING/ERROR/EVENT(Default)
        /// </summary>
        /// <param name="LoggerType"></param>
        /// <param name="LogMessages"></param>
        public static void WriteLine(string LoggerType, string[] LogMessages)
        {
            if (!isDebugMode && LoggerType.ToUpper() == "DEBUG")
            {
                return;
            }
            else if (String.IsNullOrEmpty(LoggerType))
            {
                LoggerType = "EVENT";
            }
            if (CurrentLogPath != null)
            {
                int loopCounter = 0;
                foreach (string logString in LogMessages)
                {
                    File.AppendAllText(CurrentLogPath, LoggerType.ToUpper().PadLeft(7) + @"/" + GetTimeStampAsString() + GetCallingMethodName(2) + LogMessages[loopCounter] + Environment.NewLine);
                    loopCounter++;
                }
            }
        }
        /// <summary>
        /// Returns a string timestamp in format dd/mm/yy | hh:mm:ss
        /// </summary>
        /// <returns></returns>
        private static string GetTimeStampAsString()
        {
            char padValue = '0';
            string TimeStamp = DateTime.Now.Day.ToString().PadLeft(2, padValue) + "-"
                             + DateTime.Now.Month.ToString().PadLeft(2, padValue) + "-"
                             + DateTime.Now.Year.ToString().PadLeft(4, padValue) + " | "
                             + DateTime.Now.Hour.ToString().PadLeft(2, padValue) + ":"
                             + DateTime.Now.Minute.ToString().PadLeft(2, padValue) + ":"
                             + DateTime.Now.Second.ToString().PadLeft(2, padValue);
            return TimeStamp;
        }
        /// <summary>
        /// Returns the calling method name as string for log output.
        /// </summary>
        /// <returns></returns>
        private static string GetCallingMethodName(int FrameIndex)
        {
            StackTrace st = new StackTrace();
            StackFrame sf = st.GetFrame(FrameIndex);

            return " | " + sf.GetMethod().Name.PadRight(24) + " | ";
        }
        /// <summary>
        /// Returns active log file path
        /// </summary>
        /// <returns></returns>
        public static string GetCurrentLogPath()
        {
            return CurrentLogPath;
        }
    }
}
