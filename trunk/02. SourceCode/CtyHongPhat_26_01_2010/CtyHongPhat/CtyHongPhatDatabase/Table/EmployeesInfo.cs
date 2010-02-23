using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CtyHongPhatDatabase.Table
{
    public class EmployeesInfo
    {
        private int employeesId;
        private string employeeName = String.Empty;
        private decimal salary;
        private int deleted;
        private string position = String.Empty;
        private DateTime birthday;
        private string address;

        #region Public Properties
        public int EmployeeId
        {
            get { return employeesId; }
            set { employeesId = value; }
        }

        public string EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; }
        }

        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public int Deleted
        {
            get { return deleted; }
            set { deleted = value; }
        }

        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        #endregion
    }
}
