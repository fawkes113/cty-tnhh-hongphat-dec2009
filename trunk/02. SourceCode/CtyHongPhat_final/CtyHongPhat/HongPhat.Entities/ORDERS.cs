using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace HongPhat.Entities
{
    #region ORDERS
    /// <summary>
    /// This object represents the properties and methods of a ORDERS.
    /// </summary>
    public class ORDERS
    {
        private int _id;
        private int _orderKind;
        private int _customerId;
        private string _createdBy = String.Empty;
        private DateTime _createdDate;
        private string _modifiedBy = String.Empty;
        private DateTime _modifiedDate;
        private decimal _total;
        private decimal _pay;
        private int _status;
        private string _note = String.Empty;

        public ORDERS()
        {
        }

        public ORDERS(int id)
        {
            SqlService sql = new SqlService();
            sql.AddParameter("@OrderId", SqlDbType.Int, id);
            SqlDataReader reader = sql.ExecuteSqlReader("SELECT * FROM ORDERS WHERE OrderId = @OrderId");

            if (reader.Read())
            {
                this.LoadFromReader(reader);
                reader.Close();
            }
            else
            {
                if (!reader.IsClosed) reader.Close();
                throw new ApplicationException("ORDERS does not exist.");
            }
        }

        public ORDERS(SqlDataReader reader)
        {
            this.LoadFromReader(reader);
        }

        protected void LoadFromReader(SqlDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                _id = reader.GetInt32(0);
                if (!reader.IsDBNull(1)) _orderKind = reader.GetInt32(1);
                if (!reader.IsDBNull(2)) _customerId = reader.GetInt32(2);
                if (!reader.IsDBNull(3)) _createdBy = reader.GetString(3);
                if (!reader.IsDBNull(4)) _createdDate = reader.GetDateTime(4);
                if (!reader.IsDBNull(5)) _modifiedBy = reader.GetString(5);
                if (!reader.IsDBNull(6)) _modifiedDate = reader.GetDateTime(6);
                if (!reader.IsDBNull(7)) _total = reader.GetDecimal(7);
                if (!reader.IsDBNull(8)) _pay = reader.GetDecimal(8);
                if (!reader.IsDBNull(9)) _status = reader.GetInt32(9);
                if (!reader.IsDBNull(10)) _note = reader.GetString(10);
            }
        }

        public void Delete()
        {
            ORDERS.Delete(_id);
        }

        public void Update()
        {
            SqlService sql = new SqlService();
            StringBuilder queryParameters = new StringBuilder();

            sql.AddParameter("@OrderId", SqlDbType.Int, Id);
            queryParameters.Append("OrderId = @OrderId");

            sql.AddParameter("@OrderKind", SqlDbType.Int, OrderKind);
            queryParameters.Append(", OrderKind = @OrderKind");
            sql.AddParameter("@CustomerId", SqlDbType.Int, CustomerId);
            queryParameters.Append(", CustomerId = @CustomerId");
            sql.AddParameter("@CreatedBy", SqlDbType.NVarChar, CreatedBy);
            queryParameters.Append(", CreatedBy = @CreatedBy");
            sql.AddParameter("@CreatedDate", SqlDbType.DateTime, CreatedDate);
            queryParameters.Append(", CreatedDate = @CreatedDate");
            sql.AddParameter("@ModifiedBy", SqlDbType.NVarChar, ModifiedBy);
            queryParameters.Append(", ModifiedBy = @ModifiedBy");
            sql.AddParameter("@ModifiedDate", SqlDbType.DateTime, ModifiedDate);
            queryParameters.Append(", ModifiedDate = @ModifiedDate");
            sql.AddParameter("@Total", SqlDbType.Decimal, Total);
            queryParameters.Append(", Total = @Total");
            sql.AddParameter("@Pay", SqlDbType.Decimal, Pay);
            queryParameters.Append(", Pay = @Pay");
            sql.AddParameter("@Status", SqlDbType.Int, Status);
            queryParameters.Append(", Status = @Status");
            sql.AddParameter("@Note", SqlDbType.Text, Note);
            queryParameters.Append(", Note = @Note");

            string query = String.Format("Update ORDERS Set {0} Where OrderId = @OrderId", queryParameters.ToString());
            SqlDataReader reader = sql.ExecuteSqlReader(query);
        }

        public void Create()
        {
            SqlService sql = new SqlService();
            StringBuilder queryParameters = new StringBuilder();

            sql.AddParameter("@OrderId", SqlDbType.Int, Id);
            queryParameters.Append("@OrderId");

            sql.AddParameter("@OrderKind", SqlDbType.Int, OrderKind);
            queryParameters.Append(", @OrderKind");
            sql.AddParameter("@CustomerId", SqlDbType.Int, CustomerId);
            queryParameters.Append(", @CustomerId");
            sql.AddParameter("@CreatedBy", SqlDbType.NVarChar, CreatedBy);
            queryParameters.Append(", @CreatedBy");
            sql.AddParameter("@CreatedDate", SqlDbType.DateTime, CreatedDate);
            queryParameters.Append(", @CreatedDate");
            sql.AddParameter("@ModifiedBy", SqlDbType.NVarChar, ModifiedBy);
            queryParameters.Append(", @ModifiedBy");
            sql.AddParameter("@ModifiedDate", SqlDbType.DateTime, ModifiedDate);
            queryParameters.Append(", @ModifiedDate");
            sql.AddParameter("@Total", SqlDbType.Decimal, Total);
            queryParameters.Append(", @Total");
            sql.AddParameter("@Pay", SqlDbType.Decimal, Pay);
            queryParameters.Append(", @Pay");
            sql.AddParameter("@Status", SqlDbType.Int, Status);
            queryParameters.Append(", @Status");
            sql.AddParameter("@Note", SqlDbType.Text, Note);
            queryParameters.Append(", @Note");

            string query = String.Format("Insert Into ORDERS ({0}) Values ({1})", queryParameters.ToString().Replace("@", ""), queryParameters.ToString());
            SqlDataReader reader = sql.ExecuteSqlReader(query);
        }

        public static ORDERS NewORDERS(int id)
        {
            ORDERS newEntity = new ORDERS();
            newEntity._id = id;

            return newEntity;
        }

        #region Public Properties
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int OrderKind
        {
            get { return _orderKind; }
            set { _orderKind = value; }
        }

        public int CustomerId
        {
            get { return _customerId; }
            set { _customerId = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public DateTime CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
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

        public decimal Total
        {
            get { return _total; }
            set { _total = value; }
        }

        public decimal Pay
        {
            get { return _pay; }
            set { _pay = value; }
        }

        public int Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public string Note
        {
            get { return _note; }
            set { _note = value; }
        }
        #endregion

        public static ORDERS GetORDERS(int id)
        {
            return new ORDERS(id);
        }

        public static void Delete(int id)
        {
            SqlService sql = new SqlService();
            sql.AddParameter("@OrderId", SqlDbType.Int, id);

            SqlDataReader reader = sql.ExecuteSqlReader("Delete ORDERS Where OrderId = @OrderId");
        }
    }
    #endregion
}

