using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace HongPhat.Entities
{
    #region RETURNED_ITEM_DETAILS
    /// <summary>
    /// This object represents the properties and methods of a RETURNED_ITEM_DETAILS.
    /// </summary>
    public class RETURNED_ITEM_DETAILS
    {
        private int _id;
        private decimal _quantity;
        private DateTime _returnDate;
        private string _note = String.Empty;

        public RETURNED_ITEM_DETAILS()
        {
        }

        public RETURNED_ITEM_DETAILS(int id)
        {
            SqlService sql = new SqlService();
            sql.AddParameter("@OrderDetailId", SqlDbType.Int, id);
            SqlDataReader reader = sql.ExecuteSqlReader("SELECT * FROM RETURNED_ITEM_DETAILS WHERE OrderDetailId = @OrderDetailId");

            if (reader.Read())
            {
                this.LoadFromReader(reader);
                reader.Close();
            }
            else
            {
                if (!reader.IsClosed) reader.Close();
                throw new ApplicationException("RETURNED_ITEM_DETAILS does not exist.");
            }
        }

        public RETURNED_ITEM_DETAILS(SqlDataReader reader)
        {
            this.LoadFromReader(reader);
        }

        protected void LoadFromReader(SqlDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                _id = reader.GetInt32(0);
                if (!reader.IsDBNull(1)) _quantity = reader.GetDecimal(1);
                if (!reader.IsDBNull(2)) _returnDate = reader.GetDateTime(2);
                if (!reader.IsDBNull(3)) _note = reader.GetString(3);
            }
        }

        public void Delete()
        {
            RETURNED_ITEM_DETAILS.Delete(_id);
        }

        public void Update()
        {
            SqlService sql = new SqlService();
            StringBuilder queryParameters = new StringBuilder();

            sql.AddParameter("@OrderDetailId", SqlDbType.Int, Id);
            queryParameters.Append("OrderDetailId = @OrderDetailId");

            sql.AddParameter("@Quantity", SqlDbType.Decimal, Quantity);
            queryParameters.Append(", Quantity = @Quantity");
            sql.AddParameter("@ReturnDate", SqlDbType.DateTime, ReturnDate);
            queryParameters.Append(", ReturnDate = @ReturnDate");
            sql.AddParameter("@Note", SqlDbType.Text, Note);
            queryParameters.Append(", Note = @Note");

            string query = String.Format("Update RETURNED_ITEM_DETAILS Set {0} Where OrderDetailId = @OrderDetailId", queryParameters.ToString());
            SqlDataReader reader = sql.ExecuteSqlReader(query);
        }

        public void Create()
        {
            SqlService sql = new SqlService();
            StringBuilder queryParameters = new StringBuilder();

            sql.AddParameter("@OrderDetailId", SqlDbType.Int, Id);
            queryParameters.Append("@OrderDetailId");

            sql.AddParameter("@Quantity", SqlDbType.Decimal, Quantity);
            queryParameters.Append(", @Quantity");
            sql.AddParameter("@ReturnDate", SqlDbType.DateTime, ReturnDate);
            queryParameters.Append(", @ReturnDate");
            sql.AddParameter("@Note", SqlDbType.Text, Note);
            queryParameters.Append(", @Note");

            string query = String.Format("Insert Into RETURNED_ITEM_DETAILS ({0}) Values ({1})", queryParameters.ToString().Replace("@", ""), queryParameters.ToString());
            SqlDataReader reader = sql.ExecuteSqlReader(query);
        }

        public static RETURNED_ITEM_DETAILS NewRETURNED_ITEM_DETAILS(int id)
        {
            RETURNED_ITEM_DETAILS newEntity = new RETURNED_ITEM_DETAILS();
            newEntity._id = id;

            return newEntity;
        }

        #region Public Properties
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public decimal Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        public DateTime ReturnDate
        {
            get { return _returnDate; }
            set { _returnDate = value; }
        }

        public string Note
        {
            get { return _note; }
            set { _note = value; }
        }
        #endregion

        public static RETURNED_ITEM_DETAILS GetRETURNED_ITEM_DETAILS(int id)
        {
            return new RETURNED_ITEM_DETAILS(id);
        }

        public static void Delete(int id)
        {
            SqlService sql = new SqlService();
            sql.AddParameter("@OrderDetailId", SqlDbType.Int, id);

            SqlDataReader reader = sql.ExecuteSqlReader("Delete RETURNED_ITEM_DETAILS Where OrderDetailId = @OrderDetailId");
        }
    }
    #endregion
}

