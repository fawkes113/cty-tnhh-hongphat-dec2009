using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace HongPhat.Entities
{
    #region ORDER_DETAILS
    /// <summary>
    /// This object represents the properties and methods of a ORDER_DETAILS.
    /// </summary>
    public class ORDER_DETAILS
    {
        private int _id;
        private int _orderId;
        private int _itemId;
        private decimal _quantity;
        private int _idPrice;
        private string _createBy = String.Empty;
        private DateTime _createDate;
        private string _modifiedBy = String.Empty;
        private DateTime _modifiedDate;
        private int _deleted;
        private string _note = String.Empty;

        public ORDER_DETAILS()
        {
        }

        public ORDER_DETAILS(int id)
        {
            SqlService sql = new SqlService();
            sql.AddParameter("@OrderDetailId", SqlDbType.Int, id);
            SqlDataReader reader = sql.ExecuteSqlReader("SELECT * FROM ORDER_DETAILS WHERE OrderDetailId = @OrderDetailId");

            if (reader.Read())
            {
                this.LoadFromReader(reader);
                reader.Close();
            }
            else
            {
                if (!reader.IsClosed) reader.Close();
                throw new ApplicationException("ORDER_DETAILS does not exist.");
            }
        }

        public ORDER_DETAILS(SqlDataReader reader)
        {
            this.LoadFromReader(reader);
        }

        protected void LoadFromReader(SqlDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                _id = reader.GetInt32(0);
                if (!reader.IsDBNull(1)) _orderId = reader.GetInt32(1);
                if (!reader.IsDBNull(2)) _itemId = reader.GetInt32(2);
                if (!reader.IsDBNull(3)) _quantity = reader.GetDecimal(3);
                if (!reader.IsDBNull(4)) _idPrice = reader.GetInt32(4);
                if (!reader.IsDBNull(5)) _createBy = reader.GetString(5);
                if (!reader.IsDBNull(6)) _createDate = reader.GetDateTime(6);
                if (!reader.IsDBNull(7)) _modifiedBy = reader.GetString(7);
                if (!reader.IsDBNull(8)) _modifiedDate = reader.GetDateTime(8);
                if (!reader.IsDBNull(9)) _deleted = reader.GetInt32(9);
                if (!reader.IsDBNull(10)) _note = reader.GetString(10);
            }
        }

        public void Delete()
        {
            ORDER_DETAILS.Delete(_id);
        }

        public void Update()
        {
            SqlService sql = new SqlService();
            StringBuilder queryParameters = new StringBuilder();

            sql.AddParameter("@OrderDetailId", SqlDbType.Int, Id);
            queryParameters.Append("OrderDetailId = @OrderDetailId");

            sql.AddParameter("@OrderId", SqlDbType.Int, OrderId);
            queryParameters.Append(", OrderId = @OrderId");
            sql.AddParameter("@ItemId", SqlDbType.Int, ItemId);
            queryParameters.Append(", ItemId = @ItemId");
            sql.AddParameter("@Quantity", SqlDbType.Decimal, Quantity);
            queryParameters.Append(", Quantity = @Quantity");
            sql.AddParameter("@IdPrice", SqlDbType.Int, IdPrice);
            queryParameters.Append(", IdPrice = @IdPrice");
            sql.AddParameter("@CreateBy", SqlDbType.NVarChar, CreateBy);
            queryParameters.Append(", CreateBy = @CreateBy");
            sql.AddParameter("@CreateDate", SqlDbType.DateTime, CreateDate);
            queryParameters.Append(", CreateDate = @CreateDate");
            sql.AddParameter("@ModifiedBy", SqlDbType.NVarChar, ModifiedBy);
            queryParameters.Append(", ModifiedBy = @ModifiedBy");
            sql.AddParameter("@ModifiedDate", SqlDbType.DateTime, ModifiedDate);
            queryParameters.Append(", ModifiedDate = @ModifiedDate");
            sql.AddParameter("@Deleted", SqlDbType.Int, Deleted);
            queryParameters.Append(", Deleted = @Deleted");
            sql.AddParameter("@Note", SqlDbType.Text, Note);
            queryParameters.Append(", Note = @Note");

            string query = String.Format("Update ORDER_DETAILS Set {0} Where OrderDetailId = @OrderDetailId", queryParameters.ToString());
            SqlDataReader reader = sql.ExecuteSqlReader(query);
        }

        public void Create()
        {
            SqlService sql = new SqlService();
            StringBuilder queryParameters = new StringBuilder();

            sql.AddParameter("@OrderDetailId", SqlDbType.Int, Id);
            queryParameters.Append("@OrderDetailId");

            sql.AddParameter("@OrderId", SqlDbType.Int, OrderId);
            queryParameters.Append(", @OrderId");
            sql.AddParameter("@ItemId", SqlDbType.Int, ItemId);
            queryParameters.Append(", @ItemId");
            sql.AddParameter("@Quantity", SqlDbType.Decimal, Quantity);
            queryParameters.Append(", @Quantity");
            sql.AddParameter("@IdPrice", SqlDbType.Int, IdPrice);
            queryParameters.Append(", @IdPrice");
            sql.AddParameter("@CreateBy", SqlDbType.NVarChar, CreateBy);
            queryParameters.Append(", @CreateBy");
            sql.AddParameter("@CreateDate", SqlDbType.DateTime, CreateDate);
            queryParameters.Append(", @CreateDate");
            sql.AddParameter("@ModifiedBy", SqlDbType.NVarChar, ModifiedBy);
            queryParameters.Append(", @ModifiedBy");
            sql.AddParameter("@ModifiedDate", SqlDbType.DateTime, ModifiedDate);
            queryParameters.Append(", @ModifiedDate");
            sql.AddParameter("@Deleted", SqlDbType.Int, Deleted);
            queryParameters.Append(", @Deleted");
            sql.AddParameter("@Note", SqlDbType.Text, Note);
            queryParameters.Append(", @Note");

            string query = String.Format("Insert Into ORDER_DETAILS ({0}) Values ({1})", queryParameters.ToString().Replace("@", ""), queryParameters.ToString());
            SqlDataReader reader = sql.ExecuteSqlReader(query);
        }

        public static ORDER_DETAILS NewORDER_DETAILS(int id)
        {
            ORDER_DETAILS newEntity = new ORDER_DETAILS();
            newEntity._id = id;

            return newEntity;
        }

        #region Public Properties
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int OrderId
        {
            get { return _orderId; }
            set { _orderId = value; }
        }

        public int ItemId
        {
            get { return _itemId; }
            set { _itemId = value; }
        }

        public decimal Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        public int IdPrice
        {
            get { return _idPrice; }
            set { _idPrice = value; }
        }

        public string CreateBy
        {
            get { return _createBy; }
            set { _createBy = value; }
        }

        public DateTime CreateDate
        {
            get { return _createDate; }
            set { _createDate = value; }
        }

        public string ModifiedBy
        {
            get { return _modifiedBy; }
            set { _modifiedBy = value; }
        }

        public DateTime ModifiedDate
        {
            get { return _modifiedDate; }
            set { _modifiedDate = value; }
        }

        public int Deleted
        {
            get { return _deleted; }
            set { _deleted = value; }
        }

        public string Note
        {
            get { return _note; }
            set { _note = value; }
        }
        #endregion

        public static ORDER_DETAILS GetORDER_DETAILS(int id)
        {
            return new ORDER_DETAILS(id);
        }

        public static void Delete(int id)
        {
            SqlService sql = new SqlService();
            sql.AddParameter("@OrderDetailId", SqlDbType.Int, id);

            SqlDataReader reader = sql.ExecuteSqlReader("Delete ORDER_DETAILS Where OrderDetailId = @OrderDetailId");
        }
    }
    #endregion
}

