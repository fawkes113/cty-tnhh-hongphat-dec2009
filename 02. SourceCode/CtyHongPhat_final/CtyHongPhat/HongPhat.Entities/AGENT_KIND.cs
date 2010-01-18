using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace HongPhat.Entities
{
    #region AGENT_KIND
    /// <summary>
    /// This object represents the properties and methods of a AGENT_KIND.
    /// </summary>
    public class AGENT_KIND
    {
        private int _id;
        private string _agentKindName = String.Empty;
        private string _createdBy = String.Empty;
        private DateTime _cratedDate;
        private string _modifiedBy = String.Empty;
        private DateTime _modifiedDate;
        private int _deleted;

        public AGENT_KIND()
        {
        }

        public AGENT_KIND(int id)
        {
            SqlService sql = new SqlService();
            sql.AddParameter("@IdAgentKind", SqlDbType.Int, id);
            SqlDataReader reader = sql.ExecuteSqlReader("SELECT * FROM AGENT_KIND WHERE IdAgentKind = @IdAgentKind");

            if (reader.Read())
            {
                this.LoadFromReader(reader);
                reader.Close();
            }
            else
            {
                if (!reader.IsClosed) reader.Close();
                throw new ApplicationException("AGENT_KIND does not exist.");
            }
        }

        public AGENT_KIND(SqlDataReader reader)
        {
            this.LoadFromReader(reader);
        }

        protected void LoadFromReader(SqlDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                _id = reader.GetInt32(0);
                if (!reader.IsDBNull(1)) _agentKindName = reader.GetString(1);
                if (!reader.IsDBNull(2)) _createdBy = reader.GetString(2);
                if (!reader.IsDBNull(3)) _cratedDate = reader.GetDateTime(3);
                if (!reader.IsDBNull(4)) _modifiedBy = reader.GetString(4);
                if (!reader.IsDBNull(5)) _modifiedDate = reader.GetDateTime(5);
                if (!reader.IsDBNull(6)) _deleted = reader.GetInt32(6);
            }
        }

        public void Delete()
        {
            AGENT_KIND.Delete(_id);
        }

        public void Update()
        {
            SqlService sql = new SqlService();
            StringBuilder queryParameters = new StringBuilder();

            sql.AddParameter("@IdAgentKind", SqlDbType.Int, Id);
            queryParameters.Append("IdAgentKind = @IdAgentKind");

            sql.AddParameter("@AgentKindName", SqlDbType.NVarChar, AgentKindName);
            queryParameters.Append(", AgentKindName = @AgentKindName");
            sql.AddParameter("@CreatedBy", SqlDbType.NVarChar, CreatedBy);
            queryParameters.Append(", CreatedBy = @CreatedBy");
            sql.AddParameter("@CratedDate", SqlDbType.DateTime, CratedDate);
            queryParameters.Append(", CratedDate = @CratedDate");
            sql.AddParameter("@ModifiedBy", SqlDbType.NVarChar, ModifiedBy);
            queryParameters.Append(", ModifiedBy = @ModifiedBy");
            sql.AddParameter("@ModifiedDate", SqlDbType.DateTime, ModifiedDate);
            queryParameters.Append(", ModifiedDate = @ModifiedDate");
            sql.AddParameter("@Deleted", SqlDbType.Int, Deleted);
            queryParameters.Append(", Deleted = @Deleted");

            string query = String.Format("Update AGENT_KIND Set {0} Where IdAgentKind = @IdAgentKind", queryParameters.ToString());
            SqlDataReader reader = sql.ExecuteSqlReader(query);
        }

        public void Create()
        {
            SqlService sql = new SqlService();
            StringBuilder queryParameters = new StringBuilder();

            sql.AddParameter("@IdAgentKind", SqlDbType.Int, Id);
            queryParameters.Append("@IdAgentKind");

            sql.AddParameter("@AgentKindName", SqlDbType.NVarChar, AgentKindName);
            queryParameters.Append(", @AgentKindName");
            sql.AddParameter("@CreatedBy", SqlDbType.NVarChar, CreatedBy);
            queryParameters.Append(", @CreatedBy");
            sql.AddParameter("@CratedDate", SqlDbType.DateTime, CratedDate);
            queryParameters.Append(", @CratedDate");
            sql.AddParameter("@ModifiedBy", SqlDbType.NVarChar, ModifiedBy);
            queryParameters.Append(", @ModifiedBy");
            sql.AddParameter("@ModifiedDate", SqlDbType.DateTime, ModifiedDate);
            queryParameters.Append(", @ModifiedDate");
            sql.AddParameter("@Deleted", SqlDbType.Int, Deleted);
            queryParameters.Append(", @Deleted");

            string query = String.Format("Insert Into AGENT_KIND ({0}) Values ({1})", queryParameters.ToString().Replace("@", ""), queryParameters.ToString());
            SqlDataReader reader = sql.ExecuteSqlReader(query);
        }

        public static AGENT_KIND NewAGENT_KIND(int id)
        {
            AGENT_KIND newEntity = new AGENT_KIND();
            newEntity._id = id;

            return newEntity;
        }

        #region Public Properties
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string AgentKindName
        {
            get { return _agentKindName; }
            set { _agentKindName = value; }
        }

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public DateTime CratedDate
        {
            get { return _cratedDate; }
            set { _cratedDate = value; }
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

        public static AGENT_KIND GetAGENT_KIND(int id)
        {
            return new AGENT_KIND(id);
        }

        public static void Delete(int id)
        {
            SqlService sql = new SqlService();
            sql.AddParameter("@IdAgentKind", SqlDbType.Int, id);

            SqlDataReader reader = sql.ExecuteSqlReader("Delete AGENT_KIND Where IdAgentKind = @IdAgentKind");
        }
    }
    #endregion
}

