using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Zubos.System.Data
{
    public static class Logger
    {
        private static string LogDirectory = Application.StartupPath + "\\_Logs\\";

        private static StreamWriter _LogWriter;
        private static StreamWriter LogWriter
        {
            get
            {
                if (_LogWriter == null)
                {
                    _LogWriter = InitialiseLogger();
                    return _LogWriter;
                }
                else
                {
                    return _LogWriter;
                }
            }
        }

        private static StreamWriter InitialiseLogger()
        {
            if (!Directory.Exists(LogDirectory))
            {
                Directory.CreateDirectory(LogDirectory);
            }

            string nowTimeString = DateTime.Now.Day + "-" + 
                                    DateTime.Now.Month + "-" + 
                                    DateTime.Now.Year + "_" + 
                                    DateTime.Now.Hour + "." +
                                    DateTime.Now.Minute + "." +
                                    DateTime.Now.Second;

            Console.WriteLine(LogDirectory + "zubos_log-" + nowTimeString + ".log");
            StreamWriter LogStreamWriter = new StreamWriter(LogDirectory + "zubos_log-" + nowTimeString + ".log");

            return LogStreamWriter;
        }
        /// <summary>
        /// Method to close any open loggers.
        /// </summary>
        public static void FinaliseLogger()
        {
            _LogWriter.Close();
            _LogWriter.Dispose();
            LogWriter.Close();
            LogWriter.Dispose();
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
            switch (LoggerType_param.ToUpper())
            {
                case "DEBUG":
                    LogWriter.WriteLine(LoggerType_param.ToUpper() + @"// " + LogMessage_param);
                    break;
                case "ERROR":
                    LogWriter.WriteLine(LoggerType_param.ToUpper() + @"// " + LogMessage_param);
                    break;
                case "EVENT":
                    LogWriter.WriteLine(LoggerType_param.ToUpper() + @"// " + LogMessage_param);
                    break;
                case "WARNING":
                    LogWriter.WriteLine(LoggerType_param.ToUpper() + @"// " + LogMessage_param);
                    break;
                default:
                    LogWriter.WriteLine("EVENT" + @"// " + LogMessage_param);
                    break;
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

            int loopCounter = 0;
            foreach (string logString in LogMessages_param)
            {
                switch (LoggerType_param.ToUpper())
                {
                    case "DEBUG":
                        LogWriter.WriteLine(LoggerType_param.ToUpper() + @"// " + LogMessages_param[loopCounter]);
                        break;
                    case "ERROR":
                        LogWriter.WriteLine(LoggerType_param.ToUpper() + @"// " + LogMessages_param[loopCounter]);
                        break;
                    case "EVENT":
                        LogWriter.WriteLine(LoggerType_param.ToUpper() + @"// " + LogMessages_param[loopCounter]);
                        break;
                    case "WARNING":
                        LogWriter.WriteLine(LoggerType_param.ToUpper() + @"// " + LogMessages_param[loopCounter]);
                        break;
                    default:
                        LogWriter.WriteLine("EVENT" + @"// " + LogMessages_param[loopCounter]);
                        break;
                }
                loopCounter++;
            }
        }
    }
}
