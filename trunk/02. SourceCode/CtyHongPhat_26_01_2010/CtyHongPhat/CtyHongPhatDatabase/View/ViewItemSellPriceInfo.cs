using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CtyHongPhatDatabase.View
{
    public class ViewItemSellPriceInfo
    {
        private int itemId;
        private string itemName = String.Empty;
        private string createdBy = String.Empty;
        private DateTime createdDate;
        private string modifiedBy = String.Empty;
        private DateTime modifiedDate;
        private int deleted;
        private decimal totalQuantity;
        private string measurement = String.Empty;
        private int sellId;
        private decimal sellPrice;
        private int agentKindId;
        private string agentKindName;

        #region Public Properties
        public int ItemId
        {
            get { return itemId; }
            set { itemId = value; }
        }

        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; }
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

        public decimal TotalQuantity
        {
            get { return totalQuantity; }
            set { totalQuantity = value; }
        }

        public string Measurement
        {
            get { return measurement; }
            set { measurement = value; }
        }

        public int SellId
        {
            get { return sellId; }
            set { sellId = value; }
        }

        public decimal SellPrice
        {
            get { return sellPrice; }
            set { sellPrice = value; }
        }

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

        #endregion
    }
}
