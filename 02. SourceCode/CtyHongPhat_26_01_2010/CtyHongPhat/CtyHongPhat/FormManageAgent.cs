using System;
using System.Collections;
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
    public partial class FormManageAgent : Form
    {
        private string employeeName = "";
        private Database database = new Database();
        private List<AgentKindInfo> listAgentKinds;

        public FormManageAgent()
        {
            InitializeComponent();
        }

        public FormManageAgent(string employeeName)
        {
            InitializeComponent();
            this.employeeName = employeeName;
        }

        private void init()
        {
            listAgentKinds = new List<AgentKindInfo>();
            ArrayList listObject = null;

            this.textBoxName.Text = "";
            this.textBoxPhone.Text = "";
            this.textBoxAddress.Text = "";
            this.numericUpDownDebtAmount.Value = 0;

            AgentKindInfo overAgentKindInfo = new AgentKindInfo();
            overAgentKindInfo.AgentKindId = -1;
            overAgentKindInfo.AgentKindName = "<Loại đại lý>";
            this.listAgentKinds.Add(overAgentKindInfo);
            listObject = database.AgentKindGetAll();
            if (listObject != null && listObject.Count != 0)
                foreach (AgentKindInfo agentKindInfo in listObject)
                    this.listAgentKinds.Add(agentKindInfo);
        }

        private void BindData()
        {
            this.comboBoxAgentKind.DataSource = null;
            this.comboBoxAgentKind.Items.Clear();
            if (this.listAgentKinds.Count > 0)
            {
                this.comboBoxAgentKind.DataSource = listAgentKinds;
                this.comboBoxAgentKind.DisplayMember = "AgentKindName";
            }
        }

        private void BindListAgent()
        {
            this.dataGridViewListAgents.DataSource = null;
            this.dataGridViewListAgents.Rows.Clear();
            try
            {
                ArrayList listAgents = database.AgentGetAll();
                if (listAgents.Count > 0)
                {
                    for (int i = 0; i < listAgents.Count; i++)
                    {
                        AgentsInfo agentInfo = (AgentsInfo)listAgents[i];
                        AgentKindInfo agentKindInfo = database.AgentKindGetBy(agentInfo.AgentKindId);
                        DebtInfo debtInfo = database.DebtGetByCustomerId(agentInfo.AgentId);
                        //Xem lai toan bo debt lay bang customerId phai co them debtKind

                        this.dataGridViewListAgents.Rows.Add(false,
                            agentInfo.AgentId,
                            agentInfo.AgentName,
                            agentKindInfo.AgentKindName,
                            NumberViewer.InsertComma(debtInfo.CurrentDebtValue.ToString()),
                            agentInfo.Telephone,
                            agentInfo.Address
                            );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Error(this, ex.ToString());
            }
        }

        private void FormManageAgent_Load(object sender, EventArgs e)
        {
            this.BindListAgent();
            this.init();
            this.BindData();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (this.textBoxName.Text.Length <= 0)
            {
                MessageBox.Error(this, "Chưa nhập tên đại lý");
                return;
            }

            if (this.comboBoxAgentKind.SelectedItem != null && this.comboBoxAgentKind.SelectedItem is AgentKindInfo)
            {
                AgentKindInfo agentKindInfo = this.comboBoxAgentKind.SelectedItem as AgentKindInfo;
                if (agentKindInfo.AgentKindId == -1)
                {
                    MessageBox.Error(this, "Chưa chọn loại đại lý");
                    return;
                }

                AgentsInfo agentInfo = new AgentsInfo();

                agentInfo.Address = this.textBoxAddress.Text;
                agentInfo.AgentKindId = agentKindInfo.AgentKindId;
                agentInfo.AgentName = this.textBoxName.Text;
                agentInfo.CreatedBy = this.employeeName;
                agentInfo.CreatedDate = DateTime.Now;
                agentInfo.Deleted = 0;
                agentInfo.ModifiedBy = "";
                agentInfo.ModifiedDate = DateTime.Now;
                agentInfo.Telephone = this.textBoxPhone.Text;

                try
                {
                    int agentId = database.AgentAdd(agentInfo);
                    if (agentId > 0)
                    {
                        DebtInfo debtInfo = new DebtInfo();
                        debtInfo.CreatedBy = this.employeeName;
                        debtInfo.CurrentDebtValue = this.numericUpDownDebtAmount.Value;
                        debtInfo.CustomerId = agentId;
                        debtInfo.DebtKind = 1;
                        debtInfo.Deleted = 0;
                        debtInfo.ModifiedBy = "";
                        debtInfo.ModifiedDate = DateTime.Now;
                        debtInfo.NewDebtValue = 0;
                        debtInfo.Note = "";
                        debtInfo.OldDebtValue = 0;
                        debtInfo.Payment = 0;

                        database.DebtAdd(debtInfo);

                        MessageBox.Infor(this, "Thêm mới thành công");
                        this.init();

                    }
                    else
                    {
                        MessageBox.Error(this, "Có lỗi trong quá trình thêm mới");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Error(this, ex.ToString());
                }

            }
        }


    }
}
