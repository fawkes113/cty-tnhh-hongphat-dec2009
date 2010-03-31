using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CtyHongPhatDatabase.Table
{
    public class ExpenseInfo
    {
        private int expenseId;
        private DateTime fromDate;
        private DateTime toDate;
        private decimal expense;
        private string location;
        private int deleted;
        private string createdBy;
        private DateTime createdDate;

        public int ExpenseId
        {
            get { return expenseId; }
            set { expenseId = value; }
        }

        public DateTime FromDate
        {
            get { return fromDate; }
            set { fromDate = value; }
        }

        public DateTime ToDate
        {
            get { return toDate; }
            set { toDate = value; }
        }

        public decimal Expense
        {
            get { return expense; }
            set { expense = value; }
        }

        public string Location
        {
            get { return location; }
            set { location = value; }
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

        public DateTime CreatedDate
        {
            get { return createdDate; }
            set { createdDate = value; }
        }
    }
}
