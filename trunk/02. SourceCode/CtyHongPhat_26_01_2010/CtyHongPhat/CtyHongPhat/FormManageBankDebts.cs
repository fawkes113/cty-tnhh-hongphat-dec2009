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
    public partial class FormManageBankDebts : Form
    {
        private string employeeName = "";
        private Database database = new Database();

        public FormManageBankDebts()
        {
            InitializeComponent();
        }

        public FormManageBankDebts(string employeeName)
        {
            InitializeComponent();
            this.employeeName = employeeName;
        }

        private void FormManageBankDebts_Load(object sender, EventArgs e)
        {
            BindListBankDebt();
        }

        private void BindListBankDebt()
        {
            this.dataGridViewListBankDebts.DataSource = null;
            this.dataGridViewListBankDebts.Rows.Clear();

            try
            {
                ArrayList listBanksDebt = database.BankDebtdGetAll();
                if (listBanksDebt != null && listBanksDebt.Count > 0)
                {
                    for (int i = 0; i < listBanksDebt.Count; i++)
                    {
                        BankDebtInfo bankDebtInfo = (BankDebtInfo)listBanksDebt[i];
                        this.dataGridViewListBankDebts.Rows.Add(false,
                            bankDebtInfo.BankDebtId, 
                            bankDebtInfo.BankName,
                            bankDebtInfo.BorrowDate.ToString("dd/MM/yyyy"),
                            bankDebtInfo.MaturityDate.ToString("dd/MM/yyyy"),
                            bankDebtInfo.InterestRate,
                            NumberViewer.InsertComma(bankDebtInfo.DebtAmount.ToString()),
                            NumberViewer.InsertComma(bankDebtInfo.PaidAmount.ToString()),
                            ""
                            );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Error(this, ex.ToString());
            }
        }

        private void BindListBankDebtNotCondition()
        {
            this.dataGridViewListBankDebts.DataSource = null;
            this.dataGridViewListBankDebts.Rows.Clear();

            try
            {
                ArrayList listBanksDebt = database.BankDebtGetAllNotCondition();
                if (listBanksDebt != null && listBanksDebt.Count > 0)
                {
                    string Note = "";
                    for (int i = 0; i < listBanksDebt.Count; i++)
                    {
                        BankDebtInfo bankDebtInfo = (BankDebtInfo)listBanksDebt[i];
                        if (bankDebtInfo.Deleted == 1) Note = "Đã trả rồi";
                        else Note = "";

                        this.dataGridViewListBankDebts.Rows.Add(false,
                            bankDebtInfo.BankDebtId,
                            bankDebtInfo.BankName,
                            bankDebtInfo.BorrowDate.ToString("dd/MM/yyyy"),
                            bankDebtInfo.MaturityDate.ToString("dd/MM/yyyy"),
                            bankDebtInfo.InterestRate,
                            NumberViewer.InsertComma(bankDebtInfo.DebtAmount.ToString()),
                            NumberViewer.InsertComma(bankDebtInfo.PaidAmount.ToString()),
                            Note
                            );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Error(this, ex.ToString());
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddBankDebt formAddBankDebt = new FormAddBankDebt(this.employeeName);
            formAddBankDebt.ShowDialog(this);
            BindListBankDebt();
        }

        private void dataGridViewListBankDebts_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewListBankDebts.SelectedRows != null && this.dataGridViewListBankDebts.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = this.dataGridViewListBankDebts.SelectedRows[0];

                try
                {
                    int bankDebtId = int.Parse(selectedRow.Cells[ColumnBankDebtId.Index].Value.ToString());
                    BankDebtInfo bankDebtInfo = database.BankDebtGetById(bankDebtId);

                    if (bankDebtInfo.Deleted == 1) this.groupBoxInfoBankDebt.Enabled = false;
                    else this.groupBoxInfoBankDebt.Enabled = true;

                    decimal rateAmount = Math.Round(((bankDebtInfo.DebtAmount - bankDebtInfo.PaidAmount) * (bankDebtInfo.InterestRate / 100)),2);
                    this.textBoxBankName.Text = bankDebtInfo.BankName;
                    this.textBoxBorrowDate.Text = bankDebtInfo.BorrowDate.ToString("dd/MM/yyyy");
                    this.textBoxDebtAmount.Text = NumberViewer.InsertComma(bankDebtInfo.DebtAmount.ToString());
                    this.textBoxMaturityDate.Text = bankDebtInfo.MaturityDate.ToString("dd/MM/yyyy");
                    this.textBoxPaidAmount.Text = NumberViewer.InsertComma(bankDebtInfo.PaidAmount.ToString());
                    this.numericUpDownRateAmount.Value = rateAmount;
                    this.labelBankDebtId.Text = bankDebtId.ToString();

                    ArrayList listBankInterestRate = database.BankInterestRateGetAllByBankDebtId(bankDebtId);
                    this.dataGridViewListInterestRate.DataSource = null;
                    this.dataGridViewListInterestRate.Rows.Clear();
                    if (listBankInterestRate != null && listBankInterestRate.Count > 0)
                    {
                        for (int i = 0; i < listBankInterestRate.Count; i++)
                        {
                            BankInterestRateInfo bankInterestRateInfo = (BankInterestRateInfo)listBankInterestRate[i];
                            this.dataGridViewListInterestRate.Rows.Add(
                                bankInterestRateInfo.BankInterestRateId,
                                bankInterestRateInfo.PayDate.ToString("dd/MM/yyyy"),
                                NumberViewer.InsertComma(bankInterestRateInfo.RateAmount.ToString()),
                                NumberViewer.InsertComma(bankInterestRateInfo.PayAmount.ToString()),
                                ""
                                );
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Error(this, ex.ToString());
                }
            }
        }

        private void buttonPayDebt_Click(object sender, EventArgs e)
        {
            if ((decimal.Parse(textBoxDebtAmount.Text) - decimal.Parse(textBoxPaidAmount.Text)) < this.numericUpDownPayAmount.Value)
            {
                MessageBox.Error(this, "Số tiền trả lớn hơn số tiền nợ");
                return;
            }
                try
                {
                    int bankDebtId = int.Parse(labelBankDebtId.Text);
                    BankDebtInfo bankDebtInfo = database.BankDebtGetById(bankDebtId);

                    decimal rateAmount = Math.Round(((bankDebtInfo.DebtAmount - bankDebtInfo.PaidAmount) * (bankDebtInfo.InterestRate / 100)), 2);
                    BankInterestRateInfo bankInterestRateInfo = new BankInterestRateInfo();
                    bankInterestRateInfo.BankDebtId = bankDebtInfo.BankDebtId;
                    bankInterestRateInfo.CreatedBy = this.employeeName;
                    bankInterestRateInfo.CreatedDate = DateTime.Now;
                    bankInterestRateInfo.Deleted = 0;
                    bankInterestRateInfo.ModifiedBy = "";
                    bankInterestRateInfo.ModifiedDate = DateTime.Now;
                    bankInterestRateInfo.PayAmount = this.numericUpDownPayAmount.Value;
                    bankInterestRateInfo.PayDate = DateTime.Now;
                    bankInterestRateInfo.RateAmount = rateAmount;

                    if (database.BankInterestRateAdd(bankInterestRateInfo) <= 0)
                    {
                        MessageBox.Error(this, "Có lỗi trong quá trình trả lại, bạn xem lại dữ liệu");
                        return;
                    }
                    else
                    {
                        bankDebtInfo.PaidAmount += this.numericUpDownPayAmount.Value;
                        bankDebtInfo.ModifiedBy = this.employeeName;
                        bankDebtInfo.ModifiedDate = DateTime.Now;
                    if (bankDebtInfo.DebtAmount == bankDebtInfo.PaidAmount) bankDebtInfo.Deleted = 1;
                        database.BankDebtUpdate(bankDebtInfo);

                        ArrayList listBankInterestRate = database.BankInterestRateGetAllByBankDebtId(bankDebtId);
                        if (listBankInterestRate != null && listBankInterestRate.Count > 0)
                        {
                            for (int i = 0; i < listBankInterestRate.Count; i++)
                            {
                                BankInterestRateInfo bankInterestRateInfoRow = (BankInterestRateInfo)listBankInterestRate[i];
                                this.dataGridViewListInterestRate.Rows.Add(
                                    bankInterestRateInfoRow.BankInterestRateId,
                                    bankInterestRateInfoRow.PayDate.ToString("dd/MM/yyyy"),
                                    NumberViewer.InsertComma(bankInterestRateInfoRow.RateAmount.ToString()),
                                    NumberViewer.InsertComma(bankInterestRateInfoRow.PayAmount.ToString()),
                                    ""
                                    );
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Error(this, ex.ToString());
                }
            }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
                this.BindListBankDebtNotCondition();
            else this.BindListBankDebt();
        }
    }
}
