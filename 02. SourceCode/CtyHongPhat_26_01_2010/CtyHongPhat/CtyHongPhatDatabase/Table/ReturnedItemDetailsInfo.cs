using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CtyHongPhatDatabase.Table
{
    public class ReturnedItemDetailsInfo
    {
        private int returnedItemDetailsId;
        private int orderDetailId;
        private decimal quantity;
        private DateTime returnDate;
        private string note = String.Empty;
        private int deleted;

        #region Public Properties
        public int ReturnedItemDetailsId
        {
            get { return returnedItemDetailsId; }
            set { returnedItemDetailsId = value; }
        }

        public int OrderDetailId
        {
            get { return orderDetailId; }
            set { orderDetailId = value; }
        }

        public decimal Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public DateTime ReturnDate
        {
            get { return returnDate; }
            set { returnDate = value; }
        }

        public string Note
        {
            get { return note; }
            set { note = value; }
        }

        public int Deleted
        {
            get { return deleted; }
            set { deleted = value; }
        }
        #endregion
    }
}
