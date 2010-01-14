using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace HongPhat.Entities
{
    #region USERS
    /// <summary>
    /// This object represents the properties and methods of a USERS.
    /// </summary>
    public class USERS
    {
        private int _id;
        private string _userName = String.Empty;
        private string _userPassword = String.Empty;
        private int _deleted;
        private int _employeeId;

        public USERS()
        {
        }

        public USERS(int id)
        {
            SqlService sql = new SqlService();
            sql.AddParameter("@UserId", SqlDbType.Int, id);
            SqlDataReader reader = sql.ExecuteSqlReader("SELECT * FROM USERS WHERE UserId = @UserId");

            if (reader.Read())
            {
                this.LoadFromReader(reader);
                reader.Close();
            }
            else
            {
                if (!reader.IsClosed) reader.Close();
                throw new ApplicationException("USERS does not exist.");
            }
        }

        public USERS(SqlDataReader reader)
        {
            this.LoadFromReader(reader);
        }

        protected void LoadFromReader(SqlDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                _id = reader.GetInt32(0);
                if (!reader.IsDBNull(1)) _userName = reader.GetString(1);
                if (!reader.IsDBNull(2)) _userPassword = reader.GetString(2);
                if (!reader.IsDBNull(3)) _deleted = reader.GetInt32(3);
                if (!reader.IsDBNull(4)) _employeeId = reader.GetInt32(4);
            }
        }

        public void Delete()
        {
            USERS.Delete(_id);
        }

        public void Update()
        {
            SqlService sql = new SqlService();
            StringBuilder queryParameters = new StringBuilder();

            sql.AddParameter("@UserId", SqlDbType.Int, Id);
            queryParameters.Append("UserId = @UserId");

            sql.AddParameter("@UserName", SqlDbType.NVarChar, UserName);
            queryParameters.Append(", UserName = @UserName");
            sql.AddParameter("@UserPassword", SqlDbType.NVarChar, UserPassword);
            queryParameters.Append(", UserPassword = @UserPassword");
            sql.AddParameter("@Deleted", SqlDbType.Int, Deleted);
            queryParameters.Append(", Deleted = @Deleted");
            sql.AddParameter("@EmployeeId", SqlDbType.Int, EmployeeId);
            queryParameters.Append(", EmployeeId = @EmployeeId");

            string query = String.Format("Update USERS Set {0} Where UserId = @UserId", queryParameters.ToString());
            SqlDataReader reader = sql.ExecuteSqlReader(query);
        }

        public void Create()
        {
            SqlService sql = new SqlService();
            StringBuilder queryParameters = new StringBuilder();

            sql.AddParameter("@UserId", SqlDbType.Int, Id);
            queryParameters.Append("@UserId");

            sql.AddParameter("@UserName", SqlDbType.NVarChar, UserName);
            queryParameters.Append(", @UserName");
            sql.AddParameter("@UserPassword", SqlDbType.NVarChar, UserPassword);
            queryParameters.Append(", @UserPassword");
            sql.AddParameter("@Deleted", SqlDbType.Int, Deleted);
            queryParameters.Append(", @Deleted");
            sql.AddParameter("@EmployeeId", SqlDbType.Int, EmployeeId);
            queryParameters.Append(", @EmployeeId");

            string query = String.Format("Insert Into USERS ({0}) Values ({1})", queryParameters.ToString().Replace("@", ""), queryParameters.ToString());
            SqlDataReader reader = sql.ExecuteSqlReader(query);
        }

        public static USERS NewUSERS(int id)
        {
            USERS newEntity = new USERS();
            newEntity._id = id;

            return newEntity;
        }

        #region Public Properties
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        public string UserPassword
        {
            get { return _userPassword; }
            set { _userPassword = value; }
        }

        public int Deleted
        {
            get { return _deleted; }
            set { _deleted = value; }
        }

        public int EmployeeId
        {
            get { return _employeeId; }
            set { _employeeId = value; }
        }
        #endregion

        public static USERS GetUSERS(int id)
        {
            return new USERS(id);
        }

        public static void Delete(int id)
        {
            SqlService sql = new SqlService();
            sql.AddParameter("@UserId", SqlDbType.Int, id);

            SqlDataReader reader = sql.ExecuteSqlReader("Delete USERS Where UserId = @UserId");
        }
    }
    #endregion
}

