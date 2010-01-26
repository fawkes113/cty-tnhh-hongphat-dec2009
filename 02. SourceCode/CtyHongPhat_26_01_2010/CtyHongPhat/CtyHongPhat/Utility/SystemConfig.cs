using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;

namespace CtyHongPhat.Utility
{
    class SystemConfig
    {
        /// <summary>
        /// Lay gia tri cua cau hinh, lay name tu SYSTEM_CONFIG
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string GetValue(string name)
        {
            if (!File.Exists(Config.GetConfigFile())) return "";
            string result = "";
            DataSet ds = new DataSet("SystemConfig");
            ds.ReadXml(Config.GetConfigFile());
            string sname = CryptorEngine.Encrypt(name.ToUpper(), true);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                if (ds.Tables[0].Rows[i][0].ToString().Trim() == sname.Trim())
                {
                    result = ds.Tables[0].Rows[i][1].ToString().Trim();
                    result = CryptorEngine.Decrypt(result, true);
                    break;
                }
            ds.Dispose();
            return result;
        }

        /// <summary>
        /// Thiet lap gia tri cho cau hinh, lay name tu SYSTEM_CONFIG
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static void SetValue(string name, string value)
        {
            if (!File.Exists(Config.GetConfigFile()))
            {
                DataSet ds1 = new DataSet("SystemConfig");
                DataTable dt = new DataTable("ConfigInformation");
                dt.Columns.Add("Name", typeof(string));
                dt.Columns.Add("Value", typeof(string));
                ds1.Tables.Add(dt);
                ds1.WriteXml(Config.GetConfigFile(), XmlWriteMode.WriteSchema);
                ds1.Dispose();
            }

            DataSet ds = new DataSet("SystemConfig");
            ds.ReadXml(Config.GetConfigFile());

            string sname = CryptorEngine.Encrypt(name.ToUpper(), true);
            string svalue = CryptorEngine.Encrypt(value, true);

            int row = RecordExits(name);
            if (row == -1)
                ds.Tables[0].Rows.Add(sname, svalue);
            else
                ds.Tables[0].Rows[row][1] = svalue;

            ds.WriteXml(Config.GetConfigFile(), XmlWriteMode.WriteSchema);
            ds.Dispose();
        }

        /// <summary>
        /// Kiem tra xem thong tin config ton tai hay chua, neu ton tai thi tra ve row, neu khong thi tra ve -1
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static int RecordExits(string name)
        {
            int result = -1;
            DataSet ds = new DataSet("SystemConfig");
            string sname = CryptorEngine.Encrypt(name.ToUpper(), true);
            ds.ReadXml(Config.GetConfigFile());
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                if (ds.Tables[0].Rows[i][0].ToString().Trim() == sname.Trim())
                {
                    result = i;
                    break;
                }
            ds.Dispose();
            return result;
        }
    }
}
