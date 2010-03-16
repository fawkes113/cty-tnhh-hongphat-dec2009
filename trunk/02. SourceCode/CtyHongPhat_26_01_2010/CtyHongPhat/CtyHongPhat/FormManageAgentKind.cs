using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CtyHongPhatDatabase.Table;
using CtyHongPhat.Utility;

namespace CtyHongPhat
{
    public partial class FormManageAgentKind : Form
    {
        string employeeName = "";
        private Database database = new Database();
        public FormManageAgentKind()
        {
            InitializeComponent();
        }

        public FormManageAgentKind(string employeeName)
        {
            this.employeeName = employeeName;
            InitializeComponent();
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (this.textBoxName.Text.Length <= 0)
            {
                MessageBox.Error(this, "Bạn chưa nhập tên loại đại lý");
                return;
            }

            try
            {
                AgentKindInfo agentKindInfo = new AgentKindInfo();
                agentKindInfo.AgentKindName = this.textBoxName.Text;
                agentKindInfo.CreatedBy = this.employeeName;
                agentKindInfo.CreatedDate = DateTime.Now;
                agentKindInfo.Deleted = 0;
                agentKindInfo.ModifiedBy = "";
                agentKindInfo.ModifiedDate = DateTime.Now;

                if (database.AgentKindAdd(agentKindInfo) > 0)
                {
                    MessageBox.Infor(this, "Thêm mới loại đại lý thành công");
                    this.textBoxName.Text = "";
                }
                else
                {
                    MessageBox.Error(this, "Có lỗi trong quá trình thêm mới");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Error(this, ex.ToString());
            }
      
        }
    }
}
