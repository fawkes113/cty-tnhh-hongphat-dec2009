using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace HongPhat.Entities
{
    #region AGENTS
    /// <summary>
    /// This object represents the properties and methods of a AGENTS.
    /// </summary>
    public class AGENTS
    {
        private int _id;
        private string _agentName = String.Empty;
        private string _createdBy = String.Empty;
        private DateTime _createdDate;
        private string _modifiedBy = String.Empty;
        private DateTime _modifiedDate;
        private int _idAgentKind;
        private int _deleted;

        public AGENTS()
        {
        }

        public AGENTS(int id)
        {
            SqlService sql = new SqlService();
            sql.AddParameter("@AgentId", SqlDbType.Int, id);
            SqlDataReader reader = sql.ExecuteSqlReader("SELECT * FROM AGENTS WHERE AgentId = @AgentId");

            if (reader.Read())
            {
                this.LoadFromReader(reader);
                reader.Close();
            }
            else
            {
                if (!reader.IsClosed) reader.Close();
                throw new ApplicationException("AGENTS does not exist.");
            }
        }

        public AGENTS(SqlDataReader reader)
        {
            this.LoadFromReader(reader);
        }

        protected void LoadFromReader(SqlDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                _id = reader.GetInt32(0);
                if (!reader.IsDBNull(1)) _agentName = reader.GetString(1);
                if (!reader.IsDBNull(2)) _createdBy = reader.GetString(2);
                if (!reader.IsDBNull(3)) _createdDate = reader.GetDateTime(3);
                if (!reader.IsDBNull(4)) _modifiedBy = reader.GetString(4);
                if (!reader.IsDBNull(5)) _modifiedDate = reader.GetDateTime(5);
                if (!reader.IsDBNull(6)) _idAgentKind = reader.GetInt32(6);
                if (!reader.IsDBNull(7)) _deleted = reader.GetInt32(7);
            }
        }

        public void Delete()
        {
            AGENTS.Delete(_id);
        }

        public void Update()
        {
            SqlService sql = new SqlService();
            StringBuilder queryParameters = new StringBuilder();

            sql.AddParameter("@AgentId", SqlDbType.Int, Id);
            queryParameters.Append("AgentId = @AgentId");

            sql.AddParameter("@AgentName", SqlDbType.NVarChar, AgentName);
            queryParameters.Append(", AgentName = @AgentName");
            sql.AddParameter("@CreatedBy", SqlDbType.NVarChar, CreatedBy);
            queryParameters.Append(", CreatedBy = @CreatedBy");
            sql.AddParameter("@CreatedDate", SqlDbType.DateTime, CreatedDate);
            queryParameters.Append(", CreatedDate = @CreatedDate");
            sql.AddParameter("@ModifiedBy", SqlDbType.NVarChar, ModifiedBy);
            queryParameters.Append(", ModifiedBy = @ModifiedBy");
            sql.AddParameter("@ModifiedDate", SqlDbType.DateTime, ModifiedDate);
            queryParameters.Append(", ModifiedDate = @ModifiedDate");
            sql.AddParameter("@IdAgentKind", SqlDbType.Int, IdAgentKind);
            queryParameters.Append(", IdAgentKind = @IdAgentKind");
            sql.AddParameter("@Deleted", SqlDbType.Int, Deleted);
            queryParameters.Append(", Deleted = @Deleted");

            string query = String.Format("Update AGENTS Set {0} Where AgentId = @AgentId", queryParameters.ToString());
            SqlDataReader reader = sql.ExecuteSqlReader(query);
        }

        public void Create()
        {
            SqlService sql = new SqlService();
            StringBuilder queryParameters = new StringBuilder();

            sql.AddParameter("@AgentId", SqlDbType.Int, Id);
            queryParameters.Append("@AgentId");

            sql.AddParameter("@AgentName", SqlDbType.NVarChar, AgentName);
            queryParameters.Append(", @AgentName");
            sql.AddParameter("@CreatedBy", SqlDbType.NVarChar, CreatedBy);
            queryParameters.Append(", @CreatedBy");
            sql.AddParameter("@CreatedDate", SqlDbType.DateTime, CreatedDate);
            queryParameters.Append(", @CreatedDate");
            sql.AddParameter("@ModifiedBy", SqlDbType.NVarChar, ModifiedBy);
            queryParameters.Append(", @ModifiedBy");
            sql.AddParameter("@ModifiedDate", SqlDbType.DateTime, ModifiedDate);
            queryParameters.Append(", @ModifiedDate");
            sql.AddParameter("@IdAgentKind", SqlDbType.Int, IdAgentKind);
            queryParameters.Append(", @IdAgentKind");
            sql.AddParameter("@Deleted", SqlDbType.Int, Deleted);
            queryParameters.Append(", @Deleted");

            string query = String.Format("Insert Into AGENTS ({0}) Values ({1})", queryParameters.ToString().Replace("@", ""), queryParameters.ToString());
            SqlDataReader reader = sql.ExecuteSqlReader(query);
        }

        public static AGENTS NewAGENTS(int id)
        {
            AGENTS newEntity = new AGENTS();
            newEntity._id = id;

            return newEntity;
        }

        #region Public Properties
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string AgentName
        {
            get { return _agentName; }
            set { _agentName = value; }
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

        public int IdAgentKind
        {
            get { return _idAgentKind; }
            set { _idAgentKind = value; }
        }

        public int Deleted
        {
            get { return _deleted; }
            set { _deleted = value; }
        }
        #endregion

        public static AGENTS GetAGENTS(int id)
        {
            return new AGENTS(id);
        }

        public static void Delete(int id)
        {
            SqlService sql = new SqlService();
            sql.AddParameter("@AgentId", SqlDbType.Int, id);

            SqlDataReader reader = sql.ExecuteSqlReader("Delete AGENTS Where AgentId = @AgentId");
        }
    }
    #endregion
}

