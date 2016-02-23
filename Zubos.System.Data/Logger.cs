using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;

namespace Zubos.System.Data
{
    public static class Logger
    {
        private static string LogDirectory = Application.StartupPath + "\\_Logs\\";
        private static string CurrentLogPath;

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

            if (CurrentLogPath == null)
            {
                string TempString = DateTime.Now.Day.ToString().PadLeft(2, padValue) + "-" +
                                     DateTime.Now.Month.ToString().PadLeft(2, padValue) + "-" +
                                     DateTime.Now.Year.ToString().PadLeft(4, padValue);

                CurrentLogPath = LogDirectory + "zubos_log_" + TempString + ".log";
            }
        }
        /// <summary>
        /// Method to close any open loggers.
        /// </summary>
        public static void FinaliseLogger()
        {

        }
        /// <summary>
        /// Writes a line to log file. Types: DEBUG/WARNING/ERROR/EVENT(Default)
        /// </summary>
        /// <param name="LoggerType_param"></param>
        /// <param name="LogMessage_param"></param>
        public static void WriteLine(string LoggerType_param, string LogMessage_param)
        {
            if (String.IsNullOrEmpty(LoggerType_param))
            {
                LoggerType_param = "EVENT";
            }
            if (CurrentLogPath != null)
            {
                File.AppendAllText(CurrentLogPath, LoggerType_param.ToUpper().PadLeft(7) + @"/" + GetTimeStampAsString() + GetCallingMethodName(2) + LogMessage_param + Environment.NewLine);
            }
        }
        /// <summary>
        /// Writes several lines to log file. Types: DEBUG/WARNING/ERROR/EVENT(Default)
        /// </summary>
        /// <param name="LoggerType_param"></param>
        /// <param name="LogMessages_param"></param>
        public static void WriteLines(string LoggerType_param, string[] LogMessages_param)
        {
            if (String.IsNullOrEmpty(LoggerType_param))
            {
                LoggerType_param = "EVENT";
            }
            if (CurrentLogPath == null)
            {
                return;
            }
            int loopCounter = 0;
            foreach (string logString in LogMessages_param)
            {
                File.AppendAllText(CurrentLogPath, LoggerType_param.ToUpper().PadLeft(7) + @"/" + GetTimeStampAsString() + GetCallingMethodName(2) + LogMessages_param[loopCounter] + Environment.NewLine);
                loopCounter++;
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
        /// Returns the calling method name as string for log output
        /// </summary>
        /// <returns></returns>
        private static string GetCallingMethodName(int FrameIndex_param)
        {
            StackTrace st = new StackTrace();
            StackFrame sf = st.GetFrame(FrameIndex_param);

            return " | " + sf.GetMethod().Name.PadRight(5) + " | ";
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
