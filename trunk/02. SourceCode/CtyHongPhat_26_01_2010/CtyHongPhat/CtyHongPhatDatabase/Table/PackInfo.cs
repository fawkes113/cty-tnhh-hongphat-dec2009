using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CtyHongPhatDatabase.Table
{
    public class PackInfo
    {
        private int _packId;
        private string _packName;
        private int _quantity;
        private System.DateTime _importDate;
        private decimal _totalAmount;
        private string _createdBy;
        private System.DateTime _createdDate;
        private string _modifiedBy;
        private System.DateTime _modifiedDate;
        private int _deleted;

        #region Public Properties
        public int PackId
        {
            get { return _packId; }
            set { _packId = value; }
        }

        public string PackName
        {
            get { return _packName; }
            set { _packName = value; }
        }

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        public System.DateTime ImportDate
        {
            get { return _importDate; }
            set { _importDate = value; }
        }

        public decimal TotalAmount
        {
            get { return _totalAmount; }
            set { _totalAmount = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public System.DateTime CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string ModifiedBy
        {
            get { return _modifiedBy; }
            set { _modifiedBy = value; }
        }

        public System.DateTime ModifiedDate
        {
            get { return _modifiedDate; }
            set { _modifiedDate = value; }
        }

        public int Deleted
        {
            get { return _deleted; }
            set { _deleted = value; }
        }

        #endregion
    }
}
