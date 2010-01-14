using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace HongPhat.Entities
{
    #region EMPLOYEES
    /// <summary>
    /// This object represents the properties and methods of a EMPLOYEES.
    /// </summary>
    public class EMPLOYEES
    {
        private int _id;
        private string _employeeName = String.Empty;
        private decimal _salary;
        private int _deleted;
        private string _position = String.Empty;

        public EMPLOYEES()
        {
        }

        public EMPLOYEES(int id)
        {
            SqlService sql = new SqlService();
            sql.AddParameter("@EmployeeId", SqlDbType.Int, id);
            SqlDataReader reader = sql.ExecuteSqlReader("SELECT * FROM EMPLOYEES WHERE EmployeeId = @EmployeeId");

            if (reader.Read())
            {
                this.LoadFromReader(reader);
                reader.Close();
            }
            else
            {
                if (!reader.IsClosed) reader.Close();
                throw new ApplicationException("EMPLOYEES does not exist.");
            }
        }

        public EMPLOYEES(SqlDataReader reader)
        {
            this.LoadFromReader(reader);
        }

        protected void LoadFromReader(SqlDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                _id = reader.GetInt32(0);
                if (!reader.IsDBNull(1)) _employeeName = reader.GetString(1);
                if (!reader.IsDBNull(2)) _salary = reader.GetDecimal(2);
                if (!reader.IsDBNull(3)) _deleted = reader.GetInt32(3);
                if (!reader.IsDBNull(4)) _position = reader.GetString(4);
            }
        }

        public void Delete()
        {
            EMPLOYEES.Delete(_id);
        }

        public void Update()
        {
            SqlService sql = new SqlService();
            StringBuilder queryParameters = new StringBuilder();

            sql.AddParameter("@EmployeeId", SqlDbType.Int, Id);
            queryParameters.Append("EmployeeId = @EmployeeId");

            sql.AddParameter("@EmployeeName", SqlDbType.NVarChar, EmployeeName);
            queryParameters.Append(", EmployeeName = @EmployeeName");
            sql.AddParameter("@Salary", SqlDbType.Decimal, Salary);
            queryParameters.Append(", Salary = @Salary");
            sql.AddParameter("@Deleted", SqlDbType.Int, Deleted);
            queryParameters.Append(", Deleted = @Deleted");
            sql.AddParameter("@Position", SqlDbType.NVarChar, Position);
            queryParameters.Append(", Position = @Position");

            string query = String.Format("Update EMPLOYEES Set {0} Where EmployeeId = @EmployeeId", queryParameters.ToString());
            SqlDataReader reader = sql.ExecuteSqlReader(query);
        }

        public void Create()
        {
            SqlService sql = new SqlService();
            StringBuilder queryParameters = new StringBuilder();

            sql.AddParameter("@EmployeeId", SqlDbType.Int, Id);
            queryParameters.Append("@EmployeeId");

            sql.AddParameter("@EmployeeName", SqlDbType.NVarChar, EmployeeName);
            queryParameters.Append(", @EmployeeName");
            sql.AddParameter("@Salary", SqlDbType.Decimal, Salary);
            queryParameters.Append(", @Salary");
            sql.AddParameter("@Deleted", SqlDbType.Int, Deleted);
            queryParameters.Append(", @Deleted");
            sql.AddParameter("@Position", SqlDbType.NVarChar, Position);
            queryParameters.Append(", @Position");

            string query = String.Format("Insert Into EMPLOYEES ({0}) Values ({1})", queryParameters.ToString().Replace("@", ""), queryParameters.ToString());
            SqlDataReader reader = sql.ExecuteSqlReader(query);
        }

        public static EMPLOYEES NewEMPLOYEES(int id)
        {
            EMPLOYEES newEntity = new EMPLOYEES();
            newEntity._id = id;

            return newEntity;
        }

        #region Public Properties
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string EmployeeName
        {
            get { return _employeeName; }
            set { _employeeName = value; }
        }

        public decimal Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public int Deleted
        {
            get { return _deleted; }
            set { _deleted = value; }
        }

        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }
        #endregion

        public static EMPLOYEES GetEMPLOYEES(int id)
        {
            return new EMPLOYEES(id);
        }

        public static void Delete(int id)
        {
            SqlService sql = new SqlService();
            sql.AddParameter("@EmployeeId", SqlDbType.Int, id);

            SqlDataReader reader = sql.ExecuteSqlReader("Delete EMPLOYEES Where EmployeeId = @EmployeeId");
        }
    }
    #endregion
}

