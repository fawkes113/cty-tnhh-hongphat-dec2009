using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using CtyHongPhatDatabase.Table;

namespace CtyHongPhatDatabase.Controller
{
    public class UserController
    {
        public static ArrayList GetAll(SqlConnection conn)
        {
            string sqlCmd = "SELECT * FROM USER WHERE DELETED = 0";
            conn.Open();
            SqlCommand comm = new SqlCommand(sqlCmd, conn);
            return CBO.FillCollection(comm.ExecuteReader(), typeof(UsersInfo));
        }
        public static ArrayList GetAllHaveOrderBy(SqlConnection conn, string OrderColumn, string OrderType)
        {
            string sqlCmd = "SELECT * FROM USER WHERE DELETED = 0 ORDER BY " + OrderColumn + " " + OrderType;
            conn.Open();
            SqlCommand comm = new SqlCommand(sqlCmd, conn);
            return CBO.FillCollection(comm.ExecuteReader(), typeof(UsersInfo));
        }
        public static ArrayList GetByColumn(SqlConnection conn, string columnName, object columnValue)
        {
            string sqlWhere = "";
            if (columnValue == null)
                sqlWhere = columnName + " IS NULL";
            else if (columnValue is string)
                sqlWhere = columnName + " = '" + columnValue + "'";
            else if (columnValue is DateTime)
                sqlWhere = "CONVERT(varchar(10), " + columnName + ",103)=" + MiscUtility.DateTimeToString((DateTime)columnValue);
            else
                sqlWhere = columnName + " = " + columnValue;
            string sqlCmd = "SELECT * FROM USER WHERE " + sqlWhere + " AND DELETED = 0";

            conn.Open();
            SqlCommand comm = new SqlCommand(sqlCmd,conn);
            return CBO.FillCollection(comm.ExecuteReader(), typeof(UsersInfo));
        }
        public static ArrayList GetByColumnHaveOrderBy(SqlConnection conn, string columnName, object columnValue, string orderColumn, string orderType)
        {
            string sqlWhere = "";
            if (columnValue == null)
                sqlWhere = columnName + " IS NULL";
            else if (columnValue is string)
                sqlWhere = columnName + " = '" + columnValue + "'";
            else if (columnValue is DateTime)
                sqlWhere = "CONVERT(varchar(10), " + columnName + ",103)=" + MiscUtility.DateTimeToString((DateTime)columnValue);
            else
                sqlWhere = columnName + " = " + columnValue;
            string sqlCmd = "SELECT * FROM USER WHERE " + sqlWhere + " AND DELETED = 0" + " ORDER BY " + orderColumn + " " + orderType;

            conn.Open();
            SqlCommand comm = new SqlCommand(sqlCmd,conn);
            return CBO.FillCollection(comm.ExecuteReader(), typeof(UsersInfo));
        }
        public static UsersInfo GetByColumnTop1(SqlConnection conn, string columnName, object columnValue)
        {
            string sqlWhere = "";
            if (columnValue == null)
                sqlWhere = columnName + " IS NULL";
            else if (columnValue is string)
                sqlWhere = columnName + " = '" + columnValue + "'";
            else if (columnValue is DateTime)
                sqlWhere = "CONVERT(varchar(10), " + columnName + ",103)=" + MiscUtility.DateTimeToString((DateTime)columnValue);
            else
                sqlWhere = columnName + " = " + columnValue;
            string sqlCmd = "SELECT top 1 * FROM USER WHERE " + sqlWhere + " AND DELETED = 0";

            conn.Open();
            SqlCommand comm = new SqlCommand(sqlCmd,conn);
            return (UsersInfo)CBO.FillObject(comm.ExecuteReader(), typeof(UsersInfo));
        }
        public static UsersInfo GetByColumnsTop1(SqlConnection conn, params object[] columns)
        {
            if (columns == null || columns.Length <= 0)
                return null;
            if (columns.Length % 2 != 0)
                return null;
            string sqlWhere = "";
            for (int i = 0; i < columns.Length; i += 2)
            {
                if (columns[i] == null)
                    continue;
                if (sqlWhere.Length > 0)
                    sqlWhere += " AND ";
                if (columns[i + 1] == null)
                    sqlWhere += columns[i].ToString() + " IS NULL";
                else if (columns[i + 1] is string)
                    sqlWhere += columns[i] + " = '" + columns[i + 1] + "'";
                else if (columns[i + 1] is DateTime)
                    sqlWhere += "CONVERT(varchar(10), " + columns[i] + ",103)=" + MiscUtility.DateTimeToString((DateTime)columns[i + 1]);
                else
                    sqlWhere += columns[i] + " = " + columns[i + 1];
            }
            string sqlCmd = "SELECT top 1 * FROM USERS WHERE " + sqlWhere + " AND DELETED = 0";

            conn.Open();
            SqlCommand comm = new SqlCommand(sqlCmd,conn);
            return (UsersInfo)CBO.FillObject(comm.ExecuteReader(), typeof(UsersInfo));
        }
        public static ArrayList GetByColumns(SqlConnection conn, params object[] columns)
        {
            if (columns == null || columns.Length <= 0)
                return AgentKindController.GetAll(conn);
            if (columns.Length % 2 != 0)
                return null;
            string sqlWhere = "";
            for (int i = 0; i < columns.Length; i += 2)
            {
                if (columns[i] == null)
                    continue;
                if (sqlWhere.Length > 0)
                    sqlWhere += " AND ";
                if (columns[i + 1] == null)
                    sqlWhere += columns[i].ToString() + " IS NULL";
                else if (columns[i + 1] is string)
                    sqlWhere += columns[i] + " = '" + columns[i + 1] + "'";
                else if (columns[i + 1] is DateTime)
                    sqlWhere += "CONVERT(varchar(10), " + columns[i] + ",103)=" + MiscUtility.DateTimeToString((DateTime)columns[i + 1]);
                else
                    sqlWhere += columns[i] + " = " + columns[i + 1];
            }
            string sqlCmd = "SELECT * FROM USER WHERE " + sqlWhere + " AND DELETED = 0";

            conn.Open();
            SqlCommand comm = new SqlCommand(sqlCmd,conn);
            return CBO.FillCollection(comm.ExecuteReader(), typeof(UsersInfo));
        }
        public static void DeleteByColumns(SqlConnection conn, params object[] columns)
        {
            if (columns.Length % 2 != 0)
                return;
            string sqlWhere = "";
            for (int i = 0; i < columns.Length; i += 2)
            {
                if (columns[i] == null)
                    continue;
                if (sqlWhere.Length > 0)
                    sqlWhere += " AND ";
                if (columns[i + 1] == null)
                    sqlWhere += columns[i].ToString() + " IS NULL";
                else if (columns[i + 1] is string)
                    sqlWhere += columns[i] + " = '" + columns[i + 1] + "'";
                else if (columns[i + 1] is DateTime)
                    sqlWhere += "CONVERT(varchar(10), " + columns[i] + ",103)=" + MiscUtility.DateTimeToString((DateTime)columns[i + 1]);
                else
                    sqlWhere += columns[i] + " = " + columns[i + 1];
            }
            string sqlCmd = "DELETE USER WHERE " + sqlWhere + " AND DELETED = 0";

            conn.Open();
            SqlCommand comm = new SqlCommand(sqlCmd,conn);
            comm.ExecuteNonQuery();
        }

        public static bool CheckUserPassword(SqlConnection conn, string user, string password)
        {
            password = password.Trim().ToUpper();
            if (password.Length < 10)
                password = password.PadRight(10, ' ');

            password = new EncodeHVT.EncryptHVClass().MD8PWD(ref password);
            user = user.ToUpper();

            //get userinfo and check password
            UsersInfo ui = GetByColumnsTop1(conn,
               "UserName", user,
               "UserPassword", password);

            if(ui != null && ui.UserName == user && ui.UserPassword == password && ui.Deleted == 0)
            return true;

            return false;
        }

        public static bool ChangePassword(SqlConnection conn, string user, string passwordOld, string passwordNew)
        {
            passwordOld = passwordOld.ToUpper();
            if (passwordOld.Length < 10)
                passwordOld = passwordOld.PadRight(10, ' ');
            passwordOld = new EncodeHVT.EncryptHVClass().MD8PWD(ref passwordOld);

            passwordNew = passwordNew.ToUpper();
            if (passwordNew.Length < 10)
                passwordNew = passwordNew.PadRight(10, ' ');
            passwordNew = new EncodeHVT.EncryptHVClass().MD8PWD(ref passwordNew);

            user = user.ToUpper();

            //get userinfo, check password and update password 
            
            UsersInfo ui = GetByColumnsTop1(conn,
               "UserName", user,
               "UserPassword", passwordOld);

            if (ui != null && ui.UserName == user && ui.UserPassword == passwordOld && ui.Deleted == 0)
            {
                //string sqlCmd = string.Format("UPDATE USERS SET PASSWORD = '{0}' WHERE USER_ID = {1}", passwordNew, ui.UserId);
                //SQLHelper.ExecCmdNonQuery(sqlCmd, conn);
                ui.UserPassword = passwordNew;
                Update(conn, ui);
                return true;
            }
            return false;
        }


        public static int Insert(SqlConnection conn, UsersInfo objBO)
        {
            SqlCommand comm = new SqlCommand("USERS_Insert", conn);
            comm.CommandType = CommandType.StoredProcedure;
            SqlParameter param;

            param = new SqlParameter();
            param.ParameterName = "@UserName";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = objBO.UserName.ToUpper().Trim();
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            string UserPassword = objBO.UserPassword.ToUpper().Trim();
            UserPassword = new EncodeHVT.EncryptHVClass().MD8PWD(ref UserPassword);
            param = new SqlParameter();
            param.ParameterName = "@UserPassword";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value =UserPassword;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@Deleted";
            param.SqlDbType = SqlDbType.Int;
            param.Value = objBO.Deleted;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@EmployeeId";
            param.SqlDbType = SqlDbType.Int;
            param.Value = objBO.EmployeeId;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            return (int)comm.ExecuteScalar();
        }

        public static void Update(SqlConnection conn, UsersInfo objBO)
        {
            SqlCommand comm = new SqlCommand("USERS_Update", conn);
            comm.CommandType = CommandType.StoredProcedure;
            SqlParameter param;

            param = new SqlParameter();
            param.ParameterName = "@UserId";
            param.SqlDbType = SqlDbType.Int;
            param.Value = objBO.UserId;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@UserName";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = objBO.UserName.ToUpper().Trim();
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            string UserPassword = objBO.UserPassword.ToUpper().Trim();
            UserPassword = new EncodeHVT.EncryptHVClass().MD8PWD(ref UserPassword);
            param = new SqlParameter();
            param.ParameterName = "@UserPassword";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = UserPassword;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@Deleted";
            param.SqlDbType = SqlDbType.Int;
            param.Value = objBO.Deleted;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@EmployeeId";
            param.SqlDbType = SqlDbType.Int;
            param.Value = objBO.EmployeeId;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            comm.ExecuteNonQuery();
        }

        public static void Delete(SqlConnection conn, int id)
        {
            SqlCommand comm = new SqlCommand("USERS_Delete", conn);
            comm.CommandType = CommandType.StoredProcedure;

            SqlParameter param = new SqlParameter();
            param.ParameterName = "@UserId";
            param.SqlDbType = SqlDbType.Int;
            param.Value = id;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            comm.ExecuteNonQuery();
        }
    }
}
