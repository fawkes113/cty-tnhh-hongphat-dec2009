using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CtyHongPhatDatabase.Table
{
    public class UsersInfo
    {
        private int userId;
        private string userName = String.Empty;
        private string userPassword = String.Empty;
        private int deleted;
        private int employeeId;

        #region Public Properties
        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public string UserPassword
        {
            get { return userPassword; }
            set { userPassword = value; }
        }

        public int Deleted
        {
            get { return deleted; }
            set { deleted = value; }
        }

        public int EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }
        #endregion
    }
}
