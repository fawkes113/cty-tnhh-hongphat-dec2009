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
            this.buttonInsert.Enabled = true;
            this.numericUpDownDebtAmount.Value = 0;
            this.numericUpDownDebtAmount.Enabled = true;

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
                        DebtInfo debtInfo = database.DebtGetByCustomer(agentInfo.AgentId, 1);

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

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            this.BindListAgent();
            this.init();
            this.BindData();
        }

        private void dataGridViewListAgents_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewListAgents.SelectedRows != null && this.dataGridViewListAgents.SelectedRows.Count > 0)
            {
                this.buttonInsert.Enabled = false;
                this.numericUpDownDebtAmount.Enabled = false;
                DataGridViewRow selectedRow = this.dataGridViewListAgents.SelectedRows[0];
                int agentId = int.Parse(selectedRow.Cells[ColumnAgentId.Index].Value.ToString());

                try
                {
                    AgentsInfo agentInfo = database.AgentById(agentId);
                    DebtInfo debtInfo = database.DebtGetByCustomer(agentInfo.AgentId, 1);
                    if (agentInfo == null) return;

                    this.textBoxAddress.Text = agentInfo.Address;
                    this.textBoxName.Text = agentInfo.AgentName;
                    this.textBoxPhone.Text = agentInfo.Telephone;
                    this.numericUpDownDebtAmount.Value = debtInfo.CurrentDebtValue;

                    for (int i = 0; i < this.comboBoxAgentKind.Items.Count; i++)
                    {
                        AgentKindInfo agentKindInfo = this.comboBoxAgentKind.Items[i] as AgentKindInfo;
                        if (agentKindInfo.AgentKindId == agentInfo.AgentKindId)
                        {
                            this.comboBoxAgentKind.SelectedIndex = i;
                            i = this.comboBoxAgentKind.Items.Count;
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Error(this, ex.ToString());
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < this.dataGridViewListAgents.Rows.Count; i++)
            {
                if ((bool)this.dataGridViewListAgents.Rows[i].Cells[ColumnCheck.Index].Value == true)
                {
                    DataGridViewRow row = this.dataGridViewListAgents.Rows[i];
                    int agentId = int.Parse(row.Cells[ColumnAgentId.Index].Value.ToString());
                    try
                    {
                        DebtInfo debtInfo = database.DebtGetByCustomer(agentId, 1);
                        if (debtInfo.CurrentDebtValue > 0)
                        {
                            string message = "Đại lý : " + row.Cells[ColumnAgentName.Index].Value.ToString() + " vẫn còn nợ không được xóa";
                            MessageBox.Error(this, message);
                        }

                        database.AgentDelete(agentId, this.employeeName, DateTime.Now);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Error(this, ex.ToString());
                    }

                }
            }

            this.BindListAgent();
            this.init();
            this.BindData();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (this.textBoxName.Text.Length <= 0)
            {
                MessageBox.Error(this, "Chưa nhập tên đại lý");
                return;
            }

            if (((AgentKindInfo)this.comboBoxAgentKind.SelectedItem).AgentKindId <= 0)
            {
                MessageBox.Error(this, "Chưa chọn loại đại lý");
                return;
            }


            if (this.dataGridViewListAgents.SelectedRows != null && this.dataGridViewListAgents.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = this.dataGridViewListAgents.SelectedRows[0];
                int agentId = int.Parse(selectedRow.Cells[ColumnAgentId.Index].Value.ToString());

                try
                {
                    AgentsInfo agentInfo = database.AgentById(agentId);
                    agentInfo.AgentName = this.textBoxName.Text;
                    agentInfo.Address = this.textBoxAddress.Text;
                    agentInfo.Telephone = this.textBoxPhone.Text;
                    agentInfo.AgentKindId = ((AgentKindInfo)this.comboBoxAgentKind.SelectedItem).AgentKindId;
                    agentInfo.ModifiedBy = this.employeeName;
                    agentInfo.ModifiedDate = DateTime.Now;

                    if (database.AgentUpdate(agentInfo))
                    {
                        MessageBox.Infor(this, "Cập nhật thành công");
                        this.BindListAgent();
                        this.init();
                        this.BindData();
                    }
                    else
                    {
                        MessageBox.Infor(this, "Có lỗi trong quá trình cập nhật");
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
