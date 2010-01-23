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
    public class EmployeesController
    {
        public static ArrayList GetAll(SqlConnection conn)
        {
            string sqlCmd = "SELECT * FROM EMPLOYEES WHERE DELETED = 0";
            conn.Open();
            SqlCommand comm = new SqlCommand(sqlCmd, conn);
            return CBO.FillCollection(comm.ExecuteReader(), typeof(EmployeesInfo));
        }
        public static ArrayList GetAllHaveOrderBy(SqlConnection conn, string OrderColumn, string OrderType)
        {
            string sqlCmd = "SELECT * FROM EMPLOYEES WHERE DELETED = 0 ORDER BY " + OrderColumn + " " + OrderType;
            conn.Open();
            SqlCommand comm = new SqlCommand(sqlCmd, conn);
            return CBO.FillCollection(comm.ExecuteReader(), typeof(EmployeesInfo));
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
            string sqlCmd = "SELECT * FROM EMPLOYEES WHERE " + sqlWhere + " AND DELETED = 0";

            conn.Open();
            SqlCommand comm = new SqlCommand(sqlCmd,conn);
            return CBO.FillCollection(comm.ExecuteReader(), typeof(EmployeesInfo));
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
            string sqlCmd = "SELECT * FROM EMPLOYEES WHERE " + sqlWhere + " AND DELETED = 0" + " ORDER BY " + orderColumn + " " + orderType;

            conn.Open();
            SqlCommand comm = new SqlCommand(sqlCmd,conn);
            return CBO.FillCollection(comm.ExecuteReader(), typeof(EmployeesInfo));
        }
        public static EmployeesInfo GetByColumnTop1(SqlConnection conn, string columnName, object columnValue)
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
            string sqlCmd = "SELECT top 1 * FROM EMPLOYEES WHERE " + sqlWhere + " AND DELETED = 0";

            conn.Open();
            SqlCommand comm = new SqlCommand(sqlCmd,conn);
            return (EmployeesInfo)CBO.FillObject(comm.ExecuteReader(), typeof(EmployeesInfo));
        }
        public static EmployeesInfo GetByColumnsTop1(SqlConnection conn, params object[] columns)
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
            string sqlCmd = "SELECT top 1 * FROM EMPLOYEES WHERE " + sqlWhere + " AND DELETED = 0";

            conn.Open();
            SqlCommand comm = new SqlCommand(sqlCmd,conn);
            return (EmployeesInfo)CBO.FillObject(comm.ExecuteReader(), typeof(EmployeesInfo));
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
            string sqlCmd = "SELECT * FROM EMPLOYEES WHERE " + sqlWhere + " AND DELETED = 0";

            conn.Open();
            SqlCommand comm = new SqlCommand(sqlCmd,conn);
            return CBO.FillCollection(comm.ExecuteReader(), typeof(EmployeesInfo));
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
            string sqlCmd = "DELETE EMPLOYEES WHERE " + sqlWhere + " AND DELETED = 0";

            conn.Open();
            SqlCommand comm = new SqlCommand(sqlCmd,conn);
            comm.ExecuteNonQuery();
        }


        public static int Insert(SqlConnection conn, EmployeesInfo objBO)
        {
            conn.Open();
            SqlCommand comm = new SqlCommand("EMPLOYEES_Insert", conn);
            comm.CommandType = CommandType.StoredProcedure;
            SqlParameter param;

            param = new SqlParameter();
            param.ParameterName = "@EmployeeName";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = objBO.EmployeeName;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@Salary";
            param.SqlDbType = SqlDbType.Decimal;
            param.Value = objBO.Salary;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@Deleted";
            param.SqlDbType = SqlDbType.Int;
            param.Value = objBO.Deleted;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@Position";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = objBO.Position;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            return (int)comm.ExecuteScalar();
        }

        public static void Update(SqlConnection conn, EmployeesInfo objBO)
        {
            conn.Open();
            SqlCommand comm = new SqlCommand("EMPLOYEES_Update", conn);
            comm.CommandType = CommandType.StoredProcedure;
            SqlParameter param;

            param = new SqlParameter();
            param.ParameterName = "@EmployeeId";
            param.SqlDbType = SqlDbType.Int;
            param.Value = objBO.EmployeeId;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@EmployeeName";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = objBO.EmployeeName;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@Salary";
            param.SqlDbType = SqlDbType.Decimal;
            param.Value = objBO.Salary;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@Deleted";
            param.SqlDbType = SqlDbType.Int;
            param.Value = objBO.Deleted;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@Position";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = objBO.Position;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            comm.ExecuteNonQuery();
        }

        public static void Delete(SqlConnection conn, int id)
        {
            conn.Open();
            SqlCommand comm = new SqlCommand("EMPLOYEES_Delete", conn);
            comm.CommandType = CommandType.StoredProcedure;

            SqlParameter param = new SqlParameter();
            param.ParameterName = "@EmployeeId";
            param.SqlDbType = SqlDbType.Int;
            param.Value = id;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            comm.ExecuteNonQuery();
        }
    }
}
