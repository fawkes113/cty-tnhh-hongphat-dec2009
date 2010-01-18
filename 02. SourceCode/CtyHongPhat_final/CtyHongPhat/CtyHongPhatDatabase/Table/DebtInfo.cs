using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CtyHongPhatDatabase.Table
{
    public class DebtInfo
    {
        private int debId;
        private decimal oldDebtValue;
        private decimal newDebtValue;
        private decimal payment;
        private decimal currentDebtValue;
        private int customerId;
        private int deleted;
        private string createdBy = String.Empty;
        private DateTime createDate;
        private string modifiedBy = String.Empty;
        private DateTime modifiedDate;
        private int debtKind;
        private string note = String.Empty;

        #region Public Properties
        public int DebId
        {
            get { return debId; }
            set { debId = value; }
        }

        public decimal OldDebtValue
        {
            get { return oldDebtValue; }
            set { oldDebtValue = value; }
        }

        public decimal NewDebtValue
        {
            get { return newDebtValue; }
            set { newDebtValue = value; }
        }

        public decimal Payment
        {
            get { return payment; }
            set { payment = value; }
        }

        public decimal CurrentDebtValue
        {
            get { return currentDebtValue; }
            set { currentDebtValue = value; }
        }

        public int CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }

        public int Deleted
        {
            get { return deleted; }
            set { deleted = value; }
        }

        public string CreatedBy
        {
            get { return createdBy; }
            set { createdBy = value; }
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

        public int DebtKind
        {
            get { return debtKind; }
            set { debtKind = value; }
        }

        public string Note
        {
            get { return note; }
            set { note = value; }
        }
        #endregion
    }
}
