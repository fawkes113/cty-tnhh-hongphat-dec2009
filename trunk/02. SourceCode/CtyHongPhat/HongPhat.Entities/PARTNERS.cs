using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace HongPhat.Entities
{
    #region PARTNERS
    /// <summary>
    /// This object represents the properties and methods of a PARTNERS.
    /// </summary>
    public class PARTNERS
    {
        private int _id;
        private string _partnerName = String.Empty;
        private string _address = String.Empty;
        private string _phoneNumber = String.Empty;

        public PARTNERS()
        {
        }

        public PARTNERS(int id)
        {
            SqlService sql = new SqlService();
            sql.AddParameter("@PartnerId", SqlDbType.Int, id);
            SqlDataReader reader = sql.ExecuteSqlReader("SELECT * FROM PARTNERS WHERE PartnerId = @PartnerId");

            if (reader.Read())
            {
                this.LoadFromReader(reader);
                reader.Close();
            }
            else
            {
                if (!reader.IsClosed) reader.Close();
                throw new ApplicationException("PARTNERS does not exist.");
            }
        }

        public PARTNERS(SqlDataReader reader)
        {
            this.LoadFromReader(reader);
        }

        protected void LoadFromReader(SqlDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                _id = reader.GetInt32(0);
                if (!reader.IsDBNull(1)) _partnerName = reader.GetString(1);
                if (!reader.IsDBNull(2)) _address = reader.GetString(2);
                if (!reader.IsDBNull(3)) _phoneNumber = reader.GetString(3);
            }
        }

        public void Delete()
        {
            PARTNERS.Delete(_id);
        }

        public void Update()
        {
            SqlService sql = new SqlService();
            StringBuilder queryParameters = new StringBuilder();

            sql.AddParameter("@PartnerId", SqlDbType.Int, Id);
            queryParameters.Append("PartnerId = @PartnerId");

            sql.AddParameter("@PartnerName", SqlDbType.NVarChar, PartnerName);
            queryParameters.Append(", PartnerName = @PartnerName");
            sql.AddParameter("@Address", SqlDbType.NVarChar, Address);
            queryParameters.Append(", Address = @Address");
            sql.AddParameter("@PhoneNumber", SqlDbType.NVarChar, PhoneNumber);
            queryParameters.Append(", PhoneNumber = @PhoneNumber");

            string query = String.Format("Update PARTNERS Set {0} Where PartnerId = @PartnerId", queryParameters.ToString());
            SqlDataReader reader = sql.ExecuteSqlReader(query);
        }

        public void Create()
        {
            SqlService sql = new SqlService();
            StringBuilder queryParameters = new StringBuilder();

            sql.AddParameter("@PartnerId", SqlDbType.Int, Id);
            queryParameters.Append("@PartnerId");

            sql.AddParameter("@PartnerName", SqlDbType.NVarChar, PartnerName);
            queryParameters.Append(", @PartnerName");
            sql.AddParameter("@Address", SqlDbType.NVarChar, Address);
            queryParameters.Append(", @Address");
            sql.AddParameter("@PhoneNumber", SqlDbType.NVarChar, PhoneNumber);
            queryParameters.Append(", @PhoneNumber");

            string query = String.Format("Insert Into PARTNERS ({0}) Values ({1})", queryParameters.ToString().Replace("@", ""), queryParameters.ToString());
            SqlDataReader reader = sql.ExecuteSqlReader(query);
        }

        public static PARTNERS NewPARTNERS(int id)
        {
            PARTNERS newEntity = new PARTNERS();
            newEntity._id = id;

            return newEntity;
        }

        #region Public Properties
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string PartnerName
        {
            get { return _partnerName; }
            set { _partnerName = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }
        #endregion

        public static PARTNERS GetPARTNERS(int id)
        {
            return new PARTNERS(id);
        }

        public static void Delete(int id)
        {
            SqlService sql = new SqlService();
            sql.AddParameter("@PartnerId", SqlDbType.Int, id);

            SqlDataReader reader = sql.ExecuteSqlReader("Delete PARTNERS Where PartnerId = @PartnerId");
        }
    }
    #endregion
}

