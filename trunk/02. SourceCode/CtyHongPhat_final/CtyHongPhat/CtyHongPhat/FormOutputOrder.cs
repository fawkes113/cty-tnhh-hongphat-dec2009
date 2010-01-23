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
using CtyHongPhatDatabase.View;

namespace CtyHongPhat
{
    public partial class FormOutputOrder : Form
    {
        List<AgentsInfo> listAgents = new List<AgentsInfo>();
        List<ItemInfo> listItems = new List<ItemInfo>();
        private Database database = new Database();

        public FormOutputOrder()
        {
            InitializeComponent();
        }

        private void BindData()
        {
            this.comboBoxListAgents.DataSource = null;
            this.comboBoxListAgents.Items.Clear();
            if (this.comboBoxListAgents.DataSource == null && this.listAgents.Count > 0)
            {
                this.comboBoxListAgents.DataSource = this.listAgents;
                this.comboBoxListAgents.DisplayMember = "AgentName";
            }

            this.comboBoxListItems.DataSource = null;
            this.comboBoxListItems.Items.Clear();
            if (this.comboBoxListItems.DataSource == null && this.listItems.Count > 0)
            {
                this.comboBoxListItems.DataSource = this.listItems;
                this.comboBoxListItems.DisplayMember = "ItemName";
            }
        }

        private void Init()
        {
            try
            {
                ArrayList listObject = null;

                AgentsInfo overAgentInfo = new AgentsInfo();
                overAgentInfo.AgentId = -1;
                overAgentInfo.AgentName = "<Tên đại lý>";
                this.listAgents.Add(overAgentInfo);
                listObject = database.AgentGetAll();
                if (listObject != null && listObject.Count != 0)
                    foreach (AgentsInfo agentInfo in listObject)
                        this.listAgents.Add(agentInfo);

                ItemInfo overItemInfo = new ItemInfo();
                overItemInfo.ItemId = -1;
                overItemInfo.ItemName = "<Tất cả>";
                this.listItems.Add(overItemInfo);
                listObject = database.ItemGetAll();
                if(listObject != null && listObject.Count != 0)
                    foreach(ItemInfo item in listObject)
                        this.listItems.Add(item);
            }
            catch(Exception ex)
            {
                MessageBox.Error(this, ex.ToString());
            }
        }

        private void FormOutputOrder_Load(object sender, EventArgs e)
        {
            Init();
            BindData();
        }

        private void comboBoxListAgents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxListAgents.SelectedItem != null && this.comboBoxListAgents.SelectedItem is AgentsInfo)
            {
                this.labelKindOfAngent.Text = "";
                this.labelTotalDebt.Text = "";
                try
                {
                    AgentsInfo agentsInfo = this.comboBoxListAgents.SelectedItem as AgentsInfo;
                    if (agentsInfo.AgentId > 0)
                    {
                        ViewAgentsInfo viewAgentInfo = database.ViewAgentInfoGetById(agentsInfo.AgentId);
                        if (viewAgentInfo != null)
                        {
                            this.labelKindOfAngent.Text = viewAgentInfo.AgentKindName;
                            this.labelTotalDebt.Text = NumberViewer.InsertComma(viewAgentInfo.CurrentDebtValue.ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Error(this, ex.ToString());
                }
            }
        }

        private void comboBoxListItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxListItems.SelectedItem != null && this.comboBoxListItems.SelectedItem is ItemInfo)
            {
                this.labelMeasurement.Text = "";
                this.labelRemainItemMeasurement.Text = "";
                this.labelSellPrice.Text = "";
                try
                {
                    ItemInfo itemInfo = this.comboBoxListItems.SelectedItem as ItemInfo;
                    if(itemInfo.ItemId > 0)
                    {
                        
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
