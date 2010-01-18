using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace HongPhat.Entities
{
    #region ITEMS
    /// <summary>
    /// This object represents the properties and methods of a ITEMS.
    /// </summary>
    public class ITEMS
    {
        private int _id;
        private string _itemName = String.Empty;
        private string _createdBy = String.Empty;
        private DateTime _createdDate;
        private string _modifiedBy = String.Empty;
        private DateTime _modifiedDate;
        private int _deleted;
        private decimal _totalQuantity;
        private string _measurement = String.Empty;

        public ITEMS()
        {
        }

        public ITEMS(int id)
        {
            SqlService sql = new SqlService();
            sql.AddParameter("@ItemId", SqlDbType.Int, id);
            SqlDataReader reader = sql.ExecuteSqlReader("SELECT * FROM ITEMS WHERE ItemId = @ItemId");

            if (reader.Read())
            {
                this.LoadFromReader(reader);
                reader.Close();
            }
            else
            {
                if (!reader.IsClosed) reader.Close();
                throw new ApplicationException("ITEMS does not exist.");
            }
        }

        public ITEMS(SqlDataReader reader)
        {
            this.LoadFromReader(reader);
        }

        protected void LoadFromReader(SqlDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                _id = reader.GetInt32(0);
                if (!reader.IsDBNull(1)) _itemName = reader.GetString(1);
                if (!reader.IsDBNull(2)) _createdBy = reader.GetString(2);
                if (!reader.IsDBNull(3)) _createdDate = reader.GetDateTime(3);
                if (!reader.IsDBNull(4)) _modifiedBy = reader.GetString(4);
                if (!reader.IsDBNull(5)) _modifiedDate = reader.GetDateTime(5);
                if (!reader.IsDBNull(6)) _deleted = reader.GetInt32(6);
                if (!reader.IsDBNull(7)) _totalQuantity = reader.GetDecimal(7);
                if (!reader.IsDBNull(8)) _measurement = reader.GetString(8);
            }
        }

        public void Delete()
        {
            ITEMS.Delete(_id);
        }

        public void Update()
        {
            SqlService sql = new SqlService();
            StringBuilder queryParameters = new StringBuilder();

            sql.AddParameter("@ItemId", SqlDbType.Int, Id);
            queryParameters.Append("ItemId = @ItemId");

            sql.AddParameter("@ItemName", SqlDbType.NVarChar, ItemName);
            queryParameters.Append(", ItemName = @ItemName");
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
            sql.AddParameter("@TotalQuantity", SqlDbType.Decimal, TotalQuantity);
            queryParameters.Append(", TotalQuantity = @TotalQuantity");
            sql.AddParameter("@Measurement", SqlDbType.NVarChar, Measurement);
            queryParameters.Append(", Measurement = @Measurement");

            string query = String.Format("Update ITEMS Set {0} Where ItemId = @ItemId", queryParameters.ToString());
            SqlDataReader reader = sql.ExecuteSqlReader(query);
        }

        public void Create()
        {
            SqlService sql = new SqlService();
            StringBuilder queryParameters = new StringBuilder();

            sql.AddParameter("@ItemId", SqlDbType.Int, Id);
            queryParameters.Append("@ItemId");

            sql.AddParameter("@ItemName", SqlDbType.NVarChar, ItemName);
            queryParameters.Append(", @ItemName");
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
            sql.AddParameter("@TotalQuantity", SqlDbType.Decimal, TotalQuantity);
            queryParameters.Append(", @TotalQuantity");
            sql.AddParameter("@Measurement", SqlDbType.NVarChar, Measurement);
            queryParameters.Append(", @Measurement");

            string query = String.Format("Insert Into ITEMS ({0}) Values ({1})", queryParameters.ToString().Replace("@", ""), queryParameters.ToString());
            SqlDataReader reader = sql.ExecuteSqlReader(query);
        }

        public static ITEMS NewITEMS(int id)
        {
            ITEMS newEntity = new ITEMS();
            newEntity._id = id;

            return newEntity;
        }

        #region Public Properties
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string ItemName
        {
            get { return _itemName; }
            set { _itemName = value; }
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

        public decimal TotalQuantity
        {
            get { return _totalQuantity; }
            set { _totalQuantity = value; }
        }

        public string Measurement
        {
            get { return _measurement; }
            set { _measurement = value; }
        }
        #endregion

        public static ITEMS GetITEMS(int id)
        {
            return new ITEMS(id);
        }

        public static void Delete(int id)
        {
            SqlService sql = new SqlService();
            sql.AddParameter("@ItemId", SqlDbType.Int, id);

            SqlDataReader reader = sql.ExecuteSqlReader("Delete ITEMS Where ItemId = @ItemId");
        }
    }
    #endregion
}

