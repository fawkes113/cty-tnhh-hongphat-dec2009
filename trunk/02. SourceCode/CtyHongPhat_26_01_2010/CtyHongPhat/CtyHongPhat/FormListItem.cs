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
                    info.AgentKindId,
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
            // lấy thông tin 1 Item
            ItemInfo item = new ItemInfo();
            item.ItemId = -1;
            item.ItemName = textBoxItemName.Text;
            item.CreatedBy = employeeName;
            item.CreatedDate = DateTime.Today.Date;
            item.ModifiedBy = employeeName;
            item.ModifiedDate = DateTime.Today.Date;
            item.Deleted = 0;
            item.TotalQuantity = 0;
            item.Measurement = textBoxMeasurement.Text;

            // kiểm tra ràng buộc cần thiết
            if (item.ItemName == "" || item.Measurement == MEASUREMENT)
            {
                MessageBox.Infor(this, "Vui lòng nhập đầy đủ thông tin mặt hàng.");
                return;
            }

            // insert vào csdl
            item.ItemId = this.database.ItemAdd(item);
            if (item.ItemId == Database.COMMAND_FAILED)
            {
                MessageBox.Error(this, "Có lỗi khi tạo mặt hàng mới, vui lòng thử lại.");
                return;
            }

            // lấy thông tin sellPrice
            SellPriceInfo sellPrice = new SellPriceInfo();
            sellPrice.SellId = -1;
            sellPrice.ItemId = item.ItemId;
            sellPrice.AgentKindId = -1;
            sellPrice.SellPrice = numericUpDownPrice.Value;
            sellPrice.CreatedDate = DateTime.Today.Date;
            sellPrice.CreatedBy = employeeName;
            sellPrice.ModifiedDate = DateTime.Today.Date;
            sellPrice.ModifiedBy = employeeName;
            sellPrice.Deleted = 0;

            // kiểm tra ràng buộc cần thiết --> không cần

            // insert vào csdl
            foreach (AgentKindInfo agentKind in listAgentKinds)
            {
                sellPrice.AgentKindId = agentKind.AgentKindId;
                if (database.SellPriceAdd(sellPrice) == Database.COMMAND_FAILED)
                {
                    MessageBox.Error(this, String.Format("Có lỗi khi tạo giá bán cho loại đại lý {0}.", agentKind.AgentKindName));
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            // lấy thông tin 1 Item
            ItemInfo item = new ItemInfo();
            int itemId = -1;
            int.TryParse(labelItemId.Text, out itemId);
            if (itemId == -1)
            {
                return;
            }
            item = database.ItemGetBy(itemId);
            item.ItemName = textBoxItemName.Text;
            item.ModifiedBy = employeeName;
            item.ModifiedDate = DateTime.Today.Date;
            item.Measurement = textBoxMeasurement.Text;

            // kiểm tra ràng buộc cần thiết
            if (item.ItemName == "" || item.Measurement == MEASUREMENT)
            {
                MessageBox.Infor(this, "Vui lòng nhập đầy đủ thông tin mặt hàng.");
                return;
            }

            // update item trong csdl
            if (this.database.ItemUpdate(item) == Database.COMMAND_FAILED)
            {
                MessageBox.Error(this, "Có lỗi khi cập nhật thông tin mặt hàng, vui lòng thử lại.");
                return;
            }

            // lấy thông tin 1 sellPrice
            SellPriceInfo sellPrice = database.SellPriceGetBy(
                item.ItemId,
                ((AgentKindInfo)comboBoxInfoKindOfAgent.SelectedValue).AgentKindId);
            sellPrice.SellPrice = numericUpDownPrice.Value;
            sellPrice.ModifiedBy = employeeName;
            sellPrice.ModifiedDate = DateTime.Today.Date;

            // kiểm tra ràng buộc cần thiết --> không cần

            // update sellPrice trong csdl
            if (database.SellPriceUpdate(sellPrice) == Database.COMMAND_FAILED)
            {
                MessageBox.Error(this, String.Format("Có lỗi khi cập nhật thông tin giá bán cho đại lý {0}.", 
                    ((AgentKindInfo)comboBoxInfoKindOfAgent.SelectedValue).AgentKindName));
                return;
            }
        }

        private void dataGridViewItemList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // click vào header
            if (e.RowIndex < 0)
                return;

            // lấy thông tin của row
            DataGridViewRow row = dataGridViewItemList.Rows[e.RowIndex];

            string itemId = row.Cells["columnId"].Value.ToString();
            string itemName = row.Cells["columnItemName"].Value.ToString();
            string measurement = row.Cells["columnMeasurement"].Value.ToString();
            string totalQuantity = row.Cells["columnQuantity"].Value.ToString();
            string agentKindId = row.Cells["columnAgentKindId"].Value.ToString();
            string price = row.Cells["columnPrice"].Value.ToString();

            // show thông tin lên các control tương ứng
            labelItemId.Text = itemId;
            textBoxItemName.Text = itemName;
            textBoxMeasurement.Text = measurement;
            labelQuantity.Text = totalQuantity;
            comboBoxInfoKindOfAgent.SelectedIndex = searchAgentKindInList(listAgentKinds, int.Parse(agentKindId));
            numericUpDownPrice.Value = int.Parse(NumberViewer.ClearComma(price));
        }

        private int searchAgentKindInList(List<AgentKindInfo> list, int agentKindId)
        {
            for (int i = 0; i < list.Count; i++)
			{
                if (list[i].AgentKindId == agentKindId)
                    return i;
			}

            return 0;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            /// trường hợp không chọn dòng nào
            if (dataGridViewItemList.SelectedRows.Count <= 0)
                return;

            MessageBox.Infor(this, "Bạn thật sự muốn xóa những thông tin này?");
            foreach (DataGridViewRow row in dataGridViewItemList.SelectedRows)
            {
                string itemId = row.Cells["columnId"].Value.ToString();
                string itemName = row.Cells["columnItemName"].Value.ToString();
                string agentKindName = row.Cells["columnKindOfAgent"].Value.ToString();

                // xóa thông tin giá bán
                database.ItemDelete(int.Parse(itemId));

                // xóa thông tin item
                database.SellPriceDeleteBy(int.Parse(itemId));
            }
        }
    }
}
