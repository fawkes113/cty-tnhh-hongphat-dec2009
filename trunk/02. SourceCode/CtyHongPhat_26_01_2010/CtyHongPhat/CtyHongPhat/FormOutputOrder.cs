using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CtyHongPhat.Utility;
using CtyHongPhatDatabase.Table;
using CtyHongPhatDatabase.View;

namespace CtyHongPhat
{
    public partial class FormOutputOrder : Form
    {
        List<AgentsInfo> listAgents;
        List<ItemInfo> listItems;
        List<OrderDetailsInfo> listOrderDetails;
        private Database database = new Database();
        private string employeeName = "admin";

        public FormOutputOrder()
        {
            InitializeComponent();
        }

        public FormOutputOrder(string employeeName)
        {
            InitializeComponent();
            this.employeeName = employeeName;
        }
        private void BindData()
        {
            this.comboBoxListAgents.DataSource = null;
            this.comboBoxListAgents.Items.Clear();
            if (this.comboBoxListAgents.DataSource == null && this.listAgents.Count > 0)
            {
                this.comboBoxListAgents.DataSource = this.listAgents;
                this.comboBoxListAgents.DisplayMember = "AgentName";
            }

            this.comboBoxListItems.DataSource = null;
            this.comboBoxListItems.Items.Clear();
            if (this.comboBoxListItems.DataSource == null && this.listItems.Count > 0)
            {
                this.comboBoxListItems.DataSource = this.listItems;
                this.comboBoxListItems.DisplayMember = "ItemName";
            }
        }

        private void Init()
        {
            try
            {
                this.dataGridViewListItems.Rows.Clear();
                this.listAgents = new List<AgentsInfo>();
                this.listItems = new List<ItemInfo>();
                this.listOrderDetails = new List<OrderDetailsInfo>();

                this.labelTotalDebt.Text = "";
                this.labelSellPrice.Text = "";
                this.labelQuantity.Text = "";
                this.labelMeasurement.Text = "";
                this.labelKindOfAngent.Text = "";
                this.labelRemainItemMeasurement.Text = "";
                this.textBoxTotalAmount.Text = "0";
                this.numericUpDownQuantity.Value = 0;
                this.numericUpDownPayAmount.Value = 0;

                ArrayList listObject = null;

                AgentsInfo overAgentInfo = new AgentsInfo();
                overAgentInfo.AgentId = -1;
                overAgentInfo.AgentName = "<Tên đại lý>";
                this.listAgents.Add(overAgentInfo);
                listObject = database.AgentGetAll();
                if (listObject != null && listObject.Count != 0)
                    foreach (AgentsInfo agentInfo in listObject)
                        this.listAgents.Add(agentInfo);

                ItemInfo overItemInfo = new ItemInfo();
                overItemInfo.ItemId = -1;
                overItemInfo.ItemName = "<Tất cả>";
                this.listItems.Add(overItemInfo);
                listObject = database.ItemGetAll();
                if(listObject != null && listObject.Count != 0)
                    foreach(ItemInfo item in listObject)
                        this.listItems.Add(item);

                
            }
            catch(Exception ex)
            {
                MessageBox.Error(this, ex.ToString());
            }
        }

        private void FormOutputOrder_Load(object sender, EventArgs e)
        {
            Init();
            BindData();
        }

        private void comboBoxListAgents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxListAgents.SelectedItem != null && this.comboBoxListAgents.SelectedItem is AgentsInfo)
            {
                this.labelKindOfAngent.Text = "";
                this.labelTotalDebt.Text = "";
                try
                {
                    AgentsInfo agentsInfo = this.comboBoxListAgents.SelectedItem as AgentsInfo;
                    if (agentsInfo.AgentId > 0)
                    {
                        ViewAgentsInfo viewAgentInfo = database.ViewAgentInfoGetById(agentsInfo.AgentId);
                        if (viewAgentInfo != null)
                        {
                            this.labelKindOfAngent.Text = viewAgentInfo.AgentKindName;
                            this.labelTotalDebt.Text = NumberViewer.InsertComma(viewAgentInfo.CurrentDebtValue.ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Error(this, ex.ToString());
                }
            }
        }

        private void comboBoxListItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxListItems.SelectedItem != null && this.comboBoxListItems.SelectedItem is ItemInfo)
            {
                this.labelMeasurement.Text = "";
                this.labelRemainItemMeasurement.Text = "";
                this.labelSellPrice.Text = "";
                this.labelQuantity.Text = "";
                try
                {
                    ItemInfo itemInfo = this.comboBoxListItems.SelectedItem as ItemInfo;
                    if(itemInfo.ItemId > 0)
                    {
                        if (this.comboBoxListAgents.SelectedItem != null && this.comboBoxListAgents.SelectedItem is AgentsInfo)
                        {
                            AgentsInfo agentsInfo = this.comboBoxListAgents.SelectedItem as AgentsInfo;
                            if (agentsInfo.AgentId <= 0)
                            {
                                MessageBox.Error(this, "Phải chọn một khách hàng");
                                return;
                            }
                            ViewItemSellPriceInfo viewItemSellPriceInfo = database.ViewItemSellPriceGetById(itemInfo.ItemId, agentsInfo.AgentKindId);
                            if (viewItemSellPriceInfo != null)
                            {
                                this.labelMeasurement.Text = viewItemSellPriceInfo.Measurement;
                                this.labelRemainItemMeasurement.Text = viewItemSellPriceInfo.Measurement;
                                this.labelSellPrice.Text = NumberViewer.InsertComma(viewItemSellPriceInfo.SellPrice.ToString());
                                this.labelQuantity.Text = viewItemSellPriceInfo.TotalQuantity.ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Error(this, ex.ToString());
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.groupBoxInforAgent.Enabled = false;
            if (this.comboBoxListItems.SelectedItem != null && this.comboBoxListItems.SelectedItem is ItemInfo)
            {
                ItemInfo itemInfo = this.comboBoxListItems.SelectedItem as ItemInfo;
                if (numericUpDownQuantity.Value == 0)
                {
                    MessageBox.Error(this, "Bạn chưa nhập số lương bán");
                    return;
                }

                if (numericUpDownQuantity.Value > itemInfo.TotalQuantity)
                {
                    MessageBox.Error(this, "Số lương bán phải nhỏ hơn số lương tồn kho");
                    return;
                }

                AgentsInfo agentsInfo = this.comboBoxListAgents.SelectedItem as AgentsInfo;

                if (itemInfo.ItemId == -1)
                {
                    for (int i = 1; i < this.comboBoxListItems.Items.Count; i++)
                    {
                        itemInfo = this.comboBoxListItems.Items[i] as ItemInfo;
                        bool checkContain = false;
                        foreach(OrderDetailsInfo orderDetailsInfo in this.listOrderDetails)
                            if (orderDetailsInfo.ItemId == itemInfo.ItemId)
                            {
                                checkContain = true;
                                break;
                            }

                        if (checkContain == false)
                        {
                            ViewItemSellPriceInfo viewItemSellPriceInfo = database.ViewItemSellPriceGetById(itemInfo.ItemId, agentsInfo.AgentKindId);

                            if (viewItemSellPriceInfo != null)
                            {
                                decimal totalMoney = decimal.Parse(this.textBoxTotalAmount.Text) + decimal.Parse(this.labelSellPrice.Text) * this.numericUpDownQuantity.Value;
                                this.dataGridViewListItems.Rows.Add(false, itemInfo.ItemId,
                                                                    itemInfo.ItemName,
                                                                    NumberViewer.InsertComma(this.numericUpDownQuantity.Value.ToString()),
                                                                    itemInfo.Measurement,
                                                                    this.labelSellPrice.Text,
                                                                    NumberViewer.InsertComma(totalMoney.ToString())
                                                                    );

                                this.textBoxTotalAmount.Text = NumberViewer.InsertComma(totalMoney.ToString());
                                this.numericUpDownPayAmount.Maximum = totalMoney;

                                OrderDetailsInfo orderDetailsInfo = new OrderDetailsInfo();
                                orderDetailsInfo.CreatedBy = this.employeeName;
                                orderDetailsInfo.CreateDate = DateTime.Now;
                                orderDetailsInfo.ModifiedBy = "";
                                orderDetailsInfo.ModifiedDate = DateTime.Now;
                                orderDetailsInfo.ItemId = itemInfo.ItemId;
                                orderDetailsInfo.Quantity = numericUpDownQuantity.Value;
                                orderDetailsInfo.Deleted = 0;
                                orderDetailsInfo.IdPrice = viewItemSellPriceInfo.SellId;
                                this.listOrderDetails.Add(orderDetailsInfo);
                            }
                        }
                    }
                }
                else
                {
                    bool checkContain = false;
                    foreach (OrderDetailsInfo orderDetailsInfo in this.listOrderDetails)
                        if (orderDetailsInfo.ItemId == itemInfo.ItemId)
                        {
                            checkContain = true;
                            break;
                        }

                    if (checkContain == false)
                    {
                        ViewItemSellPriceInfo viewItemSellPriceInfo = database.ViewItemSellPriceGetById(itemInfo.ItemId, agentsInfo.AgentKindId);

                        if (viewItemSellPriceInfo != null)
                        {
                            decimal totalMoney = decimal.Parse(this.textBoxTotalAmount.Text) + decimal.Parse(this.labelSellPrice.Text) * this.numericUpDownQuantity.Value;
                            this.dataGridViewListItems.Rows.Add(false, itemInfo.ItemId,
                                                                itemInfo.ItemName,
                                                                NumberViewer.InsertComma(this.numericUpDownQuantity.Value.ToString()),
                                                                itemInfo.Measurement,
                                                                this.labelSellPrice.Text,
                                                                NumberViewer.InsertComma(totalMoney.ToString())
                                                                );

                            this.textBoxTotalAmount.Text = NumberViewer.InsertComma(totalMoney.ToString());
                            this.numericUpDownPayAmount.Maximum = totalMoney;

                            OrderDetailsInfo orderDetailsInfo = new OrderDetailsInfo();
                            orderDetailsInfo.CreatedBy = this.employeeName;
                            orderDetailsInfo.CreateDate = DateTime.Now;
                            orderDetailsInfo.ModifiedBy = "";
                            orderDetailsInfo.ModifiedDate = DateTime.Now;
                            orderDetailsInfo.ItemId = itemInfo.ItemId;
                            orderDetailsInfo.Quantity = numericUpDownQuantity.Value;
                            orderDetailsInfo.Deleted = 0;
                            orderDetailsInfo.IdPrice = viewItemSellPriceInfo.SellId;
                            this.listOrderDetails.Add(orderDetailsInfo);
                        }
                        else MessageBox.Error(this, "Xem lại thông tin mặt hàng");
                    }
                    else MessageBox.Error(this, "Đã chọn mặt hàng này rồi");
                }
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            this.groupBoxInforAgent.Enabled = true;
            this.Init();
        }

        private void dataGridViewListItems_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            //MessageBox.Infor(this, "remove row");
        }

        private void buttonRemoveChoicedItems_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewListItems.Rows.Count > 0)
            {
                int index = 0;
                while (index < this.dataGridViewListItems.Rows.Count)
                {
                    DataGridViewRow row = this.dataGridViewListItems.Rows[index];
                    if (row.Cells[columnDelete.Index].Value.ToString() == "Checked")
                    {
                        for (int i = 0; i < this.listOrderDetails.Count; i++)
                        {
                            OrderDetailsInfo orderDetailsInfo = this.listOrderDetails[i] as OrderDetailsInfo;
                            if (orderDetailsInfo.ItemId == int.Parse(row.Cells[columnItemId.Index].Value.ToString()))
                            {

                                this.listOrderDetails.RemoveAt(i);
                                this.dataGridViewListItems.Rows.Remove(row);
                                i = this.listOrderDetails.Count;
                                index--;
                            }
                        }
                    }
                    index++;
                }
            }
            else MessageBox.Error(this, "Bạn chưa xuất mặt hàng nào");
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (this.comboBoxListItems.SelectedItem != null && this.comboBoxListItems.SelectedItem is ItemInfo)
            {
                AgentsInfo agentsInfo = this.comboBoxListAgents.SelectedItem as AgentsInfo;

                if (agentsInfo.AgentId < 1)
                {
                    MessageBox.Error(this, "Chưa chọn khách hàng");
                    return;
                }

                if (this.listOrderDetails.Count <= 0)
                {
                    MessageBox.Error(this, "Chứa chọn mặt hàng");
                    return;
                }

                decimal totalAmount = decimal.Parse(this.textBoxTotalAmount.Text);
                decimal payAmount = this.numericUpDownPayAmount.Value;

                OrdersInfo ordersInfo = new OrdersInfo();
                ordersInfo.CreatedBy = this.employeeName;
                ordersInfo.CreatedDate = DateTime.Now;
                ordersInfo.CustomerId = agentsInfo.AgentId;
                ordersInfo.ModifiedBy = "";
                ordersInfo.ModifiedDate = DateTime.Now;
                ordersInfo.OrderKind = 1;
                ordersInfo.Pay = payAmount;
                ordersInfo.Total = totalAmount;

                if (payAmount >= totalAmount)
                    ordersInfo.Status = 2; // trả hết
                else if (payAmount < totalAmount && payAmount != 0)
                    ordersInfo.Status = 1; // trả một phần
                else if (payAmount == 0)
                    ordersInfo.Status = 0;// chưa thanh toán

                try
                {
                    int ordersId = database.OrdersAdd(ordersInfo);
                    if (ordersId > 0)
                    {
                        for (int i = 0; i < this.listOrderDetails.Count; i++)
                        {
                            OrderDetailsInfo orderDetailsInfo = this.listOrderDetails[i];
                            orderDetailsInfo.OrderId = ordersId;
                            database.OrderDetailsAdd(orderDetailsInfo);
                        }

                        DebtInfo oldDebtInfo = database.DebtGetByCustomerId(agentsInfo.AgentId);
                        DebtInfo newDebtInfo = new DebtInfo();
                      
                        newDebtInfo.NewDebtValue = totalAmount - payAmount;
                        newDebtInfo.OldDebtValue = oldDebtInfo.CurrentDebtValue;
                        newDebtInfo.CurrentDebtValue = oldDebtInfo.CurrentDebtValue + (totalAmount - payAmount);
                        newDebtInfo.Payment = 0;
                        newDebtInfo.CreateDate = DateTime.Now;
                        newDebtInfo.CreatedBy = this.employeeName;
                        newDebtInfo.ModifiedDate = DateTime.Now;
                        newDebtInfo.ModifiedBy = "";
                        newDebtInfo.DebtKind = 1;
                        newDebtInfo.Deleted = 0;
                        newDebtInfo.CustomerId = agentsInfo.AgentId;
                        newDebtInfo.Note = "Thêm nợ hóa đơn ngày " + oldDebtInfo.CreateDate.ToString("dd/MM/yyyy");

                        if (database.DebtAdd(newDebtInfo) > 0)
                        {
                            oldDebtInfo.Deleted = 1;
                            oldDebtInfo.ModifiedBy = this.employeeName;
                            oldDebtInfo.ModifiedDate = DateTime.Now;

                            database.DebtUpdate(oldDebtInfo);
                        }
                        else
                        {
                            MessageBox.Error(this, "Không thêm nợ được, có thể yêu cầu khách hàng thanh toán bằng tiền mặt");
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Error(this, ex.ToString());
                }

            }
        }
    }
}
