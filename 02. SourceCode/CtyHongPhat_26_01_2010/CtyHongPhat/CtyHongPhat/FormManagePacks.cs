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

namespace CtyHongPhat
{
    public partial class FormManagePacks : Form
    {
        private string employeeName = "";
        private Database database = new Database();

        public FormManagePacks()
        {
            InitializeComponent();
        }

        private void Init()
        {
            this.textBoxpackName.Text = "";
            this.numericUpDownQuantity.Value = 0;
            this.numericUpDownTotalAmount.Value = 0;
            this.dateTimePickerImportDate.Value = DateTime.Now;
            this.dateTimePickerToDate.Value = DateTime.Now;
            this.dateTimePickerFromDate.Value = DateTime.Now.AddDays(-30);

            this.dataGridViewListPacks.DataSource = null;
            this.dataGridViewListPacks.Rows.Clear();
        }
        public FormManagePacks(string employeeName)
        {
            InitializeComponent();
            this.employeeName = employeeName;
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (this.textBoxpackName.Text.Length == 0)
            {
                MessageBox.Error(this, "Bạn chưa nhập tên bao bì");
                return;
            }

            if (this.numericUpDownQuantity.Value == 0)
            {
                MessageBox.Error(this, "Bạn chưa nhập số lượng bao bì");
                return;
            }

            if(this.numericUpDownTotalAmount.Value == 0)
            {
                MessageBox.Error(this, "Bạn chưa nhập số tiền phải trả");
                return;
            }

            try
            {
                PackInfo packInfo = new PackInfo();
                packInfo.PackName = this.textBoxpackName.Text;
                packInfo.Quantity =  this.numericUpDownQuantity.Value;
                packInfo.TotalAmount = this.numericUpDownTotalAmount.Value;
                packInfo.ImportDate = this.dateTimePickerImportDate.Value;
                packInfo.CreatedBy = this.employeeName;
                packInfo.CreatedDate = DateTime.Now;
                packInfo.ModifiedBy = "";
                packInfo.ModifiedDate = DateTime.Now;

                int packId = database.PackAdd(packInfo);
                if (packId > 0)
                {
                    MessageBox.Infor(this, "Nhập bao bì thành công");
                    Init();
                }
                else MessageBox.Infor(this, "Có lỗi trong quá trình nhập bao bì");
            }
            catch (Exception ex)
            {
                MessageBox.Error(this, ex.ToString());
            }
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            this.dataGridViewListPacks.Rows.Clear();
            DateTime fromDate = this.dateTimePickerFromDate.Value;
            DateTime toDate = this.dateTimePickerToDate.Value;

            ArrayList listPacks = null;
            try
            {
                listPacks = database.PackSelectFormDateToDate(fromDate, toDate);
                if (listPacks != null && listPacks.Count > 0)
                {
                    for (int i = 0; i < listPacks.Count; i++)
                    {
                        PackInfo packInfo = (PackInfo)listPacks[i];
                        dataGridViewListPacks.Rows.Add(
                            packInfo.PackId, 
                            packInfo.PackName, 
                            packInfo.ImportDate.ToString("dd/MM/yyyy"),
                            NumberViewer.InsertComma(packInfo.Quantity.ToString()), 
                            NumberViewer.InsertComma(packInfo.TotalAmount.ToString())
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Error(this, ex.ToString());
                return;
            }
        }
        private void FormManagePacks_Load(object sender, EventArgs e)
        {
            Init();
        }
        private void dataGridViewListPacks_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewListPacks.SelectedRows != null && this.dataGridViewListPacks.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = this.dataGridViewListPacks.SelectedRows[0];

                try
                {
                    PackInfo packInfo = this.database.PackGetById(int.Parse(selectedRow.Cells[ColumnPackId.Index].Value.ToString()));
                    this.textBoxpackName.Text = packInfo.PackName;
                    this.numericUpDownQuantity.Value = packInfo.Quantity;
                    this.numericUpDownTotalAmount.Value = packInfo.TotalAmount;
                    this.dateTimePickerImportDate.Value = packInfo.ImportDate;
                }
                catch (Exception ex)
                {
                    MessageBox.Error(this, ex.ToString());
                }
            }
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewListPacks.SelectedRows != null && this.dataGridViewListPacks.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewListPacks.SelectedRows[0];
                try
                {
                    PackInfo packInfo = database.PackGetById(int.Parse(selectedRow.Cells[ColumnPackId.Index].Value.ToString()));

                    packInfo.PackName = this.textBoxpackName.Text;
                    packInfo.Quantity = this.numericUpDownQuantity.Value;
                    packInfo.TotalAmount = this.numericUpDownTotalAmount.Value;
                    packInfo.ImportDate = this.dateTimePickerImportDate.Value;
                    packInfo.ModifiedBy = this.employeeName;
                    packInfo.ModifiedDate = DateTime.Now;

                    if (database.PackUpdate(packInfo))
                    {
                        MessageBox.Infor(this, "Cập nhật thành công");
                        this.buttonSearch_Click(sender, e);
                    }
                    else MessageBox.Error(this, "Có lỗi trong quá trình cập nhật, bạn thử thực hiện lại lần nữa");
                }
                catch (Exception ex)
                {
                    MessageBox.Error(this, ex.ToString());
                }
            }
        }
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            this.Init();
        }
    }
}
