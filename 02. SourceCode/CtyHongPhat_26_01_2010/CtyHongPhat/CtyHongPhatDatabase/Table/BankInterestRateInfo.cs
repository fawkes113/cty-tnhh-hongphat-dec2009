using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CtyHongPhatDatabase.Table
{
    public class BankInterestRateInfo
    {
        private int _bankInterestRateId;
        private int _bankDebtId;
        private decimal _rateAmount;
        private System.DateTime _payDate;
        private System.DateTime _createdDate;
        private string _createdBy;
        private string _modifiedBy;
        private System.DateTime _modifiedDate;
        private int _deleted;

        #region Public Properties
        public int BankInterestRateId
        {
            get { return _bankInterestRateId; }
            set { _bankInterestRateId = value; }
        }

        public int BankDebtId
        {
            get { return _bankDebtId; }
            set { _bankDebtId = value; }
        }

        public decimal RateAmount
        {
            get { return _rateAmount; }
            set { _rateAmount = value; }
        }

        public System.DateTime PayDate
        {
            get { return _payDate; }
            set { _payDate = value; }
        }

        public System.DateTime CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
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
