using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using CtyHongPhatDatabase.Table;

namespace CtyHongPhatDatabase.Controller
{
    public class BankDebtController
    {
        public static ArrayList GetAll(SqlConnection conn)
        {
            string sqlCmd = "SELECT * FROM BANK_DEBTS WHERE DELETED = 0 ORDER BY BORROWDATE asc";
            conn.Open();
            SqlCommand comm = new SqlCommand(sqlCmd, conn);
            return CBO.FillCollection(comm.ExecuteReader(), typeof(BankDebtInfo));
        }

        public static ArrayList GetAllNotCondition(SqlConnection conn)
        {
            string sqlCmd = "SELECT * FROM BANK_DEBTS order by deleted asc";
            conn.Open();
            SqlCommand comm = new SqlCommand(sqlCmd, conn);
            return CBO.FillCollection(comm.ExecuteReader(), typeof(BankDebtInfo));
        }

        public static ArrayList GetAllHaveOrderBy(SqlConnection conn, string OrderColumn, string OrderType)
        {
            string sqlCmd = "SELECT * FROM BANK_DEBTS WHERE DELETED = 0 ORDER BY " + OrderColumn + " " + OrderType;
            conn.Open();
            SqlCommand comm = new SqlCommand(sqlCmd, conn);
            return CBO.FillCollection(comm.ExecuteReader(), typeof(BankDebtInfo));
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
            string sqlCmd = "SELECT * FROM BANK_DEBTS WHERE " + sqlWhere + " AND DELETED = 0";

            conn.Open();
            SqlCommand comm = new SqlCommand(sqlCmd, conn);
            return CBO.FillCollection(comm.ExecuteReader(), typeof(BankDebtInfo));
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
            string sqlCmd = "SELECT * FROM BANK_DEBTS WHERE " + sqlWhere + " AND DELETED = 0" + " ORDER BY " + orderColumn + " " + orderType;

            conn.Open();
            SqlCommand comm = new SqlCommand(sqlCmd, conn);
            return CBO.FillCollection(comm.ExecuteReader(), typeof(BankDebtInfo));
        }
        public static BankDebtInfo GetByColumnTop1(SqlConnection conn, string columnName, object columnValue)
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
            string sqlCmd = "SELECT top 1 * FROM BANK_DEBTS WHERE " + sqlWhere;

            conn.Open();
            SqlCommand comm = new SqlCommand(sqlCmd, conn);
            return (BankDebtInfo)CBO.FillObject(comm.ExecuteReader(), typeof(BankDebtInfo));
        }
        public static BankDebtInfo GetByColumnsTop1(SqlConnection conn, params object[] columns)
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
            string sqlCmd = "SELECT top 1 * FROM BANK_DEBTS WHERE " + sqlWhere + " AND DELETED = 0";

            conn.Open();
            SqlCommand comm = new SqlCommand(sqlCmd, conn);
            return (BankDebtInfo)CBO.FillObject(comm.ExecuteReader(), typeof(BankDebtInfo));
        }
        public static ArrayList GetByColumns(SqlConnection conn, params object[] columns)
        {
            if (columns == null || columns.Length <= 0)
                return BankDebtController.GetAll(conn);
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
            string sqlCmd = "SELECT * FROM BANK_DEBTS WHERE " + sqlWhere + " AND DELETED = 0";

            conn.Open();
            SqlCommand comm = new SqlCommand(sqlCmd, conn);
            return CBO.FillCollection(comm.ExecuteReader(), typeof(BankDebtInfo));
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
            string sqlCmd = "DELETE BANK_DEBTS WHERE " + sqlWhere + " AND DELETED = 0";

            conn.Open();
            SqlCommand comm = new SqlCommand(sqlCmd, conn);
            comm.ExecuteNonQuery();
        }

        public static int Insert(SqlConnection conn, BankDebtInfo objBO)
        {
            conn.Open();
            SqlCommand comm = new SqlCommand("BANK_DEBTS_Insert", conn);
            comm.CommandType = CommandType.StoredProcedure;
            SqlParameter param;

            param = new SqlParameter();
            param.ParameterName = "@BankName";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = objBO.BankName;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@BorrowDate";
            param.SqlDbType = SqlDbType.DateTime;
            param.Value = objBO.BorrowDate;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@DebtAmount";
            param.SqlDbType = SqlDbType.Decimal;
            param.Value = objBO.DebtAmount;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@PaidAmount";
            param.SqlDbType = SqlDbType.Decimal;
            param.Value = objBO.PaidAmount;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@MaturityDate";
            param.SqlDbType = SqlDbType.DateTime;
            param.Value = objBO.MaturityDate;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@InterestRate";
            param.SqlDbType = SqlDbType.Decimal;
            param.Value = objBO.InterestRate;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@CreatedBy";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = objBO.CreatedBy;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@CreatedDate";
            param.SqlDbType = SqlDbType.DateTime;
            param.Value = objBO.CreatedDate;
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

            return int.Parse(comm.ExecuteScalar().ToString());
        }
        public static void Update(SqlConnection conn, BankDebtInfo objBO)
        {
            conn.Open();
            SqlCommand comm = new SqlCommand("BANK_DEBTS_Update", conn);
            comm.CommandType = CommandType.StoredProcedure;
            SqlParameter param;

            param = new SqlParameter();
            param.ParameterName = "@BankDebtId";
            param.SqlDbType = SqlDbType.Int;
            param.Value = objBO.BankDebtId;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@BankName";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = objBO.BankName;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@BorrowDate";
            param.SqlDbType = SqlDbType.DateTime;
            param.Value = objBO.BorrowDate;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@DebtAmount";
            param.SqlDbType = SqlDbType.Decimal;
            param.Value = objBO.DebtAmount;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@PaidAmount";
            param.SqlDbType = SqlDbType.Decimal;
            param.Value = objBO.PaidAmount;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@MaturityDate";
            param.SqlDbType = SqlDbType.DateTime;
            param.Value = objBO.MaturityDate;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@InterestRate";
            param.SqlDbType = SqlDbType.Decimal;
            param.Value = objBO.InterestRate;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@CreatedBy";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = objBO.CreatedBy;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@CreatedDate";
            param.SqlDbType = SqlDbType.DateTime;
            param.Value = objBO.CreatedDate;
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
            param.ParameterName = "@Deleted";
            param.SqlDbType = SqlDbType.Int;
            param.Value = objBO.Deleted;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            comm.ExecuteNonQuery();
        }
        public static void Delete(SqlConnection conn, int id)
        {
            conn.Open();
            SqlCommand comm = new SqlCommand("BANK_DEBTS_Delete", conn);
            comm.CommandType = CommandType.StoredProcedure;

            SqlParameter param = new SqlParameter();
            param.ParameterName = "@BankDebtId";
            param.SqlDbType = SqlDbType.Int;
            param.Value = id;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            comm.ExecuteNonQuery();
        }
    }
}

