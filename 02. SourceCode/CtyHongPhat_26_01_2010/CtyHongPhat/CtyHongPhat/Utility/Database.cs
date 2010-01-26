using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using CtyHongPhatDatabase.Controller;
using CtyHongPhatDatabase.Table;
using CtyHongPhatDatabase.View;

namespace CtyHongPhat.Utility
{
    public class Database
    {
        public static SqlConnection NewConnection()
        {
            try
            {
                //string connStr = "Data Source=" + Config.DataSource + ";Initial Catalog=" + Config.InitialCatalog + ";User ID=" + Config.UserName + ";Password=" + Config.Password;
                string connStr = "Data Source=.\\sqlexpress;Initial Catalog=CtyHongPhat_19_01_2010;Integrated Security=True";
                return new SqlConnection(connStr);
            }
            catch (System.Exception e)
            {
                System.Diagnostics.Trace.WriteLine(e);
                return null;
            }
        }

        #region AgentKind
        public int AgentKindInsert(AgentKindInfo agentKindInfo)
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

        public bool AgentKindUpdate(AgentKindInfo agentKingInfo)
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

        public bool AgentKindDelete(int agentId)
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
        public ArrayList AgentGetAll()
        {
            try
            {
                using (SqlConnection conn = Database.NewConnection())
                {
                    return AgentsController.GetAll(conn);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex);
                return null;
            }
        }

        #endregion

        #region BuyPrice
        #endregion

        #region Debt
        public int DebtAdd(DebtInfo debtInfo)
        {
            try
            {
                using(SqlConnection conn = Database.NewConnection())
                {
                    return DebtController.Insert(conn, debtInfo);
                }
                
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex);
                return -1;
            }
        }

        public void DebtUpdate(DebtInfo debtInfo)
        {
            try
            {
                using (SqlConnection conn = Database.NewConnection())
                {
                     DebtController.Update(conn, debtInfo);
                }
            }
            catch (Exception ex)
            {
            }
        }
        public DebtInfo DebtGetById(int debtId)
        {
            try
            {
                using (SqlConnection conn = Database.NewConnection())
                {
                    return DebtController.GetByColumnTop1(conn, "DebtId", debtId);
                }
            }
            catch(Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex);
                return null;
            }
        }

        //lấy món nợ hiện tại
        public DebtInfo DebtGetByCustomerId(int customerId)
        {
            try
            {
                using (SqlConnection conn = Database.NewConnection())
                {
                    return DebtController.GetByColumnTop1(conn, "CustomerId", customerId);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex);
                return null;
            }
        }

        #endregion

        #region Items
        public ArrayList ItemGetAll()
        {
            try
            {
                using (SqlConnection conn = Database.NewConnection())
                {
                    return ItemCotroller.GetAll(conn);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex);
                return null;
            }
        }
        #endregion

        #region OrderDetails
        public int OrderDetailsAdd(OrderDetailsInfo orderDetailsInfo)
        {
            try
            {
                using (SqlConnection conn = Database.NewConnection())
                {
                    return OrderDetailsController.Insert(conn, orderDetailsInfo);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex);
                return -1;
            }
        }
        #endregion

        #region Orders
        public int OrdersAdd(OrdersInfo ordersInfo)
        {
            try {
                using (SqlConnection conn = Database.NewConnection())
                {
                    return OrdersController.Insert(conn, ordersInfo);
                }
            }
            catch(Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex);
                return -1;
            }
        }
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

        #region ViewAgentInfo
        public ViewAgentsInfo ViewAgentInfoGetById(int agentId)
        {
            try
            {
                using (SqlConnection conn = Database.NewConnection())
                {
                    return ViewAgentsController.GetByColumnTop1(conn, "AgentId", agentId);
                }
            }
            catch(Exception ex){
                System.Diagnostics.Trace.WriteLine(ex);
                return null;
            }
        }
        #endregion

        #region ViewSellPriceInfo
        public ViewItemSellPriceInfo ViewItemSellPriceGetById(int itemId, int agentKindId)
        {
            try
            {
                using (SqlConnection conn = Database.NewConnection())
                {
                    return ViewItemSellPriceController.GetByColumnsTop1(conn, new object[] {"ItemId", itemId, "AgentKindId", agentKindId});
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex);
                return null;
            }
        }
        #endregion
    }
}
