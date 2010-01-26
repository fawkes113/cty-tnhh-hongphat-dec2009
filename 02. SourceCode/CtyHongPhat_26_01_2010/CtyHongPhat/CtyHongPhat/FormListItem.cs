using System;
using System.Collections.Generic;
using System.Collections;
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
    public partial class FormListItem : Form
    {
        private static string MEASUREMENT = "<Nhập đơn vị>";
        private List<ItemInfo> listItems;
        private List<AgentsInfo> listAgents;
        private List<AgentKindInfo> listAgentKinds;
        private Database database = new Database();

        private string employeeName = "admin";

        public FormListItem()
        {
            InitializeComponent();
        }

        public FormListItem(string employeeName) : this()
        {            
            this.employeeName = employeeName;
        }

        #region Phương thức hỗ trợ
        private void BindData()
        {
            this.comboBoxInfoKindOfAgent.DataSource = null;
            this.comboBoxInfoKindOfAgent.Items.Clear();
            if (this.listAgentKinds.Count > 0)
            {
                this.comboBoxInfoKindOfAgent.DataSource = this.listAgentKinds;
                this.comboBoxInfoKindOfAgent.DisplayMember = "AgentKindName";
            }

            this.comboBoxItemName.DataSource = null;
            this.comboBoxItemName.Items.Clear();
            if (this.listItems.Count > 0)
            {
                this.comboBoxItemName.DataSource = this.listItems;
                this.comboBoxItemName.DisplayMember = "ItemName";
            }

            this.comboBoxAgentName.DataSource = null;
            this.comboBoxAgentName.Items.Clear();
            if (this.listAgents.Count > 0)
            {
                this.comboBoxAgentName.DataSource = this.listAgents;
                this.comboBoxAgentName.DisplayMember = "AgentName";
            }

            this.comboBoxSearchKindOfAgent.DataSource = null;
            this.comboBoxSearchKindOfAgent.Items.Clear();
            if (this.listAgentKinds.Count > 0)
            {
                this.comboBoxSearchKindOfAgent.DataSource = this.listAgentKinds;
                this.comboBoxSearchKindOfAgent.DisplayMember = "AgentKindName";
            }
        }

        private void Init()
        {
            try
            {
                listItems = new List<ItemInfo>();
                listAgents = new List<AgentsInfo>();
                listAgentKinds = new List<AgentKindInfo>();

                this.labelQuantity.Text = "0";
                this.textBoxMeasurement.Text = MEASUREMENT;

                ArrayList listObject = null;

                ItemInfo overItemInfo = new ItemInfo();
                overItemInfo.ItemId = -1;
                overItemInfo.ItemName = "<Tất cả>";
                this.listItems.Add(overItemInfo);
                listObject = database.ItemGetAll();
                if (listObject != null && listObject.Count != 0)
                    foreach (ItemInfo item in listObject)
                        this.listItems.Add(item);

                AgentsInfo overAgentInfo = new AgentsInfo();
                overAgentInfo.AgentId = -1;
                overAgentInfo.AgentName = "<Tên đại lý>";
                this.listAgents.Add(overAgentInfo);
                listObject = database.AgentGetAll();
                if (listObject != null && listObject.Count != 0)
                    foreach (AgentsInfo agentInfo in listObject)
                        this.listAgents.Add(agentInfo);

                AgentKindInfo overAgentKindInfo = new AgentKindInfo();
                overAgentKindInfo.AgentKindId = -1;
                overAgentKindInfo.AgentKindName = "<Loại đại lý>";
                this.listAgentKinds.Add(overAgentKindInfo);
                listObject = database.AgentKindGetAll();
                if (listObject != null && listObject.Count != 0)
                    foreach (AgentKindInfo agentKindInfo in listObject)
                        this.listAgentKinds.Add(agentKindInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Error(this, ex.ToString());
            }
        }

        private void PerformSearch()
        {
            int itemId = comboBoxItemName.SelectedValue == null ? -1 : ((ItemInfo)comboBoxItemName.SelectedValue).ItemId;
            int agentId = comboBoxAgentName.SelectedValue == null ? -1 : ((AgentsInfo)comboBoxAgentName.SelectedValue).AgentId;
            int agentKindId = comboBoxSearchKindOfAgent.SelectedValue == null ? -1 : ((AgentKindInfo)comboBoxSearchKindOfAgent.SelectedValue).AgentKindId;

            // xử lý chặn trường hợp bấm tìm kiếm mà không nhập tiêu chí nào
            //if (itemId == -1 && agentId == -1 && agentKindId == -1)
            //{
            //    MessageBox.Infor(this, "Vui lòng nhập thông tin mặt hàng cần tìm kiếm.");
            //    return;
            //}

            // tìm kiếm
            List<ViewItemSellPriceInfo> result = database.ViewItemSellPriceSearchBy(itemId, agentId, agentKindId);

            // thông báo nếu không tìm thấy mặt hàng
            dataGridViewItemList.Rows.Clear();
            if (result.Count == 0)
            {
                MessageBox.Infor(this, "Không tìm thấy mặt hàng nào.");
                return;
            }

            // hiển thị các mặt hàng tìm thấy lên danh sách mặt hàng
            foreach (ViewItemSellPriceInfo info in result)
            {
                dataGridViewItemList.Rows.Add(
                    info.ItemId,
                    info.ItemName,
                    info.AgentKindName,
                    NumberViewer.InsertComma(info.SellPrice.ToString()),
                    info.TotalQuantity,
                    info.Measurement);
            }
        }
        #endregion

        private void FormListItem_Load(object sender, EventArgs e)
        {
            Init();
            BindData();
            this.textBoxItemName.Focus();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void comboBoxAgentName_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO: nếu chọn đại lý theo tên --> loại đại lý được thay đổi theo đại lý
        }

        private void comboBoxSearchKindOfAgent_SelectedIndexChanged(object sender, EventArgs e)
        {
            // nếu thay đổi loại đại lý sau khi đã chọn đại lý, đại lý sẽ trở về <tên đại lý>
            //if (comboBoxAgentName.SelectedIndex > 0)
            //    comboBoxAgentName.SelectedIndex = 0;
        }

        private void comboBoxItemName_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter: 
                    PerformSearch();
                    break;
                case Keys.Escape:
                    comboBoxItemName.SelectedIndex = 0;
                    break;
                default: break;
            }
        }

        private void comboBoxAgentName_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    PerformSearch();
                    break;
                case Keys.Escape:
                    comboBoxAgentName.SelectedIndex = 0;
                    break;
                default: break;
            }
        }

        private void comboBoxSearchKindOfAgent_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    PerformSearch();
                    break;
                case Keys.Escape:
                    comboBoxSearchKindOfAgent.SelectedIndex = 0;
                    break;
                default: break;
            }
        }

        private void textBoxMeasurement_Enter(object sender, EventArgs e)
        {
            if (this.textBoxMeasurement.Text == MEASUREMENT)
                this.textBoxMeasurement.Text = "";
        }

        private void textBoxMeasurement_Leave(object sender, EventArgs e)
        {
            if (this.textBoxMeasurement.Text == "")
                this.textBoxMeasurement.Text = MEASUREMENT;
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            
        }
    }
}
