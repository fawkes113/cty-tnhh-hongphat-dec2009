using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CtyHongPhatDatabase.Table
{
    public class PaySheetInfo
    {
        private int paySheetId;
        private int employeeId;
        private decimal salary;
        private int workDays;
        private int overTime;
        private decimal overTimeSalary;
        private decimal bonus;
        private string createdBy;
        private DateTime createdDate;
        private string monthly;
        private int deleted;

        public int PaySheetId
        {
            get { return paySheetId; }
            set { paySheetId = value; }
        }

        public int EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }

        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public int WorkDays
        {
            get { return workDays; }
            set { workDays = value; }
        }

        public int OverTime
        {
            get { return overTime; }
            set { overTime = value; }
        }

        public decimal OverTimeSalary
        {
            get { return overTimeSalary; }
            set { overTimeSalary = value; }
        }

        public decimal Bonus
        {
            get { return bonus; }
            set { bonus = value; }
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

        public string Monthly
        {
            get { return monthly; }
            set { monthly = value; }
        }

        public int Deleted
        {
            get { return deleted; }
            set { deleted = value; }
        }
    }
}
