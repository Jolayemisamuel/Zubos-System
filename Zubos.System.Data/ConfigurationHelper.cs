using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace Zubos.System.Data
{
    public static class ConfigurationHelper
    {
        /// <summary>
        /// Custom class to hold information about individual AppSettings
        /// </summary>
        public class ConfigKeyValue
        {
            string Key;
            string Value;
            bool isSaved { get { return ConfigurationManager.AppSettings[Key] == Value; } }

            public ConfigKeyValue(string configKey, string configValue)
            {
                Key = configKey;
                Value = configValue;
            }
        }
        /// <summary>
        /// Will read a setting by Key from AppSettings and return an object containing Key and Value.
        /// </summary>
        /// <param name="Key"></param>
        /// <returns></returns>
        public static ConfigKeyValue ReadSetting(string Key)
        {
            try
            {
                string readValue = ConfigurationManager.AppSettings[Key];
                if (!String.IsNullOrEmpty(readValue))
                {
                    return new ConfigKeyValue(Key, readValue);
                }
            }
            catch(Exception ex)
            {
                string[] errorMsgs = new string[] { "Cannot read value from configuration file.", ex.Message };
                Logger.WriteLine("ERROR", errorMsgs);
            }
            return null;
        }
        /// <summary>
        /// Writes to AppSettings by Key and Value, will overwrite existing value.
        /// </summary>
        public static void WriteSetting(string Key, string Value)
        {
            try
            {

            }
            catch (Exception ex)
            {
                string[] errorMsgs = new string[] { "Cannot write value to configuration file.", ex.Message };
                Logger.WriteLine("ERROR", errorMsgs);
            }
        }
        /// <summary>
        /// Writes to AppSettings by ConfigKeyValue object, will overwrite existing value.
        /// </summary>
        /// <param name="configObject"></param>
        public static void WriteSetting(ConfigKeyValue configObject)
        {
            try
            {

            }
            catch (Exception ex)
            {
                string[] errorMsgs = new string[] { "Cannot write value to configuration file.", ex.Message };
                Logger.WriteLine("ERROR", errorMsgs);
            }
        }
    }
}
