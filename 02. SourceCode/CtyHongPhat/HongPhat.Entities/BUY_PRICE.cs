using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace HongPhat.Entities
{
    #region BUY_PRICE
    /// <summary>
    /// This object represents the properties and methods of a BUY_PRICE.
    /// </summary>
    public class BUY_PRICE
    {
        private int _id;
        private int _itemId;
        private int _partnerId;
        private decimal _buyPrice;
        private string _createdBy = String.Empty;
        private DateTime _createdDate;
        private string _modifiedBy = String.Empty;
        private DateTime _modifiedDate;
        private int _deleted;

        public BUY_PRICE()
        {
        }

        public BUY_PRICE(int id)
        {
            SqlService sql = new SqlService();
            sql.AddParameter("@Id", SqlDbType.Int, id);
            SqlDataReader reader = sql.ExecuteSqlReader("SELECT * FROM BUY_PRICE WHERE Id = @Id");

            if (reader.Read())
            {
                this.LoadFromReader(reader);
                reader.Close();
            }
            else
            {
                if (!reader.IsClosed) reader.Close();
                throw new ApplicationException("BUY_PRICE does not exist.");
            }
        }

        public BUY_PRICE(SqlDataReader reader)
        {
            this.LoadFromReader(reader);
        }

        protected void LoadFromReader(SqlDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                _id = reader.GetInt32(0);
                if (!reader.IsDBNull(1)) _itemId = reader.GetInt32(1);
                if (!reader.IsDBNull(2)) _partnerId = reader.GetInt32(2);
                if (!reader.IsDBNull(3)) _buyPrice = reader.GetDecimal(3);
                if (!reader.IsDBNull(4)) _createdBy = reader.GetString(4);
                if (!reader.IsDBNull(5)) _createdDate = reader.GetDateTime(5);
                if (!reader.IsDBNull(6)) _modifiedBy = reader.GetString(6);
                if (!reader.IsDBNull(7)) _modifiedDate = reader.GetDateTime(7);
                if (!reader.IsDBNull(8)) _deleted = reader.GetInt32(8);
            }
        }

        public void Delete()
        {
            BUY_PRICE.Delete(_id);
        }

        public void Update()
        {
            SqlService sql = new SqlService();
            StringBuilder queryParameters = new StringBuilder();

            sql.AddParameter("@Id", SqlDbType.Int, Id);
            queryParameters.Append("Id = @Id");

            sql.AddParameter("@ItemId", SqlDbType.Int, ItemId);
            queryParameters.Append(", ItemId = @ItemId");
            sql.AddParameter("@PartnerId", SqlDbType.Int, PartnerId);
            queryParameters.Append(", PartnerId = @PartnerId");
            sql.AddParameter("@BuyPrice", SqlDbType.Decimal, BuyPrice);
            queryParameters.Append(", BuyPrice = @BuyPrice");
            sql.AddParameter("@CreatedBy", SqlDbType.NVarChar, CreatedBy);
            queryParameters.Append(", CreatedBy = @CreatedBy");
            sql.AddParameter("@CreatedDate", SqlDbType.DateTime, CreatedDate);
            queryParameters.Append(", CreatedDate = @CreatedDate");
            sql.AddParameter("@ModifiedBy", SqlDbType.NVarChar, ModifiedBy);
            queryParameters.Append(", ModifiedBy = @ModifiedBy");
            sql.AddParameter("@ModifiedDate", SqlDbType.DateTime, ModifiedDate);
            queryParameters.Append(", ModifiedDate = @ModifiedDate");
            sql.AddParameter("@Deleted", SqlDbType.Int, Deleted);
            queryParameters.Append(", Deleted = @Deleted");

            string query = String.Format("Update BUY_PRICE Set {0} Where Id = @Id", queryParameters.ToString());
            SqlDataReader reader = sql.ExecuteSqlReader(query);
        }

        public void Create()
        {
            SqlService sql = new SqlService();
            StringBuilder queryParameters = new StringBuilder();

            sql.AddParameter("@Id", SqlDbType.Int, Id);
            queryParameters.Append("@Id");

            sql.AddParameter("@ItemId", SqlDbType.Int, ItemId);
            queryParameters.Append(", @ItemId");
            sql.AddParameter("@PartnerId", SqlDbType.Int, PartnerId);
            queryParameters.Append(", @PartnerId");
            sql.AddParameter("@BuyPrice", SqlDbType.Decimal, BuyPrice);
            queryParameters.Append(", @BuyPrice");
            sql.AddParameter("@CreatedBy", SqlDbType.NVarChar, CreatedBy);
            queryParameters.Append(", @CreatedBy");
            sql.AddParameter("@CreatedDate", SqlDbType.DateTime, CreatedDate);
            queryParameters.Append(", @CreatedDate");
            sql.AddParameter("@ModifiedBy", SqlDbType.NVarChar, ModifiedBy);
            queryParameters.Append(", @ModifiedBy");
            sql.AddParameter("@ModifiedDate", SqlDbType.DateTime, ModifiedDate);
            queryParameters.Append(", @ModifiedDate");
            sql.AddParameter("@Deleted", SqlDbType.Int, Deleted);
            queryParameters.Append(", @Deleted");

            string query = String.Format("Insert Into BUY_PRICE ({0}) Values ({1})", queryParameters.ToString().Replace("@", ""), queryParameters.ToString());
            SqlDataReader reader = sql.ExecuteSqlReader(query);
        }

        public static BUY_PRICE NewBUY_PRICE(int id)
        {
            BUY_PRICE newEntity = new BUY_PRICE();
            newEntity._id = id;

            return newEntity;
        }

        #region Public Properties
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int ItemId
        {
            get { return _itemId; }
            set { _itemId = value; }
        }

        public int PartnerId
        {
            get { return _partnerId; }
            set { _partnerId = value; }
        }

        public decimal BuyPrice
        {
            get { return _buyPrice; }
            set { _buyPrice = value; }
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

        public int Deleted
        {
            get { return _deleted; }
            set { _deleted = value; }
        }
        #endregion

        public static BUY_PRICE GetBUY_PRICE(int id)
        {
            return new BUY_PRICE(id);
        }

        public static void Delete(int id)
        {
            SqlService sql = new SqlService();
            sql.AddParameter("@Id", SqlDbType.Int, id);

            SqlDataReader reader = sql.ExecuteSqlReader("Delete BUY_PRICE Where Id = @Id");
        }
    }
    #endregion
}

