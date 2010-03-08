using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Windows.Forms;

namespace CtyHongPhat
{
    public partial class FormMain : Form
    {
        private string userName = "";
        public FormMain()
        {
            InitializeComponent();
        }

        private bool AddUniqueForm(Type formType)
        {
            for (int i = 0; i < this.tabControlMain.TabPages.Count; i++)
                if (this.tabControlMain.TabPages[i].Form.GetType().Equals(formType))
                {
                    this.tabControlMain.TabPages[i].Select();
                    return false;
                }
            return true;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            FormLogin frm = new FormLogin(this);
            frm.UserName = userName;
            frm.ShowDialog(this);
            if (!frm.IsOK)
            {
                this.Dispose();
            }

            this.userName = frm.UserName;
        }

        private void doiMatKhauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUserPasswordChange frm = new FormUserPasswordChange();
            frm.ShowDialog(this);
        }

        private void ToolStripMenuItemOutputOder_Click(object sender, EventArgs e)
        {
            if (AddUniqueForm(typeof(FormOutputOrder)))
            {
                FormOutputOrder formOutputOrder = new FormOutputOrder(this.userName);
                this.tabControlMain.TabPages.Add(formOutputOrder);
            }
        }

        private void ToolStripMenuItemInputOrder_Click(object sender, EventArgs e)
        {
            if (AddUniqueForm(typeof(FormInputOrder)))
            {
                FormInputOrder formInputOrder = new FormInputOrder(this.userName);
                this.tabControlMain.TabPages.Add(formInputOrder);
            }
        }

        private void ToolStripMenuItemListItems_Click(object sender, EventArgs e)
        {
            if (AddUniqueForm(typeof(FormListItem)))
            {
                FormListItem formListItem = new FormListItem();
                this.tabControlMain.TabPages.Add(formListItem);
            }
        }

        private void ToolStripMenuItemListOrders_Click(object sender, EventArgs e)
        {
            if(AddUniqueForm(typeof(FormManagerDebt)))
            {
                FormManagerDebt formManagerDebt = new FormManagerDebt(this.userName);
                this.tabControlMain.TabPages.Add(formManagerDebt);
            }
        }

        private void ToolStripMenuItemMagateEmployee_Click(object sender, EventArgs e)
        {
            if (AddUniqueForm(typeof(FormManageEmployee)))
            {
                FormManageEmployee formManagateEmployee = new FormManageEmployee(userName);
                this.tabControlMain.TabPages.Add(formManagateEmployee);
            }
        }

        private void ToolStripMenuItemPrintPaySheet_Click(object sender, EventArgs e)
        {
            FormPrintPaySheet formPrintPaySheet = new FormPrintPaySheet();
            formPrintPaySheet.Show();
        }

        private void ToolStripMenuItemDebt_Click(object sender, EventArgs e)
        {
            if (AddUniqueForm(typeof(FormManagerDebt)))
            {
                FormManagerDebt formListOrders = new FormManagerDebt(userName);
                this.tabControlMain.TabPages.Add(formListOrders);
            }
        }

        private void ToolStripMenuItemManagePacks_Click(object sender, EventArgs e)
        {
            if (AddUniqueForm(typeof(FormManagePacks)))
            {
                FormManagePacks formManagePacks = new FormManagePacks(userName);
                this.tabControlMain.TabPages.Add(formManagePacks);
            }
        }
    }
}
