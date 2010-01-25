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
    public class ReturnedItemDetialsController
    {
        public static ArrayList GetAll(SqlConnection conn)
        {
            string sqlCmd = "SELECT * FROM RETURNED_ITEM_DETAILS WHERE DELETED = 0";
            conn.Open();
            SqlCommand comm = new SqlCommand(sqlCmd, conn);
            return CBO.FillCollection(comm.ExecuteReader(), typeof(ReturnedItemDetailsInfo));
        }
        public static ArrayList GetAllHaveOrderBy(SqlConnection conn, string OrderColumn, string OrderType)
        {
            string sqlCmd = "SELECT * FROM RETURNED_ITEM_DETAILS WHERE DELETED = 0 ORDER BY " + OrderColumn + " " + OrderType;
            SqlCommand comm = new SqlCommand(sqlCmd, conn);
            return CBO.FillCollection(comm.ExecuteReader(), typeof(ReturnedItemDetailsInfo));
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
            string sqlCmd = "SELECT * FROM RETURNED_ITEM_DETAILS WHERE " + sqlWhere + " AND DELETED = 0";

            conn.Open();
            SqlCommand comm = new SqlCommand(sqlCmd,conn);
            return CBO.FillCollection(comm.ExecuteReader(), typeof(ReturnedItemDetailsInfo));
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
            string sqlCmd = "SELECT * FROM RETURNED_ITEM_DETAILS WHERE " + sqlWhere + " AND DELETED = 0" + " ORDER BY " + orderColumn + " " + orderType;

            conn.Open();
            SqlCommand comm = new SqlCommand(sqlCmd,conn);
            return CBO.FillCollection(comm.ExecuteReader(), typeof(ReturnedItemDetailsInfo));
        }
        public static ReturnedItemDetailsInfo GetByColumnTop1(SqlConnection conn, string columnName, object columnValue)
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
            string sqlCmd = "SELECT top 1 * FROM RETURNED_ITEM_DETAILS WHERE " + sqlWhere + " AND DELETED = 0";

            conn.Open();
            SqlCommand comm = new SqlCommand(sqlCmd,conn);
            return (ReturnedItemDetailsInfo)CBO.FillObject(comm.ExecuteReader(), typeof(ReturnedItemDetailsInfo));
        }
        public static ReturnedItemDetailsInfo GetByColumnsTop1(SqlConnection conn, params object[] columns)
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
            string sqlCmd = "SELECT top 1 * FROM RETURNED_ITEM_DETAILS WHERE " + sqlWhere + " AND DELETED = 0";

            conn.Open();
            SqlCommand comm = new SqlCommand(sqlCmd,conn);
            return (ReturnedItemDetailsInfo)CBO.FillObject(comm.ExecuteReader(), typeof(ReturnedItemDetailsInfo));
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
            string sqlCmd = "SELECT * FROM RETURNED_ITEM_DETAILS WHERE " + sqlWhere + " AND DELETED = 0";

            conn.Open();
            SqlCommand comm = new SqlCommand(sqlCmd,conn);
            return CBO.FillCollection(comm.ExecuteReader(), typeof(ReturnedItemDetailsInfo));
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
            string sqlCmd = "DELETE RETURNED_ITEM_DETAILS WHERE " + sqlWhere + " AND DELETED = 0";

            conn.Open();
            SqlCommand comm = new SqlCommand(sqlCmd,conn);
            comm.ExecuteNonQuery();
        }


        public static int Insert(SqlConnection conn, ReturnedItemDetailsInfo objBO)
        {
            conn.Open();
            SqlCommand comm = new SqlCommand("RETURNED_ITEM_DETAILS_Insert", conn);
            comm.CommandType = CommandType.StoredProcedure;
            SqlParameter param;

            param = new SqlParameter();
            param.ParameterName = "@OrderDetailId";
            param.SqlDbType = SqlDbType.Int;
            param.Value = objBO.OrderDetailId;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@Quantity";
            param.SqlDbType = SqlDbType.Decimal;
            param.Value = objBO.Quantity;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@ReturnDate";
            param.SqlDbType = SqlDbType.DateTime;
            param.Value = objBO.ReturnDate;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@Note";
            param.SqlDbType = SqlDbType.Text;
            param.Value = objBO.Note;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@Deleted";
            param.SqlDbType = SqlDbType.Int;
            param.Value = objBO.Deleted;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            return int.Parse(comm.ExecuteScalar().ToString());
        }

        public static void Update(SqlConnection conn, ReturnedItemDetailsInfo objBO)
        {
            conn.Open();
            SqlCommand comm = new SqlCommand("RETURNED_ITEM_DETAILS_Update", conn);
            comm.CommandType = CommandType.StoredProcedure;
            SqlParameter param;

            param = new SqlParameter();
            param.ParameterName = "@ReturnedItemDetailsId";
            param.SqlDbType = SqlDbType.Int;
            param.Value = objBO.ReturnedItemDetailsId;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@OrderDetailId";
            param.SqlDbType = SqlDbType.Int;
            param.Value = objBO.OrderDetailId;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@Quantity";
            param.SqlDbType = SqlDbType.Decimal;
            param.Value = objBO.Quantity;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@ReturnDate";
            param.SqlDbType = SqlDbType.DateTime;
            param.Value = objBO.ReturnDate;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@Note";
            param.SqlDbType = SqlDbType.Text;
            param.Value = objBO.Note;
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
            SqlCommand comm = new SqlCommand("RETURNED_ITEM_DETAILS_Delete", conn);
            comm.CommandType = CommandType.StoredProcedure;

            SqlParameter param = new SqlParameter();
            param.ParameterName = "@ReturnedItemDetailsId";
            param.SqlDbType = SqlDbType.Int;
            param.Value = id;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            comm.ExecuteNonQuery();
        }
    }
}
