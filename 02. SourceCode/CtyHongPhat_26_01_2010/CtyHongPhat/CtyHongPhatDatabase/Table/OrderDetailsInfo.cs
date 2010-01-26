using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CtyHongPhatDatabase.Table
{
    public class OrderDetailsInfo
    {
        private int orderDetailId;
        private int orderId;
        private int itemId;
        private decimal quantity;
        private int idPrice;
        private string createBy = String.Empty;
        private DateTime createDate;
        private string modifiedBy = String.Empty;
        private DateTime modifiedDate;
        private int deleted;
        private string note = String.Empty;

        #region Public Properties
        public int OrderDetailId
        {
            get { return orderDetailId; }
            set { orderDetailId = value; }
        }

        public int OrderId
        {
            get { return orderId; }
            set { orderId = value; }
        }

        public int ItemId
        {
            get { return itemId; }
            set { itemId = value; }
        }

        public decimal Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public int IdPrice
        {
            get { return idPrice; }
            set { idPrice = value; }
        }

        public string CreatedBy
        {
            get { return createBy; }
            set { createBy = value; }
        }

        public DateTime CreateDate
        {
            get { return createDate; }
            set { createDate = value; }
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

        public string Note
        {
            get { return note; }
            set { note = value; }
        }
        #endregion
    }
}
