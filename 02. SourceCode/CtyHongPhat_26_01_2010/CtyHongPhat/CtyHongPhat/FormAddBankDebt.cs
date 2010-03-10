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
    public partial class FormAddBankDebt : Form
    {
        private string employeeName = "";
        private Database database = new Database();

        public FormAddBankDebt()
        {
            InitializeComponent();
        }

        public FormAddBankDebt(string employeeName)
        {
            this.employeeName = employeeName;
            InitializeComponent();
        }

        private void Init()
        {
            this.textBoxBankName.Text = "";
            this.numericUpDownDebtAmount.Value = 0;
            this.numericUpDownInterestRate.Value = 0;
            this.numericUpDownPaidAmount.Value = 0;
            this.dateTimePickerBorrowDate.Value = DateTime.Now;
            this.dateTimePickerMaturityDate.Value = DateTime.Now;
        }

        private void FormAddBankDebt_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (this.textBoxBankName.Text.Length <= 0)
            {
                MessageBox.Error(this, "Bạn chưa  nhập tên ngân hàng");
                return;
            }

            if (this.numericUpDownInterestRate.Value == 0)
            {
                MessageBox.Error(this, "Bạn chưa nhập lãi suất");
                return;
            }

            if (this.numericUpDownDebtAmount.Value <= 0)
            {
                MessageBox.Error(this, "Ban chưa nhập số tiền vay");
                return;
            }

            try
            {
                BankDebtInfo bankDebtInfo = new BankDebtInfo();
                bankDebtInfo.BankName = this.textBoxBankName.Text;
                bankDebtInfo.BorrowDate = dateTimePickerBorrowDate.Value;
                bankDebtInfo.CreatedBy = this.employeeName;
                bankDebtInfo.CreatedDate = DateTime.Now;
                bankDebtInfo.DebtAmount = numericUpDownDebtAmount.Value;
                bankDebtInfo.Deleted = 0;
                bankDebtInfo.InterestRate = numericUpDownInterestRate.Value;
                bankDebtInfo.MaturityDate = dateTimePickerMaturityDate.Value;
                bankDebtInfo.ModifiedBy = "";
                bankDebtInfo.ModifiedDate = DateTime.Now;
                bankDebtInfo.PaidAmount = numericUpDownPaidAmount.Value;

                int bankDebtId = database.BankDebtAdd(bankDebtInfo);
                if (bankDebtId > 0)
                {
                    MessageBox.Infor(this, "Thêm mới nợ ngân hàng thành công");
                    Init();
                }
                else
                {
                    MessageBox.Error(this, "Có lỗi trong quá trình thêm mới nợ ngân hàng");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Error(this, ex.ToString());
                return;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            this.Init();
        }
    }
}
