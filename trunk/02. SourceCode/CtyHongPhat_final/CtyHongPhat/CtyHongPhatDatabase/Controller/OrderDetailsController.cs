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
    public class OrderDetailsController
    {
        public static ArrayList GetAll(SqlConnection conn)
        {
            string sqlCmd = "SELECT * FROM ORDER_DETAILS WHERE DELETED = 0";
            conn.Open();
            SqlCommand comm = new SqlCommand(sqlCmd, conn);
            return CBO.FillCollection(comm.ExecuteReader(), typeof(OrderDetailsInfo));
        }
        public static ArrayList GetAllHaveOrderBy(SqlConnection conn, string OrderColumn, string OrderType)
        {
            string sqlCmd = "SELECT * FROM ORDER_DETAILS WHERE DELETED = 0 ORDER BY " + OrderColumn + " " + OrderType;
            SqlCommand comm = new SqlCommand(sqlCmd, conn);
            return CBO.FillCollection(comm.ExecuteReader(), typeof(OrderDetailsInfo));
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
            string sqlCmd = "SELECT * FROM ORDER_DETAILS WHERE " + sqlWhere + " AND DELETED = 0";

            conn.Open();
            SqlCommand comm = new SqlCommand(sqlCmd,conn);
            return CBO.FillCollection(comm.ExecuteReader(), typeof(OrderDetailsInfo));
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
            string sqlCmd = "SELECT * FROM ORDER_DETAILS WHERE " + sqlWhere + " AND DELETED = 0" + " ORDER BY " + orderColumn + " " + orderType;

            conn.Open();
            SqlCommand comm = new SqlCommand(sqlCmd,conn);
            return CBO.FillCollection(comm.ExecuteReader(), typeof(OrderDetailsInfo));
        }
        public static OrderDetailsInfo GetByColumnTop1(SqlConnection conn, string columnName, object columnValue)
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
            string sqlCmd = "SELECT top 1 * FROM ORDER_DETAILS WHERE " + sqlWhere + " AND DELETED = 0";

            conn.Open();
            SqlCommand comm = new SqlCommand(sqlCmd,conn);
            return (OrderDetailsInfo)CBO.FillObject(comm.ExecuteReader(), typeof(OrderDetailsInfo));
        }
        public static OrderDetailsInfo GetByColumnsTop1(SqlConnection conn, params object[] columns)
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
            string sqlCmd = "SELECT top 1 * FROM ORDER_DETAILS WHERE " + sqlWhere + " AND DELETED = 0";

            conn.Open();
            SqlCommand comm = new SqlCommand(sqlCmd,conn);
            return (OrderDetailsInfo)CBO.FillObject(comm.ExecuteReader(), typeof(OrderDetailsInfo));
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
            string sqlCmd = "SELECT * FROM ORDER_DETAILS WHERE " + sqlWhere + " AND DELETED = 0";

            conn.Open();
            SqlCommand comm = new SqlCommand(sqlCmd,conn);
            return CBO.FillCollection(comm.ExecuteReader(), typeof(OrderDetailsInfo));
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
            string sqlCmd = "DELETE ORDER_DETAILS WHERE " + sqlWhere + " AND DELETED = 0";

            conn.Open();
            SqlCommand comm = new SqlCommand(sqlCmd,conn);
            comm.ExecuteNonQuery();
        }


        public static int Insert(SqlConnection conn, OrderDetailsInfo objBO)
        {
            conn.Open();
            SqlCommand comm = new SqlCommand("ORDER_DETAILS_Insert", conn);
            comm.CommandType = CommandType.StoredProcedure;
            SqlParameter param;

            param = new SqlParameter();
            param.ParameterName = "@OrderId";
            param.SqlDbType = SqlDbType.Int;
            param.Value = objBO.OrderId;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@ItemId";
            param.SqlDbType = SqlDbType.Int;
            param.Value = objBO.ItemId;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@Quantity";
            param.SqlDbType = SqlDbType.Decimal;
            param.Value = objBO.Quantity;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@IdPrice";
            param.SqlDbType = SqlDbType.Int;
            param.Value = objBO.IdPrice;
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
            param.SqlDbType = SqlDbType.NVarChar;
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
            param.ParameterName = "@Note";
            param.SqlDbType = SqlDbType.Text;
            param.Value = objBO.Note;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            object id = comm.ExecuteScalar();
            return int.Parse(id.ToString());
        }

        public static void Update(SqlConnection conn, OrderDetailsInfo objBO)
        {
            conn.Open();
            SqlCommand comm = new SqlCommand("ORDER_DETAILS_Update", conn);
            comm.CommandType = CommandType.StoredProcedure;
            SqlParameter param;

            param = new SqlParameter();
            param.ParameterName = "@OrderDetailId";
            param.SqlDbType = SqlDbType.Int;
            param.Value = objBO.OrderDetailId;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@OrderId";
            param.SqlDbType = SqlDbType.Int;
            param.Value = objBO.OrderId;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@ItemId";
            param.SqlDbType = SqlDbType.Int;
            param.Value = objBO.ItemId;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@Quantity";
            param.SqlDbType = SqlDbType.Decimal;
            param.Value = objBO.Quantity;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@IdPrice";
            param.SqlDbType = SqlDbType.Int;
            param.Value = objBO.IdPrice;
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
            param.SqlDbType = SqlDbType.NVarChar;
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
            param.ParameterName = "@Note";
            param.SqlDbType = SqlDbType.Text;
            param.Value = objBO.Note;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            comm.ExecuteNonQuery();
        }

        public static void Delete(SqlConnection conn, int id)
        {
            conn.Open();
            SqlCommand comm = new SqlCommand("ORDER_DETAILS_Delete", conn);
            comm.CommandType = CommandType.StoredProcedure;

            SqlParameter param = new SqlParameter();
            param.ParameterName = "@OrderDetailId";
            param.SqlDbType = SqlDbType.Int;
            param.Value = id;
            param.Direction = ParameterDirection.Input;
            comm.Parameters.Add(param);

            comm.ExecuteNonQuery();
        }
    }
}
