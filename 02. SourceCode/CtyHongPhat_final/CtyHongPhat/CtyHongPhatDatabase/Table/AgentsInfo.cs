using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CtyHongPhatDatabase.Table
{
    public class AgentsInfo
    {
        private int agentId;
        private string agentName = String.Empty;
        private string createdBy = String.Empty;
        private DateTime createdDate;
        private string modifiedBy = String.Empty;
        private DateTime modifiedDate;
        private int idAgentKind;
        private int deleted;

        #region Public Properties
        public int AgentId
        {
            get { return agentId; }
            set { agentId = value; }
        }

        public string AgentName
        {
            get { return agentName; }
            set { agentName = value; }
        }

        public string CreatedBy
        {
            get { return createdBy; }
            set { createdBy = value; }
        }

        public DateTime CreatedDate
        {
            get { return createdDate; }
            set { createdDate = value; }
        }

        public string ModifiedBy
        {
            get { return modifiedBy; }
            set { modifiedBy = value; }
        }

        public DateTime ModifiedDate
        {
            get { return modifiedDate; }
            set { modifiedDate = value; }
        }

        public int AgentKindId
        {
            get { return idAgentKind; }
            set { idAgentKind = value; }
        }

        public int Deleted
        {
            get { return deleted; }
            set { deleted = value; }
        }
        #endregion

    }
}
