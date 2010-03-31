using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CtyHongPhatDatabase.Table
{
    class ProfitCostInfo
    {
        private int profitCostId;
        private int costType;
        private decimal totalAmount;
        private string periodType;
        private DateTime createdDate;
        private string createdBy;
        private int deleted;
        private int profitId;

        public int ProfitCostId
        {
            get { return profitCostId; }
            set { profitCostId = value; }
        }

        public int CostType
        {
            get { return costType; }
            set { costType = value; }
        }

        public decimal TotalAmount
        {
            get { return totalAmount; }
            set { totalAmount = value; }
        }

        public string PeriodType
        {
            get { return periodType; }
            set { periodType = value; }
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
            get { return deleted; }
            set { deleted = value; }
        }

        public int ProfitId
        {
            get { return profitId; }
            set { profitId = value; }
        }
    }
}
