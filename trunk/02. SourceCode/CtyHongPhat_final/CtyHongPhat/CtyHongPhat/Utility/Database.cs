using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using CtyHongPhatDatabase.Controller;
using CtyHongPhatDatabase.Table;

namespace CtyHongPhat.Utility
{
    public class Database
    {
        public static SqlConnection NewConnection()
        {
            try
            {
                string connStr = "Data Source=" + Config.DataSource + ";Initial Catalog=" + Config.InitialCatalog + ";User ID=" + Config.UserName + ";Password=" + Config.Password;
                return new SqlConnection(connStr);
            }
            catch (System.Exception e)
            {
                System.Diagnostics.Trace.WriteLine(e);
                return null;
            }
        }

        #region AgentKind
        public static int AgentKindInsert(AgentKindInfo agentKindInfo)
        {
            try
            {
                using (SqlConnection conn = Database.NewConnection())
                {
                    return AgentKindController.Insert(conn, agentKindInfo);
                }
            }
            catch(Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex);
                return -1;
            }
        }

        public static bool AgentKindUpdate(AgentKindInfo agentKingInfo)
        {
            try
            {
                using (SqlConnection conn = Database.NewConnection())
                {
                    AgentKindController.Update(conn, agentKingInfo);
                    return true;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex);
                return false;
            }   
        }

        public static bool AgentKindDelete(int agentId)
        {
            try
            {
                using (SqlConnection conn = Database.NewConnection())
                {
                    AgentKindController.Delete(conn, agentId);
                    return true;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex);
                return false;
            } 
        }

        #endregion

        #region Agents
        #endregion

        #region BuyPrice
        #endregion

        #region Debt
        #endregion

        #region Items
        #endregion

        #region OrderDetails
        #endregion

        #region Orders
        #endregion

        #region Partners
        #endregion

        #region ReturnedItemDetails
        #endregion

        #region SellPrice
        #endregion

        #region User
        #endregion

        #region Common
        #endregion
    }
}
