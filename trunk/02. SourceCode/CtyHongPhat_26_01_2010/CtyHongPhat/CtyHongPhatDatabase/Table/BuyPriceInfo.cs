using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CtyHongPhatDatabase.Table
{
    [System.Diagnostics.DebuggerDisplay("Id={BuyId}, Price={BuyPrice}, ItemId={ItemId}, PartnerId={PartnerId}")]
    public class BuyPriceInfo
    {
        private int buyId;
        private int itemId;
        private int partnerId;
        private decimal buyPrice;
        private string createdBy = String.Empty;
        private DateTime createdDate;
        private string modifiedBy = String.Empty;
        private DateTime modifiedDate;
        private int deleted;

        #region Public Properties
        public int BuyId
        {
            get { return buyId; }
            set { buyId = value; }
        }

        public int ItemId
        {
            get { return itemId; }
            set { itemId = value; }
        }

        public int PartnerId
        {
            get { return partnerId; }
            set { partnerId = value; }
        }

        public decimal BuyPrice
        {
            get { return buyPrice; }
            set { buyPrice = value; }
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
