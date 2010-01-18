using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CtyHongPhatDatabase.Table
{
    public class ReturnedItemDetailsInfo
    {
        private int returnedItemDetailsId;
        private decimal quantity;
        private DateTime returnDate;
        private string note = String.Empty;

        #region Public Properties
        public int ReturnedItemDetailsId
        {
            get { return returnedItemDetailsId; }
            set { returnedItemDetailsId = value; }
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
        #endregion
    }
}
