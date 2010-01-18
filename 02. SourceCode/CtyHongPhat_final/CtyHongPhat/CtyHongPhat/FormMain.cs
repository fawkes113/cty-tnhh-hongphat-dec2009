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
                FormOutputOrder formOutputOrder = new FormOutputOrder();
                this.tabControlMain.TabPages.Add(formOutputOrder);
            }
        }

        private void ToolStripMenuItemInputOrder_Click(object sender, EventArgs e)
        {
            if (AddUniqueForm(typeof(FormInputOrder)))
            {
                FormInputOrder formInputOrder = new FormInputOrder();
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
    }
}
