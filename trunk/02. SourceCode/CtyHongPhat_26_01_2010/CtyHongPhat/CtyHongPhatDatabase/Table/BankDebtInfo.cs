using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CtyHongPhatDatabase.Table
{
    public class BankDebtInfo
    {
        private int _bankDebtId;
        private string _bankName;
        private System.DateTime _borrowDate;
        private decimal _debtAmount;
        private decimal _paidAmount;
        private System.DateTime _maturityDate;
        private decimal _interestRate;
        private int _deleted;
        private string _createdBy;
        private System.DateTime _createdDate;
        private string _modifiedBy;
        private System.DateTime _modifiedDate;

        #region Public Properties
        public int BankDebtId
        {
            get { return _bankDebtId; }
            set { _bankDebtId = value; }
        }

        public string BankName
        {
            get { return _bankName; }
            set { _bankName = value; }
        }

        public System.DateTime BorrowDate
        {
            get { return _borrowDate; }
            set { _borrowDate = value; }
        }

        public decimal DebtAmount
        {
            get { return _debtAmount; }
            set { _debtAmount = value; }
        }

        public decimal PaidAmount
        {
            get { return _paidAmount; }
            set { _paidAmount = value; }
        }

        public System.DateTime MaturityDate
        {
            get { return _maturityDate; }
            set { _maturityDate = value; }
        }

        public decimal InterestRate
        {
            get { return _interestRate; }
            set { _interestRate = value; }
        }

        public int Deleted
        {
            get { return _deleted; }
            set { _deleted = value; }
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

        #endregion
    }
}
