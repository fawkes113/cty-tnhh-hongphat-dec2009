using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace HongPhat.Entities
{
    #region DEBT
    /// <summary>
    /// This object represents the properties and methods of a DEBT.
    /// </summary>
    public class DEBT
    {
        private int _id;
        private decimal _oldDebtValue;
        private decimal _newDebtValue;
        private decimal _payment;
        private decimal _currentDebtValue;
        private int _customerId;
        private int _deleted;
        private string _createdBy = String.Empty;
        private DateTime _createDate;
        private string _modifiedBy = String.Empty;
        private DateTime _modifiedDate;
        private int _debtKind;
        private string _note = String.Empty;

        public DEBT()
        {
        }

        public DEBT(int id)
        {
            SqlService sql = new SqlService();
            sql.AddParameter("@DebtId", SqlDbType.Int, id);
            SqlDataReader reader = sql.ExecuteSqlReader("SELECT * FROM DEBT WHERE DebtId = @DebtId");

            if (reader.Read())
            {
                this.LoadFromReader(reader);
                reader.Close();
            }
            else
            {
                if (!reader.IsClosed) reader.Close();
                throw new ApplicationException("DEBT does not exist.");
            }
        }

        public DEBT(SqlDataReader reader)
        {
            this.LoadFromReader(reader);
        }

        protected void LoadFromReader(SqlDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                _id = reader.GetInt32(0);
                if (!reader.IsDBNull(1)) _oldDebtValue = reader.GetDecimal(1);
                if (!reader.IsDBNull(2)) _newDebtValue = reader.GetDecimal(2);
                if (!reader.IsDBNull(3)) _payment = reader.GetDecimal(3);
                if (!reader.IsDBNull(4)) _currentDebtValue = reader.GetDecimal(4);
                if (!reader.IsDBNull(5)) _customerId = reader.GetInt32(5);
                if (!reader.IsDBNull(6)) _deleted = reader.GetInt32(6);
                if (!reader.IsDBNull(7)) _createdBy = reader.GetString(7);
                if (!reader.IsDBNull(8)) _createDate = reader.GetDateTime(8);
                if (!reader.IsDBNull(9)) _modifiedBy = reader.GetString(9);
                if (!reader.IsDBNull(10)) _modifiedDate = reader.GetDateTime(10);
                if (!reader.IsDBNull(11)) _debtKind = reader.GetInt32(11);
                if (!reader.IsDBNull(12)) _note = reader.GetString(12);
            }
        }

        public void Delete()
        {
            DEBT.Delete(_id);
        }

        public void Update()
        {
            SqlService sql = new SqlService();
            StringBuilder queryParameters = new StringBuilder();

            sql.AddParameter("@DebtId", SqlDbType.Int, Id);
            queryParameters.Append("DebtId = @DebtId");

            sql.AddParameter("@OldDebtValue", SqlDbType.Decimal, OldDebtValue);
            queryParameters.Append(", OldDebtValue = @OldDebtValue");
            sql.AddParameter("@NewDebtValue", SqlDbType.Decimal, NewDebtValue);
            queryParameters.Append(", NewDebtValue = @NewDebtValue");
            sql.AddParameter("@Payment", SqlDbType.Decimal, Payment);
            queryParameters.Append(", Payment = @Payment");
            sql.AddParameter("@CurrentDebtValue", SqlDbType.Decimal, CurrentDebtValue);
            queryParameters.Append(", CurrentDebtValue = @CurrentDebtValue");
            sql.AddParameter("@CustomerId", SqlDbType.Int, CustomerId);
            queryParameters.Append(", CustomerId = @CustomerId");
            sql.AddParameter("@Deleted", SqlDbType.Int, Deleted);
            queryParameters.Append(", Deleted = @Deleted");
            sql.AddParameter("@CreatedBy", SqlDbType.NVarChar, CreatedBy);
            queryParameters.Append(", CreatedBy = @CreatedBy");
            sql.AddParameter("@CreateDate", SqlDbType.DateTime, CreateDate);
            queryParameters.Append(", CreateDate = @CreateDate");
            sql.AddParameter("@ModifiedBy", SqlDbType.NVarChar, ModifiedBy);
            queryParameters.Append(", ModifiedBy = @ModifiedBy");
            sql.AddParameter("@ModifiedDate", SqlDbType.DateTime, ModifiedDate);
            queryParameters.Append(", ModifiedDate = @ModifiedDate");
            sql.AddParameter("@DebtKind", SqlDbType.Int, DebtKind);
            queryParameters.Append(", DebtKind = @DebtKind");
            sql.AddParameter("@Note", SqlDbType.Text, Note);
            queryParameters.Append(", Note = @Note");

            string query = String.Format("Update DEBT Set {0} Where DebtId = @DebtId", queryParameters.ToString());
            SqlDataReader reader = sql.ExecuteSqlReader(query);
        }

        public void Create()
        {
            SqlService sql = new SqlService();
            StringBuilder queryParameters = new StringBuilder();

            sql.AddParameter("@DebtId", SqlDbType.Int, Id);
            queryParameters.Append("@DebtId");

            sql.AddParameter("@OldDebtValue", SqlDbType.Decimal, OldDebtValue);
            queryParameters.Append(", @OldDebtValue");
            sql.AddParameter("@NewDebtValue", SqlDbType.Decimal, NewDebtValue);
            queryParameters.Append(", @NewDebtValue");
            sql.AddParameter("@Payment", SqlDbType.Decimal, Payment);
            queryParameters.Append(", @Payment");
            sql.AddParameter("@CurrentDebtValue", SqlDbType.Decimal, CurrentDebtValue);
            queryParameters.Append(", @CurrentDebtValue");
            sql.AddParameter("@CustomerId", SqlDbType.Int, CustomerId);
            queryParameters.Append(", @CustomerId");
            sql.AddParameter("@Deleted", SqlDbType.Int, Deleted);
            queryParameters.Append(", @Deleted");
            sql.AddParameter("@CreatedBy", SqlDbType.NVarChar, CreatedBy);
            queryParameters.Append(", @CreatedBy");
            sql.AddParameter("@CreateDate", SqlDbType.DateTime, CreateDate);
            queryParameters.Append(", @CreateDate");
            sql.AddParameter("@ModifiedBy", SqlDbType.NVarChar, ModifiedBy);
            queryParameters.Append(", @ModifiedBy");
            sql.AddParameter("@ModifiedDate", SqlDbType.DateTime, ModifiedDate);
            queryParameters.Append(", @ModifiedDate");
            sql.AddParameter("@DebtKind", SqlDbType.Int, DebtKind);
            queryParameters.Append(", @DebtKind");
            sql.AddParameter("@Note", SqlDbType.Text, Note);
            queryParameters.Append(", @Note");

            string query = String.Format("Insert Into DEBT ({0}) Values ({1})", queryParameters.ToString().Replace("@", ""), queryParameters.ToString());
            SqlDataReader reader = sql.ExecuteSqlReader(query);
        }

        public static DEBT NewDEBT(int id)
        {
            DEBT newEntity = new DEBT();
            newEntity._id = id;

            return newEntity;
        }

        #region Public Properties
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public decimal OldDebtValue
        {
            get { return _oldDebtValue; }
            set { _oldDebtValue = value; }
        }

        public decimal NewDebtValue
        {
            get { return _newDebtValue; }
            set { _newDebtValue = value; }
        }

        public decimal Payment
        {
            get { return _payment; }
            set { _payment = value; }
        }

        public decimal CurrentDebtValue
        {
            get { return _currentDebtValue; }
            set { _currentDebtValue = value; }
        }

        public int CustomerId
        {
            get { return _customerId; }
            set { _customerId = value; }
        }

        public int Deleted
        {
            get { return _deleted; }
            set { _deleted = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
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

        public int DebtKind
        {
            get { return _debtKind; }
            set { _debtKind = value; }
        }

        public string Note
        {
            get { return _note; }
            set { _note = value; }
        }
        #endregion

        public static DEBT GetDEBT(int id)
        {
            return new DEBT(id);
        }

        public static void Delete(int id)
        {
            SqlService sql = new SqlService();
            sql.AddParameter("@DebtId", SqlDbType.Int, id);

            SqlDataReader reader = sql.ExecuteSqlReader("Delete DEBT Where DebtId = @DebtId");
        }
    }
    #endregion
}

