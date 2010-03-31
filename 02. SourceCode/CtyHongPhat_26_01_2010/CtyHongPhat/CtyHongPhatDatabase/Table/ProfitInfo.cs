using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CtyHongPhatDatabase.Table
{
    public class ProfitInfo
    {
        private int profitId;
        private decimal totalRevenues;
        private decimal totalCosts;
        private DateTime createdDate;
        private string createdBy;
        private int _deleted;
        private decimal profits;
        private string periodTime;

        public int ProfitId
        {
            get { return profitId; }
            set { profitId = value; }
        }

        public decimal TotalRevenues
        {
            get { return totalRevenues; }
            set { totalRevenues = value; }
        }

        public decimal TotalCosts
        {
            get { return totalCosts; }
            set { totalCosts = value; }
        }

        public DateTime CreatedDate
        {
            get { return createdDate; }
            set { createdDate = value; }
        }

        public string CreatedBy
        {
            get { return createdBy; }
            set { createdBy = value; }
        }

        public int Deleted
        {
            get { return _deleted; }
            set { _deleted = value; }
        }

        public decimal Profits
        {
            get { return profits; }
            set { profits = value; }
        }

        public string PeriodTime
        {
            get { return periodTime; }
            set { periodTime = value; }
        }
    }
}
