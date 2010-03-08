using System;
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
                }
                else MessageBox.Infor(this, "Có lỗi trong quá trình nhập bao bì");
            }
            catch (Exception ex)
            {
                MessageBox.Error(this, ex.ToString());
            }
        }
    }
}
