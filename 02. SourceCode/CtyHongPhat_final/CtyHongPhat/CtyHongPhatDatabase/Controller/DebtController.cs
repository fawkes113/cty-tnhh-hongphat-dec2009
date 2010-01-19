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
    public class DebtController
    {
        public static ArrayList GetAll(SqlConnection conn)
        {
            string sqlCmd = "SELECT * FROM DEBT WHERE DELETED = 0";
            SqlCommand comm = new SqlCommand(sqlCmd, conn);
            return CBO.FillCollection(comm.ExecuteReader(), typeof(DebtInfo));
        }
        public static ArrayList GetAllHaveOrderBy(SqlConnection conn, string OrderColumn, string OrderType)
        {
            string sqlCmd = "SELECT * FROM DEBT WHERE DELETED = 0 ORDER BY " + OrderColumn + " " + OrderType;
            SqlCommand comm = new SqlCommand(sqlCmd, conn);
            return CBO.FillCollection(comm.ExecuteReader(), typeof(DebtInfo));
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
            string sqlCmd = "SELECT * FROM DEBT WHERE " + sqlWhere + " AND DELETED = 0";

            SqlCommand comm = new SqlCommand(sqlWhere, conn);
            return CBO.FillCollection(comm.ExecuteReader(), typeof(DebtInfo));
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
            string sqlCmd = "SELECT * FROM DEBT WHERE " + sqlWhere + " AND DELETED = 0" + " ORDER BY " + orderColumn + " " + orderType;

            SqlCommand comm = new SqlCommand(sqlWhere, conn);
            return CBO.FillCollection(comm.ExecuteReader(), typeof(DebtInfo));
        }
        public static DebtInfo GetByColumnTop1(SqlConnection conn, string columnName, object columnValue)
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
            string sqlCmd = "SELECT top 1 * FROM DEBT WHERE " + sqlWhere + " AND DELETED = 0";

            SqlCommand comm = new SqlCommand(sqlWhere, conn);
            return (DebtInfo)CBO.FillObject(comm.ExecuteReader(), typeof(DebtInfo));
        }
        public static DebtInfo GetByColumnsTop1(SqlConnection conn, params object[] columns)
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
            string sqlCmd = "SELECT top 1 * FROM DEBT WHERE " + sqlWhere + " AND DELETED = 0";

            SqlCommand comm = new SqlCommand(sqlWhere, conn);
            return (DebtInfo)CBO.FillObject(comm.ExecuteReader(), typeof(DebtInfo));
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
            string sqlCmd = "SELECT * FROM DEBT WHERE " + sqlWhere + " AND DELETED = 0";

            SqlCommand comm = new SqlCommand(sqlWhere, conn);
            return CBO.FillCollection(comm.ExecuteReader(), typeof(DebtInfo));
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
            string sqlCmd = "DELETE DEBT WHERE " + sqlWhere + " AND DELETED = 0";

            SqlCommand comm = new SqlCommand(sqlWhere, conn);
            comm.ExecuteNonQuery();
        }
        public static int Insert(SqlConnection conn, DebtInfo objBO)
        {
            SqlCommand comm = new SqlCommand("DEBT_Insert", conn);
            comm.CommandType = CommandType.StoredProcedure;
            SqlParameter param;

            param = new SqlParameter();
            param.ParameterName = "@OldDebtValue";
            param.SqlDbType = SqlDbType.Decimal;
            param.Value = objBO.OldDebtValue;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@NewDebtValue";
            param.SqlDbType = SqlDbType.Decimal;
            param.Value = objBO.NewDebtValue;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@Payment";
            param.SqlDbType = SqlDbType.Decimal;
            param.Value = objBO.Payment;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@CurrentDebtValue";
            param.SqlDbType = SqlDbType.Decimal;
            param.Value = objBO.CurrentDebtValue;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@CustomerId";
            param.SqlDbType = SqlDbType.Int;
            param.Value = objBO.CustomerId;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@Deleted";
            param.SqlDbType = SqlDbType.Int;
            param.Value = objBO.Deleted;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@CreatedBy";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = objBO.CreatedBy;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@CreateDate";
            param.SqlDbType = SqlDbType.DateTime;
            param.Value = objBO.CreateDate;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@ModifiedBy";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = objBO.ModifiedBy;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@ModifiedDate";
            param.SqlDbType = SqlDbType.DateTime;
            param.Value = objBO.ModifiedDate;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@DebtKind";
            param.SqlDbType = SqlDbType.Int;
            param.Value = objBO.DebtKind;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@Note";
            param.SqlDbType = SqlDbType.Text;
            param.Value = objBO.Note;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            return (int)comm.ExecuteScalar();
        }

        public static void Update(SqlConnection conn, DebtInfo objBO)
        {
            SqlCommand comm = new SqlCommand("DEBT_Update", conn);
            comm.CommandType = CommandType.StoredProcedure;
            SqlParameter param;

            param = new SqlParameter();
            param.ParameterName = "@DebtId";
            param.SqlDbType = SqlDbType.Int;
            param.Value = objBO.DebtId;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@OldDebtValue";
            param.SqlDbType = SqlDbType.Decimal;
            param.Value = objBO.OldDebtValue;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@NewDebtValue";
            param.SqlDbType = SqlDbType.Decimal;
            param.Value = objBO.NewDebtValue;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@Payment";
            param.SqlDbType = SqlDbType.Decimal;
            param.Value = objBO.Payment;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@CurrentDebtValue";
            param.SqlDbType = SqlDbType.Decimal;
            param.Value = objBO.CurrentDebtValue;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@CustomerId";
            param.SqlDbType = SqlDbType.Int;
            param.Value = objBO.CustomerId;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@Deleted";
            param.SqlDbType = SqlDbType.Int;
            param.Value = objBO.Deleted;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@CreatedBy";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = objBO.CreatedBy;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@CreateDate";
            param.SqlDbType = SqlDbType.DateTime;
            param.Value = objBO.CreateDate;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@ModifiedBy";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = objBO.ModifiedBy;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@ModifiedDate";
            param.SqlDbType = SqlDbType.DateTime;
            param.Value = objBO.ModifiedDate;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@DebtKind";
            param.SqlDbType = SqlDbType.Int;
            param.Value = objBO.DebtKind;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@Note";
            param.SqlDbType = SqlDbType.Text;
            param.Value = objBO.Note;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            comm.ExecuteNonQuery();
        }

        public static void Delete(SqlConnection conn, int id)
        {
            SqlCommand comm = new SqlCommand("DEBT_Delete", conn);
            comm.CommandType = CommandType.StoredProcedure;

            SqlParameter param = new SqlParameter();
            param.ParameterName = "@DebtId";
            param.SqlDbType = SqlDbType.Int;
            param.Value = id;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            comm.ExecuteNonQuery();
        }
    }
}
