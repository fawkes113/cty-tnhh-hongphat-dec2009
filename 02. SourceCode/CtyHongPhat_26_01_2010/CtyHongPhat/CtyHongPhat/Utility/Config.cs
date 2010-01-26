using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CtyHongPhat.Utility
{
    class Config
    {
        public const string CONFIG_FILE_NAME = "Config.xml";
        public const string SECURITY_KEY = "CtyHongPhat";

        public static string DataSource = "";
        public static string InitialCatalog = "";
        public static string UserName = "";
        public static string Password = "";

        public static string GetConfigFile()
        {
            return Application.StartupPath + "\\" + Config.CONFIG_FILE_NAME;
        }
    }
}
