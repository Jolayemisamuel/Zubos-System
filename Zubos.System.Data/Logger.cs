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
        public static StreamWriter LogWriter
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

        }

        public static void WriteLine(string LoggerType, string LogMessage_param)
        {

        }

        public static void Write(string LoggerType, string[] LogMessages_param)
        {

        }
    }
}
