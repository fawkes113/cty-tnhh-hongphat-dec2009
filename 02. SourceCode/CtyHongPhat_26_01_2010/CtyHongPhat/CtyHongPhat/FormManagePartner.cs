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
    public partial class FormManagePartner : Form
    {
        private Database database = new Database();
        private string employeeName = "";
        public FormManagePartner()
        {
            InitializeComponent();
        }
        public FormManagePartner(string employeeName)
        {
            InitializeComponent();
            this.employeeName = employeeName;
            
        }

        private void Init()
        {
            this.BindData();

            this.textBoxAddress.Text = "";
            this.textBoxName.Text = "";
            this.textBoxPhone.Text = "";
            this.numericUpDownDebtAmount.Enabled = true;
            this.numericUpDownDebtAmount.Value = 0;
            this.buttonInsert.Enabled = true;
        }
        private void BindData()
        {
            this.dataGridViewListPartners.DataSource = null;
            this.dataGridViewListPartners.Rows.Clear();
            try
            {
                ArrayList listPartners = database.PartnersGetAll();
                if (listPartners != null && listPartners.Count > 0)
                {
                    for (int i = 0; i < listPartners.Count; i++)
                    {
                        PartnersInfo partnerInfo = (PartnersInfo)listPartners[i];
                        DebtInfo debtInfo = database.DebtGetByCustomerId(partnerInfo.PartnerId);
                        this.dataGridViewListPartners.Rows.Add(
                            false,
                            partnerInfo.PartnerId,
                            partnerInfo.PartnerName,
                            NumberViewer.InsertComma(debtInfo.CurrentDebtValue.ToString()),
                            partnerInfo.PhoneNumber,
                            partnerInfo.Address
                            );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Error(this, ex.ToString());
            }
        }

        private void FormManagePartner_Load(object sender, EventArgs e)
        {
            this.Init();
            this.textBoxName.Focus();
        }
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            try
            {
                PartnersInfo partnersInfo = new PartnersInfo();
                partnersInfo.PartnerName = this.textBoxName.Text;
                partnersInfo.PhoneNumber = this.textBoxPhone.Text;
                partnersInfo.Address = this.textBoxAddress.Text;
                partnersInfo.Deleted = 0;

                int partnerId = database.PartnerAdd(partnersInfo);

                if (partnerId < 0)
                {
                    MessageBox.Error(this, "Có lỗi trong quá trình thêm nhà cung cấp");
                    return;
                }
                else
                {
                    DebtInfo debtInfo = new DebtInfo();
                    debtInfo.CreateDate = DateTime.Now;
                    debtInfo.CreatedBy = this.employeeName;
                    debtInfo.CurrentDebtValue = numericUpDownDebtAmount.Value;
                    debtInfo.CustomerId = partnerId;
                    debtInfo.DebtKind = 2;
                    debtInfo.Deleted = 0;
                    debtInfo.ModifiedBy = "";
                    debtInfo.ModifiedDate = DateTime.Now;
                    debtInfo.NewDebtValue = 0;
                    debtInfo.Note = "";
                    debtInfo.OldDebtValue = 0;
                    debtInfo.Payment = 0;

                    database.DebtAdd(debtInfo);
                }
                this.Init();
            }
            catch (Exception ex)
            {
                MessageBox.Error(this, ex.ToString());
            }
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewListPartners.SelectedRows != null && this.dataGridViewListPartners.SelectedRows.Count > 0)
            {
                DataGridViewRow row = this.dataGridViewListPartners.SelectedRows[0];

                try
                {
                    int partnerId = int.Parse(row.Cells[ColumnPartnerId.Index].Value.ToString());
                    PartnersInfo partnersInfo = database.PartnersGetById(partnerId);

                    partnersInfo.PhoneNumber = this.textBoxPhone.Text;
                    partnersInfo.PartnerName = this.textBoxName.Text.Trim();
                    partnersInfo.Address = this.textBoxAddress.Text.Trim();

                    if (database.PartnerUpdate(partnersInfo))
                    {
                        MessageBox.Infor(this, "Cập nhật thành công");
                        this.Init();
                    }
                    else MessageBox.Error(this, "Có lỗi trong quá trình cập nhật");
                }
                catch (Exception ex)
                {
                    MessageBox.Error(this, ex.ToString());
                }
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.dataGridViewListPartners.Rows.Count; i++)
            {
                if ((bool)this.dataGridViewListPartners.Rows[i].Cells[ColumnCheck.Index].Value == true)
                {
                    DataGridViewRow row = this.dataGridViewListPartners.Rows[i];
                    int partnerId = int.Parse(row.Cells[ColumnPartnerId.Index].Value.ToString());

                    try
                    {
                        DebtInfo debtInfo = database.DebtGetByCustomer(partnerId, 2);
                        if (debtInfo.CurrentDebtValue > 0)
                        {
                            string message = "Vẫn còn nợ nhà cung cấp " + row.Cells[ColumnPartnerName.Index].Value.ToString();
                            MessageBox.Error(this, message);
                        }
                        else 
                        database.PartnerDelete(partnerId);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Error(this, ex.ToString());
                    }
                }
            }
            this.Init();
        }
        private void dataGridViewListPartners_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewListPartners.SelectedRows != null && this.dataGridViewListPartners.SelectedRows.Count > 0)
            {
                DataGridViewRow row = this.dataGridViewListPartners.SelectedRows[0];
                int partnerId = int.Parse(row.Cells[ColumnPartnerId.Index].Value.ToString());

                PartnersInfo partnerInfo = database.PartnersGetById(partnerId);
                DebtInfo debtInfo = database.DebtGetByCustomer(partnerId, 2);
                this.textBoxAddress.Text = partnerInfo.Address;
                this.textBoxName.Text = partnerInfo.PartnerName;
                this.textBoxPhone.Text = partnerInfo.PhoneNumber;
                this.numericUpDownDebtAmount.Value = debtInfo.CurrentDebtValue;
                this.numericUpDownDebtAmount.Enabled = false;

                this.buttonInsert.Enabled = false;
            }
        }
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            this.Init();
        }
    }
}
