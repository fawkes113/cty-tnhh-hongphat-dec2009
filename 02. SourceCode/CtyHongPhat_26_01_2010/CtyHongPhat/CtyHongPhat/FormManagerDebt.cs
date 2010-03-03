using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CtyHongPhat.Utility;
using CtyHongPhatDatabase.Table;

namespace CtyHongPhat
{
    public partial class FormManagerDebt : Form
    {
        private string employeeName;
        private Database database = new Database();
        private List<ListItem> listOrderStatus = new List<ListItem>(4);
        private List<AgentsInfo> listAgents;
        private List<PartnersInfo> listPartners;
        ArrayList listOrders = null;

        public FormManagerDebt()
        {
            InitializeComponent();
        }
        public FormManagerDebt(string employeeName)
        {
            InitializeComponent();
            this.employeeName = employeeName;
            this.radioButtonSellOrder.Checked = true;
        }

        private void Init()
        {
            this.dateTimePickerFromDate.Value = DateTime.Now.AddDays(-30);
            this.dateTimePickerToDate.Value = DateTime.Now;

            this.listAgents = new List<AgentsInfo>();
            this.listPartners = new List<PartnersInfo>();
            this.listOrders = new ArrayList();

            this.listOrderStatus.Add(new ListItem("<Tất cả>", -1));
            this.listOrderStatus.Add(new ListItem("Chưa thanh toán", 0));
            this.listOrderStatus.Add(new ListItem("Thanh toán một phần", 1));
            this.listOrderStatus.Add(new ListItem("Thanh toán hết", 2));

            ArrayList listObject = null;

            AgentsInfo overAgentInfo = new AgentsInfo();
            overAgentInfo.AgentId = -1;
            overAgentInfo.AgentName = "<Tất cả>";
            this.listAgents.Add(overAgentInfo);
            listObject = database.AgentGetAll();
            if (listObject != null && listObject.Count != 0)
                foreach (AgentsInfo agentInfo in listObject)
                    this.listAgents.Add(agentInfo);

            PartnersInfo overPartnerInfo = new PartnersInfo();
            overPartnerInfo.PartnerId = -1;
            overPartnerInfo.PartnerName = "<Tất cả>";
            this.listPartners.Add(overPartnerInfo);
            listObject = database.PartnersGetAll();
            if (listObject != null && listObject.Count != 0)
                foreach (PartnersInfo partnersInfo in listObject)
                    this.listPartners.Add(partnersInfo);
        }
        private void BindData()
        {
            this.comboBoxOrderStatus.DataSource = null;
            this.comboBoxOrderStatus.Items.Clear();
            this.comboBoxOrderStatus.DataSource = this.listOrderStatus;
            this.comboBoxOrderStatus.DisplayMember = "Text";

            //this.comboBoxOrderStatus.SelectedIndex = -1;

            if (this.radioButtonSellOrder.Checked)
                this.BindListAgents();
            else if (this.radioButtonBuyOrder.Checked)
                this.BindListPartners();
                
        }
        private void BindListAgents()
        {
            this.comboBoxListCustomer.DataSource = null;
            this.comboBoxListCustomer.Items.Clear();
            this.comboBoxListCustomer.DataSource = this.listAgents;
            this.comboBoxListCustomer.DisplayMember = "AgentName";

            //this.comboBoxListCustomer.SelectedIndex = -1;
        }
        private void BindListPartners()
        {
            this.comboBoxListCustomer.DataSource = null;
            this.comboBoxListCustomer.Items.Clear();
            this.comboBoxListCustomer.DataSource = this.listPartners;
            this.comboBoxListCustomer.DisplayMember = "PartnerName";

            //this.comboBoxListCustomer.SelectedIndex = -1;
        }
        private string GetStringStatus(int status)
        {
            foreach (ListItem item in this.listOrderStatus)
                if (int.Parse(item.Value.ToString()) == status)
                    return item.Text;
            return "";
        }

        private void FormListOrders_Load(object sender, EventArgs e)
        {
            this.Init();
            this.BindData();
        }
        private void radioButtonBuyOrder_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonSellOrder.Checked)
                this.BindListAgents();
        }
        private void radioButtonSellOrder_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonBuyOrder.Checked)
            {
                if (this.radioButtonBuyOrder.Checked)
                    this.BindListPartners();
            }
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            this.dataGridViewListOrders.Rows.Clear();

            ListItem orderStatus = this.comboBoxOrderStatus.SelectedItem as ListItem;
            DateTime fromDate = this.dateTimePickerFromDate.Value;
            DateTime toDate = this.dateTimePickerToDate.Value;

            int orderKind = -1;
            if (this.radioButtonBuyOrder.Checked) orderKind = 2;
            else if (this.radioButtonSellOrder.Checked) orderKind = 1;

            listOrders.Clear();
            if (this.comboBoxListCustomer.SelectedItem != null)
            {
                if (orderKind == 1)
                {
                    AgentsInfo agentInfo = this.comboBoxListCustomer.SelectedItem as AgentsInfo;
                    listOrders = database.OrdersGetByCustomerIdFromDateToDate(agentInfo.AgentId, orderKind, int.Parse(orderStatus.Value.ToString()), fromDate, toDate);
                }
                else
                {
                    PartnersInfo parnerInfo = this.comboBoxListCustomer.SelectedItem as PartnersInfo;
                    listOrders = database.OrdersGetByCustomerIdFromDateToDate(parnerInfo.PartnerId, orderKind, int.Parse(orderStatus.Value.ToString()), fromDate, toDate);
                }

                if (listOrders != null && listOrders.Count > 0)
                {
                    foreach (OrdersInfo orderInfo in listOrders)
                    {
                        string strStatus = GetStringStatus(orderInfo.Status);
                        this.dataGridViewListOrders.Rows.Add(orderInfo.OrderId,
                                                            orderInfo.CreatedDate.ToString("dd/MM/yyyy"),
                                                            NumberViewer.InsertComma(orderInfo.Total.ToString()),
                                                            NumberViewer.InsertComma(orderInfo.Pay.ToString()),
                                                            NumberViewer.InsertComma((orderInfo.Total - orderInfo.Pay).ToString()),
                                                            strStatus
                            );
                    }
                }
            }
        }
        private void buttonPayDebt_Click(object sender, EventArgs e)
        {
            if (this.numericUpDownPayAmount.Value <= 0)
            {
                MessageBox.Error(this, "Chưa nhập tiền trả nợ");
                return;
            }

            if(this.numericUpDownPayAmount.Value > decimal.Parse(this.labelDebtAmount.Text))
            {
                MessageBox.Error(this, "Số tiền trả nợ lớn hơn số tiền nợ hóa đơn");
                return;
            }

            if (this.dataGridViewListOrders.SelectedRows != null && this.dataGridViewListOrders.SelectedRows.Count > 0)
            {
                try{
                    DataGridViewRow row = this.dataGridViewListOrders.SelectedRows[0];

                    int orderId = int.Parse(row.Cells[columnId.Index].Value.ToString());
                    OrdersInfo orderInfo = database.OrdersGetById(orderId);

                    if (orderInfo != null)
                    {
                        DebtInfo oldDebtInfo = database.DebtGetByCustomerId(orderInfo.CustomerId);
                        oldDebtInfo.ModifiedBy = this.employeeName;
                        oldDebtInfo.ModifiedDate = DateTime.Now;
                        oldDebtInfo.Deleted = 1;
                        database.DebtUpdate(oldDebtInfo);

                        DebtInfo newDebtInfo = new DebtInfo();
                        newDebtInfo.CreateDate = DateTime.Now;
                        newDebtInfo.CreatedBy = this.employeeName;
                        newDebtInfo.CurrentDebtValue = oldDebtInfo.CurrentDebtValue - numericUpDownPayAmount.Value;
                        newDebtInfo.NewDebtValue = 0;
                        newDebtInfo.CustomerId = oldDebtInfo.CustomerId;
                        newDebtInfo.DebtKind = oldDebtInfo.DebtKind;
                        newDebtInfo.Deleted = 0;
                        newDebtInfo.ModifiedBy = "";
                        newDebtInfo.ModifiedDate = DateTime.MinValue;
                        newDebtInfo.Note = "Trả nợ hóa đơn ngày " + oldDebtInfo.CreateDate.ToString("dd/MM/yyyy");
                        newDebtInfo.OldDebtValue = oldDebtInfo.CurrentDebtValue;
                        newDebtInfo.Payment = this.numericUpDownPayAmount.Value;

                        database.DebtAdd(newDebtInfo);

                        decimal remainDebtAmount = orderInfo.Total - orderInfo.Pay - this.numericUpDownPayAmount.Value;
                        if (remainDebtAmount == 0)
                        {
                            orderInfo.Status = 2;
                        }
                        else orderInfo.Status = 1;

                        orderInfo.Pay = orderInfo.Pay + numericUpDownPayAmount.Value;
                        database.OrdersUpdate(orderInfo);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Error(this, ex.ToString());
                    return;
                }
            }
        }
        private void dataGridViewListOrders_SelectionChanged(object sender, EventArgs e)
        {
            if(this.dataGridViewListOrders.SelectedRows != null && this.dataGridViewListOrders.SelectedRows.Count > 0)
            {
                DataGridViewRow row = this.dataGridViewListOrders.SelectedRows[0];

                int orderId = int.Parse(row.Cells[columnId.Index].Value.ToString());
                OrdersInfo orderInfo = database.OrdersGetById(orderId);

                if (orderInfo != null)
                {
                    object customner = null;
                    if (orderInfo.OrderKind == 1)
                    {
                        customner = database.AgentById(orderInfo.CustomerId);
                        this.labelCustomerName.Text = (customner as AgentsInfo).AgentName;
                    }
                    else if (orderInfo.OrderKind == 2)
                    {
                        customner = database.PartnersGetById(orderInfo.CustomerId);
                        this.labelCustomerName.Text = (customner as PartnersInfo).PartnerName;
                    }
                    labelDebtAmount.Text = NumberViewer.InsertComma((orderInfo.Total - orderInfo.Pay).ToString());
                }
            }
        }
        private void buttonPayAllDebt_Click(object sender, EventArgs e)
        {
            if (MessageBox.Quest(this, "Bạn có chắc chọn đúng khách hàng muốn trả nợ trong khung Thông tin tìm kiếm ko ?", 2) == DialogResult.Yes)
            {
                if (this.comboBoxListCustomer.SelectedItem != null)
                {
                    object customer = this.comboBoxListCustomer.SelectedItem;
                    int customerId = -1;
                    if (radioButtonSellOrder.Checked)
                    {
                        customerId = (customer as AgentsInfo).AgentId;
                    }
                    else if (radioButtonBuyOrder.Checked)
                    {
                        customerId = (customer as PartnersInfo).PartnerId;
                    }

                    if (customerId != -1)
                    {
                        DebtInfo oldDebtInfo = database.DebtGetByCustomerId(customerId);
                        oldDebtInfo.ModifiedBy = this.employeeName;
                        oldDebtInfo.ModifiedDate = DateTime.Now;
                        oldDebtInfo.Deleted = 1;
                        database.DebtUpdate(oldDebtInfo);

                        DebtInfo newDebtInfo = new DebtInfo();
                        newDebtInfo.CreateDate = DateTime.Now;
                        newDebtInfo.CreatedBy = this.employeeName;
                        newDebtInfo.CurrentDebtValue = 0;
                        newDebtInfo.NewDebtValue = 0;
                        newDebtInfo.CustomerId = oldDebtInfo.CustomerId;
                        newDebtInfo.DebtKind = oldDebtInfo.DebtKind;
                        newDebtInfo.Deleted = 0;
                        newDebtInfo.ModifiedBy = "";
                        newDebtInfo.ModifiedDate = DateTime.MinValue;
                        newDebtInfo.Note = "Trả tất cả nợ hóa đơn, ngày trả :" + oldDebtInfo.CreateDate.ToString("dd/MM/yyyy");
                        newDebtInfo.OldDebtValue = oldDebtInfo.CurrentDebtValue;
                        newDebtInfo.Payment = oldDebtInfo.CurrentDebtValue;

                        database.DebtAdd(newDebtInfo);

                        ArrayList listDebtOrders = database.OrdersGetDebtOrderByCustomerId(customerId);
                        foreach (OrdersInfo ordersInfo in listDebtOrders)
                        {
                            ordersInfo.Status = 2;
                            ordersInfo.ModifiedBy = this.employeeName;
                            ordersInfo.ModifiedDate = DateTime.Now;
                            ordersInfo.Pay = ordersInfo.Total;

                            database.OrdersUpdate(ordersInfo);
                        }
                    }
                    else
                    {
                        MessageBox.Error(this, "Chưa chọn khách hàng trả nợ");
                        return;
                    }
                }
                else {
                    MessageBox.Error(this, "Chưa chọn khách hàng trả nợ");
                }
            }
        }
    }
}
