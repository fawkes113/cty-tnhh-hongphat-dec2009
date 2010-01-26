using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CtyHongPhatDatabase.Table
{
    public class AgentKindInfo
    {
        private int agentKindId;
        private string agentKindName = String.Empty;
        private string createdBy = String.Empty;
        private DateTime createdDate;
        private string modifiedBy = String.Empty;
        private DateTime modifiedDate;
        private int deleted;

        #region Public Properties
        public int AgentKindId
        {
            get { return agentKindId; }
            set { agentKindId = value; }
        }
        
        public string AgentKindName
        {
            get { return agentKindName; }
            set { agentKindName = value; }
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

        public int Deleted
        {
            get { return deleted; }
            set { deleted = value; }
        }
        #endregion
    }
}
