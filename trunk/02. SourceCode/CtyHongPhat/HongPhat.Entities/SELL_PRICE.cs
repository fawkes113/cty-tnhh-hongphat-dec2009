using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace HongPhat.Entities
{
    #region SELL_PRICE
    /// <summary>
    /// This object represents the properties and methods of a SELL_PRICE.
    /// </summary>
    public class SELL_PRICE
    {
        private int _id;
        private int _itemId;
        private int _agentId;
        private decimal _sellPrice;
        private DateTime _createdDate;
        private string _createdBy = String.Empty;
        private string _modifiedBy = String.Empty;
        private DateTime _modifiedDate;
        private int _deleted;

        public SELL_PRICE()
        {
        }

        public SELL_PRICE(int id)
        {
            SqlService sql = new SqlService();
            sql.AddParameter("@Id", SqlDbType.Int, id);
            SqlDataReader reader = sql.ExecuteSqlReader("SELECT * FROM SELL_PRICE WHERE Id = @Id");

            if (reader.Read())
            {
                this.LoadFromReader(reader);
                reader.Close();
            }
            else
            {
                if (!reader.IsClosed) reader.Close();
                throw new ApplicationException("SELL_PRICE does not exist.");
            }
        }

        public SELL_PRICE(SqlDataReader reader)
        {
            this.LoadFromReader(reader);
        }

        protected void LoadFromReader(SqlDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                _id = reader.GetInt32(0);
                if (!reader.IsDBNull(1)) _itemId = reader.GetInt32(1);
                if (!reader.IsDBNull(2)) _agentId = reader.GetInt32(2);
                if (!reader.IsDBNull(3)) _sellPrice = reader.GetDecimal(3);
                if (!reader.IsDBNull(4)) _createdDate = reader.GetDateTime(4);
                if (!reader.IsDBNull(5)) _createdBy = reader.GetString(5);
                if (!reader.IsDBNull(6)) _modifiedBy = reader.GetString(6);
                if (!reader.IsDBNull(7)) _modifiedDate = reader.GetDateTime(7);
                if (!reader.IsDBNull(8)) _deleted = reader.GetInt32(8);
            }
        }

        public void Delete()
        {
            SELL_PRICE.Delete(_id);
        }

        public void Update()
        {
            SqlService sql = new SqlService();
            StringBuilder queryParameters = new StringBuilder();

            sql.AddParameter("@Id", SqlDbType.Int, Id);
            queryParameters.Append("Id = @Id");

            sql.AddParameter("@ItemId", SqlDbType.Int, ItemId);
            queryParameters.Append(", ItemId = @ItemId");
            sql.AddParameter("@AgentId", SqlDbType.Int, AgentId);
            queryParameters.Append(", AgentId = @AgentId");
            sql.AddParameter("@SellPrice", SqlDbType.Decimal, SellPrice);
            queryParameters.Append(", SellPrice = @SellPrice");
            sql.AddParameter("@CreatedDate", SqlDbType.DateTime, CreatedDate);
            queryParameters.Append(", CreatedDate = @CreatedDate");
            sql.AddParameter("@CreatedBy", SqlDbType.NVarChar, CreatedBy);
            queryParameters.Append(", CreatedBy = @CreatedBy");
            sql.AddParameter("@ModifiedBy", SqlDbType.NVarChar, ModifiedBy);
            queryParameters.Append(", ModifiedBy = @ModifiedBy");
            sql.AddParameter("@ModifiedDate", SqlDbType.DateTime, ModifiedDate);
            queryParameters.Append(", ModifiedDate = @ModifiedDate");
            sql.AddParameter("@Deleted", SqlDbType.Int, Deleted);
            queryParameters.Append(", Deleted = @Deleted");

            string query = String.Format("Update SELL_PRICE Set {0} Where Id = @Id", queryParameters.ToString());
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
            sql.AddParameter("@AgentId", SqlDbType.Int, AgentId);
            queryParameters.Append(", @AgentId");
            sql.AddParameter("@SellPrice", SqlDbType.Decimal, SellPrice);
            queryParameters.Append(", @SellPrice");
            sql.AddParameter("@CreatedDate", SqlDbType.DateTime, CreatedDate);
            queryParameters.Append(", @CreatedDate");
            sql.AddParameter("@CreatedBy", SqlDbType.NVarChar, CreatedBy);
            queryParameters.Append(", @CreatedBy");
            sql.AddParameter("@ModifiedBy", SqlDbType.NVarChar, ModifiedBy);
            queryParameters.Append(", @ModifiedBy");
            sql.AddParameter("@ModifiedDate", SqlDbType.DateTime, ModifiedDate);
            queryParameters.Append(", @ModifiedDate");
            sql.AddParameter("@Deleted", SqlDbType.Int, Deleted);
            queryParameters.Append(", @Deleted");

            string query = String.Format("Insert Into SELL_PRICE ({0}) Values ({1})", queryParameters.ToString().Replace("@", ""), queryParameters.ToString());
            SqlDataReader reader = sql.ExecuteSqlReader(query);
        }

        public static SELL_PRICE NewSELL_PRICE(int id)
        {
            SELL_PRICE newEntity = new SELL_PRICE();
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

        public int AgentId
        {
            get { return _agentId; }
            set { _agentId = value; }
        }

        public decimal SellPrice
        {
            get { return _sellPrice; }
            set { _sellPrice = value; }
        }

        public DateTime CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
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

        public static SELL_PRICE GetSELL_PRICE(int id)
        {
            return new SELL_PRICE(id);
        }

        public static void Delete(int id)
        {
            SqlService sql = new SqlService();
            sql.AddParameter("@Id", SqlDbType.Int, id);

            SqlDataReader reader = sql.ExecuteSqlReader("Delete SELL_PRICE Where Id = @Id");
        }
    }
    #endregion
}

