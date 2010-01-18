//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by CodeSmith.
//
//     Date:    1/13/2010
//     Time:    10:19 PM
//     Version: 5.0.0.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace HongPhat.DataAccess
{
	#region USERS_Delete Wrapper
    /// <summary>
    /// This class is a wrapper for the USERS_Delete stored procedure.
    /// </summary>
    public class USERS_Delete
    {
		#region Member Variables
		protected string _connectionString = String.Empty;
		protected int _recordsAffected = -1;
		protected int _returnValue = 0;
		protected SqlInt32 _userId = SqlInt32.Null;
		protected bool _userIdSet = false;
		#endregion
		
		#region Constructors
		public USERS_Delete()
		{
		}
		
		public USERS_Delete(string connectionString)
		{
			this.ConnectionString = connectionString;
		}
		#endregion
		
		#region Public Properties
		/// <summary>
		/// The connection string to use when executing the USERS_Delete stored procedure.
		/// </summary>
		public string ConnectionString
		{
			get {return _connectionString;}
			set {_connectionString = value;}
		}
		
		/// <summary>
		/// Gets the return value from the USERS_Delete stored procedure.
		/// </summary>
		public int ReturnValue
		{
			get {return _returnValue;}
		}
		
		/// <summary>
		/// Gets the number of rows changed, inserted, or deleted by execution of the USERS_Delete stored procedure.
		/// </summary>
		public int RecordsAffected
		{
			get {return _recordsAffected;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		public SqlInt32 UserId
		{
			get {return _userId;}
			set
			{
				_userId = value;
				_userIdSet = true;
			}
		}
		#endregion
		
		#region Execute Methods
		/// <summary>
		/// This method calls the USERS_Delete stored procedure.
		/// </summary>
		public virtual void Execute()
		{
			SqlCommand cmd = new SqlCommand();
			
			System.Diagnostics.Debug.Assert(this.ConnectionString.Length != 0, "You must first set the ConnectionString property before calling this method.");
			SqlConnection cn = new SqlConnection(this.ConnectionString);
			
			try
			{
				cmd.Connection = cn;
				cmd.CommandText = "[dbo].[USERS_Delete]";
				cmd.CommandType = CommandType.StoredProcedure;
				
				#region Populate Parameters
				SqlParameter prmReturnValue = cmd.Parameters.Add("@RETURN_VALUE", SqlDbType.Int);
				prmReturnValue.Direction = ParameterDirection.ReturnValue;
				
				SqlParameter prmUserId = cmd.Parameters.Add("@UserId", SqlDbType.Int);
				prmUserId.Direction = ParameterDirection.Input;
				if (_userIdSet == true || this.UserId.IsNull == false)
				{
					prmUserId.Value = this.UserId;
				}
				#endregion
				
				#region Execute Command
				cn.Open();
				_recordsAffected = cmd.ExecuteNonQuery();
				#endregion
				
				#region Get Output Parameters
				if (prmReturnValue.Value != null && prmReturnValue.Value != DBNull.Value)
				{
					_returnValue = (int)prmReturnValue.Value;
				}
				
				#endregion
			}
			finally
			{
				if (cn.State == ConnectionState.Open)
				{
					cn.Close();
				}
				
				cn.Dispose();
				cmd.Dispose();
			}
		}
		
		/// <summary>
		/// This method calls the USERS_Delete stored procedure.
		/// </summary>
		/// <param name="connectionString">The connection string to use</param>
		/// <param name="userId"></param>
		public static void Execute(
				#region Parameters
				string connectionString,
				SqlInt32 userId
				#endregion
		    )
		{
			USERS_Delete uSERS_Delete = new USERS_Delete();
			
			#region Assign Property Values
			uSERS_Delete.ConnectionString = connectionString;
			uSERS_Delete.UserId = userId;
			#endregion
			
			uSERS_Delete.Execute();
			
			#region Get Property Values
			
			#endregion
		}
		#endregion
	}
	#endregion
}
