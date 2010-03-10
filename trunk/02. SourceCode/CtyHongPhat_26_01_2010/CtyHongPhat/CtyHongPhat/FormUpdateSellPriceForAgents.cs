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
    public partial class FormUpdateSellPriceForAgents : Form
    {
        private string employeeName = "admin";
        private ItemInfo item = null;
        private List<AgentKindInfo> listAgentKinds;
        private Database database = new Database();

        public ItemInfo Item
        {
            set { item = value; }
        }

        public FormUpdateSellPriceForAgents(ItemInfo item)
        {
            InitializeComponent();
            this.item = item;
        }

        public FormUpdateSellPriceForAgents(ItemInfo item, string employeeName) : this(item)
        {
            this.employeeName = employeeName;
        }

        #region Phương thức hỗ trợ
        private void Init()
        {
            if (item == null)
                this.DialogResult = DialogResult.Cancel;

            try
            {
                // lấy các thông tin của mặt hàng
                this.labelItemName.Text = item.ItemName;
                this.labelItemId.Text = item.ItemId.ToString();
                this.labelQuantity.Text = item.TotalQuantity.ToString();
                this.labelMeasurement.Text = item.Measurement;

                // lấy danh sách các loại đại lý
                listAgentKinds = new List<AgentKindInfo>();
                ArrayList listObject = database.AgentKindGetAll();
                foreach (object obj in listObject)
                {
                    listAgentKinds.Add((AgentKindInfo)obj);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Error(this, ex.ToString());
            }
        }

        private void BindData()
        {
            dataGridViewItemList.Rows.Clear();

            foreach (AgentKindInfo agentKind in listAgentKinds)
            {
                // lấy giá của mặt hàng
                SellPriceInfo sellPrice = database.SellPriceGetBy(item.ItemId, agentKind.AgentKindId);

                // đưa loại đại lý vào gridview cùng giá và đơn vị item
                dataGridViewItemList.Rows.Add(
                    agentKind.AgentKindId,
                    agentKind.AgentKindName,
                    NumberViewer.InsertComma(sellPrice.SellPrice.ToString()),
                    item.Measurement);
            }
        }
        #endregion

        private void FormUpdateSellPriceForAgents_Load(object sender, EventArgs e)
        {
            this.Init();
            this.BindData();
        }

        private void dataGridViewItemList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // click vào header
            if (e.RowIndex < 0)
                return;

            // lấy thông tin của row
            DataGridViewRow row = dataGridViewItemList.Rows[e.RowIndex];
            string price = row.Cells["columnPrice"].Value.ToString();

            // show thông tin lên các control tương ứng
            numericUpDownPrice.Value = int.Parse(NumberViewer.ClearComma(price));
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            // lấy thông tin SellPriceInfo
            SellPriceInfo sellPriceInfo = new SellPriceInfo();            
            int agentKindId = int.Parse(dataGridViewItemList.SelectedRows[0].Cells["columnAgentKindId"].Value.ToString());
            sellPriceInfo = database.SellPriceGetBy(item.ItemId, agentKindId);
            sellPriceInfo.SellPrice = numericUpDownPrice.Value;

            // cập nhật thông tin vào csdl
            database.SellPriceUpdate(sellPriceInfo);

            // refresh lại gridview để báo người dùng biết đã cập nhật giá
            BindData();
        }
    }
}
