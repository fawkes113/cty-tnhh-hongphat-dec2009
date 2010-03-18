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
        public static int COMMAND_SUCCESS = 1;
        public static int COMMAND_FAILED = -1;

        public static SqlConnection NewConnection()
        {
            try
            {
                //string connStr = "Data Source=" + Config.DataSource + ";Initial Catalog=" + Config.InitialCatalog + ";User ID=" + Config.UserName + ";Password=" + Config.Password;                
                //string connStr = "Data Source=.\\sqlexpress;Initial Catalog=CtyHongPhat_19_01_2010;Integrated Security=True";
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
        public ArrayList AgentKindGetAll()
        {
            try
            {
                using (SqlConnection conn = Database.NewConnection())
                {
                    return AgentKindController.GetAll(conn);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex);
                return null;
            }
        }

        public AgentKindInfo AgentKindGetBy(int agentKindId)
        {
            try
            {
                using (SqlConnection conn = Database.NewConnection())
                {
                    return AgentKindController.GetByColumnTop1(conn, "AgentKindId", agentKindId);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex);
                return null;
            }
        }

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

        public int AgentKindAdd(AgentKindInfo agentKindInfo)
        {
            try
            {
                using (SqlConnection conn = Database.NewConnection())
                {
                    return AgentKindController.Insert(conn, agentKindInfo);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex);
                return -1;
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

        public AgentsInfo AgentById(int agentId)
        {
            try
            {
                using(SqlConnection conn = Database.NewConnection())
                {
                    return AgentsController.GetByColumnTop1(conn, "AgentId", agentId);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex.ToString());
                return null;
            }
        }

        public int AgentAdd(AgentsInfo agentInfo)
        {
            try
            {
                using (SqlConnection conn = Database.NewConnection())
                {
                    return AgentsController.Insert(conn, agentInfo);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex);
                return -1;
            }
        }

        public bool AgentUpdate(AgentsInfo agentInfo)
        {
            try
            {
                using (SqlConnection conn = Database.NewConnection())
                {
                    AgentsController.Update(conn, agentInfo);
                    return true;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex);
                return false;
            }
        }

        public bool AgentDelete(int agentId, string modifiedBy, DateTime modifiedDate)
        {
            try
            {
                using (SqlConnection conn = Database.NewConnection())
                {
                    AgentsController.Delete(conn, agentId, modifiedBy, modifiedDate);
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

        #region BuyPrice
        public ArrayList BuyPriceGetByPartner(int partnerId)
        {
            try {
                using (SqlConnection conn = Database.NewConnection()) {
                    return BuyPriceController.GetByColumn(conn, "PartnerId", partnerId);
                }
            } catch (Exception ex) {
                System.Diagnostics.Trace.WriteLine(ex);
                return null;
            }
        }
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
                System.Diagnostics.Trace.WriteLine(ex);
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

        public DebtInfo DebtGetByCustomer(int customerId, int debtKind)
        {
            try
            {
                using (SqlConnection conn = Database.NewConnection())
                {
                    return DebtController.GetByColumnsTop1(conn, "CustomerId", customerId, "DebtKind", debtKind);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex);
                return null;
            }
        }

        #endregion

		#region Employee
        public int EmployeeAdd(EmployeesInfo employeeInfo)
        {
            try
            {
                using (SqlConnection conn = Database.NewConnection())
                {
                    return EmployeesController.Insert(conn, employeeInfo);
                }

            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex);
                return -1;
            }
        }

        public void EmployeeUpdate(EmployeesInfo employeeInfo)
        {
            try
            {
                using (SqlConnection conn = Database.NewConnection())
                {
                    EmployeesController.Update(conn, employeeInfo);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex);
            }
        }

        public EmployeesInfo EmployeeGetById(int employeeId)
        {
            try
            {
                using (SqlConnection conn = Database.NewConnection())
                {
                    return EmployeesController.GetByColumnTop1(conn, "employeeId", employeeId);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex);
                return null;
            }
        }

        public ArrayList EmloyeeGetAll()
        {
            try
            {
                using (SqlConnection conn = Database.NewConnection())
                {
                    return EmployeesController.GetAll(conn);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex);
                return null;
            }
        }

        public bool EmployeeDelete(int employeeId)
        {
            try
            {
                using (SqlConnection conn = Database.NewConnection())
                {
                    EmployeesController.Delete(conn, employeeId);
                }
                return true;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex);
                return false;
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
                    return ItemController.GetAll(conn);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex);
                return null;
            }
        }
        
        public ArrayList ItemGetByPartner(int partnerId)
        {
            try {
                using (SqlConnection conn = Database.NewConnection()) {
                    return ItemController.GetByPartner(conn, partnerId);
                }
            } catch (Exception ex) {
                System.Diagnostics.Trace.WriteLine(ex);
                return null;
            }
        }

        public int ItemAdd(ItemInfo itemInfo)
        {
            try
            {
                using (SqlConnection conn = Database.NewConnection())
                {
                    return ItemController.Insert(conn, itemInfo);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex);
                return COMMAND_FAILED;
            }
        }

        public int ItemUpdate(ItemInfo itemInfo)
        {
            try
            {
                using (SqlConnection conn = Database.NewConnection())
                {
                    ItemController.Update(conn, itemInfo);
                    return COMMAND_SUCCESS;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex);
                return COMMAND_FAILED;
            }
        }
		
		public ItemInfo ItemGetById(int itemId)
        {
            try
            {
                using (SqlConnection conn = Database.NewConnection())
                {
                    return ItemController.GetByColumnTop1(conn, "ItemId", itemId);
                }
            }
            catch(Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex);
                return null;
            }
        }
		
        public ItemInfo ItemGetBy(int itemId)
        {
            try
            {
                using (SqlConnection conn = Database.NewConnection())
                {
                    return ItemController.GetByColumnTop1(conn, "ItemId", itemId);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex);
                return null;
            }
        }

        public void ItemDelete(int itemId)
        {
            try
            {
                using (SqlConnection conn = Database.NewConnection())
                {
                    ItemInfo info = ItemController.GetByColumnTop1(conn, "ItemId", itemId);
                    conn.Close();

                    ItemController.Delete(conn, info);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex);
                return;
            }
        }
        #endregion

        #region OrderBuyDetails
        public int OrderBuyDetailsAdd(OrderBuyDetailsInfo orderBuyDetailsInfo)
        {
            try
            {
                using (SqlConnection conn = Database.NewConnection())
                {
                    return OrderBuyDetailsController.Insert(conn, orderBuyDetailsInfo);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex);
                return -1;
            }
        }

        public ArrayList OrderBuyDetailsGetAllByOrderId(int orderId)
        {
            try
            {
                using (SqlConnection conn = Database.NewConnection())
                {
                    return OrderBuyDetailsController.GetByColumns(conn, "OrderId", orderId);
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

        public ArrayList OrderDetailsGetAllByOrderId(int orderId)
        {
            try
            {
                using (SqlConnection conn = Database.NewConnection())
                {
                    return OrderDetailsController.GetByColumns(conn, "OrderId", orderId);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex);
                return null;
            }
        }

                
        #endregion

        #region Orders
        public OrdersInfo OrdersGetById(int orderId)
        {
            try
            {
                using (SqlConnection conn = Database.NewConnection())
                {
                    return OrdersController.GetByColumnTop1(conn, "OrderId", orderId);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex);
                return null;
            }
        }

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
		
		public ArrayList OrdersGetByCustomerIdFromDateToDate(int customerId, int orderKind, int status, DateTime fromDate, DateTime toDate)
        {
            try
            {
                using (SqlConnection conn = Database.NewConnection())
                {
                    return OrdersController.GetByCustomerIdFromdateTodate(conn, customerId, orderKind, status, fromDate, toDate);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex);
                return null;
            }
        }

        public void OrdersUpdate(OrdersInfo ordersInfo)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    OrdersController.Update(conn, ordersInfo);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex.ToString());
            }
        }

        public ArrayList OrdersGetDebtOrderByCustomerId(int customerId)
        {
            try
            {
                using (SqlConnection conn = Database.NewConnection())
                {
                    return OrdersController.GetDebtOrdersByCustomerId(conn, customerId);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex);
                return null;
            }
        }
        #endregion

        #region Partners
        public ArrayList PartnersGetAll()
        {
            try
            {
                using (SqlConnection conn = Database.NewConnection())
                {
                    return PartnersController.GetAll(conn);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex);
                return null;
            }
        }
        public PartnersInfo PartnersGetById(int partnerId)
        {
            try {
                using (SqlConnection conn = Database.NewConnection())
                {
                    return PartnersController.GetByColumnTop1(conn, "PartnerId", partnerId);
                }
            }
            catch(Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex);
                return null;
            }
        }
        public int PartnerAdd(PartnersInfo partnersInfo)
        {
            try
            {
                using (SqlConnection conn = Database.NewConnection())
                {
                    return PartnersController.Insert(conn, partnersInfo);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex);
                return -1;
            }
        }
        public bool PartnerUpdate(PartnersInfo partnersInfo)
        {
            try
            {
                using (SqlConnection conn = Database.NewConnection())
                {
                    PartnersController.Update(conn, partnersInfo);
                    return true;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex);
                return false;
            }
        }

        public bool PartnerDelete(int partnerId)
        {
            try
            {
                using (SqlConnection conn = Database.NewConnection())
                {
                    PartnersController.Delete(conn, partnerId);
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

        #region ReturnedItemDetails
        #endregion

        #region SellPrice
        public int SellPriceAdd(SellPriceInfo sellPriceInfo)
        {
            try
            {
                using (SqlConnection conn = Database.NewConnection())
                {
                    return SellPriceController.Insert(conn, sellPriceInfo);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex);
                return COMMAND_FAILED;
            }
        }

        public int SellPriceUpdate(SellPriceInfo sellPriceInfo)
        {
            try
            {
                using (SqlConnection conn = Database.NewConnection())
                {
                    SellPriceController.Update(conn, sellPriceInfo);
                    return COMMAND_SUCCESS;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex);
                return COMMAND_FAILED;
            }
        }

        public SellPriceInfo SellPriceGetBy(int sellId)
        {
            try
            {
                using (SqlConnection conn = Database.NewConnection())
                {
                    return SellPriceController.GetByColumnTop1(conn, "SellId", sellId);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex);
                return null;
            }
        }

        public SellPriceInfo SellPriceGetBy(int itemId, int agentKindId)
        {
            try
            {
                using (SqlConnection conn = Database.NewConnection())
                {
                    return SellPriceController.GetByColumnsTop1(conn, "ItemId", itemId, "AgentKindId", agentKindId);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex);
                return null;
            }
        }
        
        public void SellPriceDeleteBy(int itemId)
        {
            try
            {
                using (SqlConnection conn = Database.NewConnection())
                {
                    // select by column
                    ArrayList infos = SellPriceController.GetByColumns(conn, "ItemId", itemId);
                    conn.Close();

                    // for each --> call sp delete
                    foreach (object info in infos)
                    {
                        SellPriceController.Delete(conn, ((SellPriceInfo)info));
                        conn.Close();
                    }
                    //SellPriceController.DeleteByColumns(conn, "ItemId", itemId);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex);
                return;
            }
        }
        #endregion

        #region ReturnedItemDetails
        #endregion

        #region SellPrice
        #endregion

        #region User
        public bool CheckUserPassword(string userName, string password)
        {
            try
            {
                using (SqlConnection conn = Database.NewConnection())
                {
                    return UserController.CheckUserPassword(conn, userName, password);
                }
            }
            catch(Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex);
                return false;
            }
        }

        public bool ChangePassword(string userName, string oldPassWord, string newPassWord)
        {
            try
            {
                using (SqlConnection conn = Database.NewConnection())
                {
                    return UserController.ChangePassword(conn, userName, oldPassWord, newPassWord);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex);
                return false;
            }
        }

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

        public List<ViewItemSellPriceInfo> ViewItemSellPriceSearchBy(int itemId, int agentId, int agentKindId)
        {
            try
            {
                using (SqlConnection conn = Database.NewConnection())
                {
                    ArrayList queryResult;
                    if ((itemId == -1 && agentId == -1 && agentKindId == -1) ||
                         (itemId == -1 && agentKindId == -1))
                        queryResult = ViewItemSellPriceController.GetAll(conn);
                    else
                        queryResult = ViewItemSellPriceController.GetByColumns(conn, new object[] { 
                            itemId == -1 ? null : "ItemId", itemId, 
                            //agentId == -1 ? null : "AgentId", agentId, // TODO : tìm cách search theo AgentId
                            agentKindId == -1 ? null : "AgentKindId", agentKindId });

                    List<ViewItemSellPriceInfo> result = new List<ViewItemSellPriceInfo>();
                    foreach (object item in queryResult)
	                {
                        result.Add((ViewItemSellPriceInfo) item);
	                }

                    return result;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex);
                return null;
            }
        }
        #endregion

        #region Packs
        public int PackAdd(PackInfo packInfo)
        {
            try
            {
                using (SqlConnection conn = Database.NewConnection())
                {
                    return PackController.Insert(conn, packInfo);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex);
                return -1;
            }
        }

        public bool PackDelete(int packId, string modifiedBy, DateTime modifiedDate)
        {
            try
            {
                using (SqlConnection conn = Database.NewConnection())
                {
                    PackController.Delete(conn, packId, modifiedBy, modifiedDate);
                    return true;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex);
                return false;
            }
        }

        public bool PackUpdate(PackInfo packInfo)
        {
            try
            {
                using (SqlConnection conn = Database.NewConnection())
                {
                    PackController.Update(conn, packInfo);
                    return true;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex);
                return false;
            }
        }

        public ArrayList PackSelectFormDateToDate(DateTime fromDate, DateTime toDate)
        {
            try
            {
                using (SqlConnection conn = Database.NewConnection())
                {
                    return PackController.GetFromDateToDate(conn, fromDate, toDate);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex);
                return null;
            }
        }

        public PackInfo PackGetById(int packId)
        {
            try
            {
                using (SqlConnection conn = Database.NewConnection())
                {
                    return PackController.GetByColumnTop1(conn, "PackId", packId);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex);
                return null;
            }
        }

        #endregion

        #region BankDebt
        public ArrayList BankDebtdGetAll()
        {
            try
            {
                using (SqlConnection conn = Database.NewConnection())
                {
                    return BankDebtController.GetAll(conn);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex);
                return null;
            }
        }
        public ArrayList BankDebtGetAllNotCondition()
        {
            try
            {
                using (SqlConnection conn = Database.NewConnection())
                {
                    return BankDebtController.GetAllNotCondition(conn);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex);
                return null;
            }
        }

        public BankDebtInfo BankDebtGetById(int bankDebtId)
        {
            try
            {
                using (SqlConnection conn = Database.NewConnection())
                {
                    return BankDebtController.GetByColumnTop1(conn, "BankDebtId", bankDebtId);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex);
                return null;
            }
        }

        public int BankDebtAdd(BankDebtInfo bankDebtInfo)
        {
            try
            {
                using (SqlConnection conn = Database.NewConnection())
                {
                    return BankDebtController.Insert(conn, bankDebtInfo);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex);
                return -1;
            }
        }

        public bool BankDebtUpdate(BankDebtInfo bankDebtInfo)
        {
            try
            {
                using (SqlConnection conn = Database.NewConnection())
                {
                    BankDebtController.Update(conn, bankDebtInfo);
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

        #region BankInterestRate
        public ArrayList BankInterestRateGetAllByBankDebtId(int bankDebtId)
        {
            try
            {
                using (SqlConnection conn = Database.NewConnection())
                {
                    return BankInterestRateController.GetByColumn(conn, "BankDebtId", bankDebtId);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex);
                return null;
            }
        }

        public int BankInterestRateAdd(BankInterestRateInfo bankInterestRate)
        {
            try
            {
                using (SqlConnection conn = Database.NewConnection())
                {
                    return BankInterestRateController.Insert(conn, bankInterestRate);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex);
                return -1;
            }
        }
        #endregion
    }
}
