using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CtyHongPhatDatabase.Table
{
    public class SellPriceInfo
    {
        private int sellId;
        private int itemId;
        private int agentKindId;
        private decimal sellPrice;
        private DateTime createdDate;
        private string createdBy = String.Empty;
        private string modifiedBy = String.Empty;
        private DateTime modifiedDate;
        private int deleted;

        #region Public Properties
        public int SellId
        {
            get { return sellId; }
            set { sellId = value; }
        }

        public int ItemId
        {
            get { return itemId; }
            set { itemId = value; }
        }

        public int AgentKindId
        {
            get { return agentKindId; }
            set { agentKindId = value; }
        }

        public decimal SellPrice
        {
            get { return sellPrice; }
            set { sellPrice = value; }
        }

        public DateTime CreatedDate
        {
            get { return createdDate; }
            set { createdDate = value; }
        }

        public string CreatedBy
        {
            get { return createdBy; }
            set { createdBy = value; }
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
