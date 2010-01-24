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
                ViewItemSellPriceInfo viewItemSellPriceInfo = database.ViewItemSellPriceGetById(itemInfo.ItemId, agentsInfo.AgentKindId);

                if (viewItemSellPriceInfo != null)
                {
                    decimal totalMoney = decimal.Parse(this.textBoxTotalAmount.Text) + decimal.Parse(this.labelSellPrice.Text) * this.numericUpDownQuantity.Value;
                    this.dataGridViewListItems.Rows.Add(false,itemInfo.ItemId,
                                                        itemInfo.ItemName,
                                                        NumberViewer.InsertComma(this.numericUpDownQuantity.Value.ToString()),
                                                        itemInfo.Measurement,
                                                        this.labelSellPrice.Text,
                                                        NumberViewer.InsertComma(totalMoney.ToString())
                                                        );

                    this.textBoxTotalAmount.Text = NumberViewer.InsertComma(totalMoney.ToString());


                    OrderDetailsInfo orderDetailsInfo = new OrderDetailsInfo();
                    orderDetailsInfo.CreatedBy = this.employeeName;
                    orderDetailsInfo.CreateDate = DateTime.Now;
                    orderDetailsInfo.ItemId = itemInfo.ItemId;
                    orderDetailsInfo.Quantity = numericUpDownQuantity.Value;
                    orderDetailsInfo.Deleted = 0;
                    orderDetailsInfo.IdPrice = viewItemSellPriceInfo.SellId;
                    this.listOrderDetails.Add(orderDetailsInfo);
                }
                else MessageBox.Error(this, "Xem lại thông tin mặt hàng");
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            this.groupBoxInforAgent.Enabled = true;
            this.Init();
        }

        private void dataGridViewListItems_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            MessageBox.Infor(this, "remove row");
        }

        private void buttonRemoveChoicedItems_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewListItems.Rows.Count > 0)
            {
                for (int i = 0; i < this.dataGridViewListItems.Rows.Count; i++)
                {
                    DataGridViewRow row = this.dataGridViewListItems.Rows[i];
                    if (row.Cells[columnDelete.Index].Value.ToString() == "Checked")
                    {
                        foreach (OrderDetailsInfo orderDetailsInfo in this.listOrderDetails)
                        {
                            if (orderDetailsInfo.ItemId == int.Parse(row.Cells[columnItemId.Index].Value.ToString()))
                            {
                                this.listOrderDetails.Remove(orderDetailsInfo);
                            }
                        }
                    }
                }
            }
            else MessageBox.Error(this, "Bạn chưa xuất mặt hàng nào");
        }
    }
}
