using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CtyHongPhatDatabase.Table
{
    public class OrdersInfo
    {
        private int orderId;
        private int orderKind;
        private int customerId;
        private string createdBy = String.Empty;
        private DateTime createdDate;
        private string modifiedBy = String.Empty;
        private DateTime modifiedDate;
        private decimal total;
        private decimal pay;
        private int status;
        private string note = String.Empty;

        #region Public Properties
        public int OrderId
        {
            get { return orderId; }
            set { orderId = value; }
        }

        public int OrderKind
        {
            get { return orderKind; }
            set { orderKind = value; }
        }

        public int CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
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

        public decimal Total
        {
            get { return total; }
            set { total = value; }
        }

        public decimal Pay
        {
            get { return pay; }
            set { pay = value; }
        }

        public int Status
        {
            get { return status; }
            set { status = value; }
        }

        public string Note
        {
            get { return note; }
            set { note = value; }
        }
        #endregion
    }
}
