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
	#region USERS_Insert Wrapper
    /// <summary>
    /// This class is a wrapper for the USERS_Insert stored procedure.
    /// </summary>
    public class USERS_Insert
    {
		#region Member Variables
		protected string _connectionString = String.Empty;
		protected int _recordsAffected = -1;
		protected int _returnValue = 0;
		protected SqlInt32 _userId = SqlInt32.Null;
		protected bool _userIdSet = false;
		protected SqlString _userName = SqlString.Null;
		protected bool _userNameSet = false;
		protected SqlString _userPassword = SqlString.Null;
		protected bool _userPasswordSet = false;
		protected SqlInt32 _deleted = SqlInt32.Null;
		protected bool _deletedSet = false;
		protected SqlInt32 _employeeId = SqlInt32.Null;
		protected bool _employeeIdSet = false;
		#endregion
		
		#region Constructors
		public USERS_Insert()
		{
		}
		
		public USERS_Insert(string connectionString)
		{
			this.ConnectionString = connectionString;
		}
		#endregion
		
		#region Public Properties
		/// <summary>
		/// The connection string to use when executing the USERS_Insert stored procedure.
		/// </summary>
		public string ConnectionString
		{
			get {return _connectionString;}
			set {_connectionString = value;}
		}
		
		/// <summary>
		/// Gets the return value from the USERS_Insert stored procedure.
		/// </summary>
		public int ReturnValue
		{
			get {return _returnValue;}
		}
		
		/// <summary>
		/// Gets the number of rows changed, inserted, or deleted by execution of the USERS_Insert stored procedure.
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

		/// <summary>
		/// 
		/// </summary>
		public SqlString UserName
		{
			get {return _userName;}
			set
			{
				_userName = value;
				_userNameSet = true;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public SqlString UserPassword
		{
			get {return _userPassword;}
			set
			{
				_userPassword = value;
				_userPasswordSet = true;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public SqlInt32 Deleted
		{
			get {return _deleted;}
			set
			{
				_deleted = value;
				_deletedSet = true;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public SqlInt32 EmployeeId
		{
			get {return _employeeId;}
			set
			{
				_employeeId = value;
				_employeeIdSet = true;
			}
		}
		#endregion
		
		#region Execute Methods
		/// <summary>
		/// This method calls the USERS_Insert stored procedure.
		/// </summary>
		public virtual void Execute()
		{
			SqlCommand cmd = new SqlCommand();
			
			System.Diagnostics.Debug.Assert(this.ConnectionString.Length != 0, "You must first set the ConnectionString property before calling this method.");
			SqlConnection cn = new SqlConnection(this.ConnectionString);
			
			try
			{
				cmd.Connection = cn;
				cmd.CommandText = "[dbo].[USERS_Insert]";
				cmd.CommandType = CommandType.StoredProcedure;
				
				#region Populate Parameters
				SqlParameter prmReturnValue = cmd.Parameters.Add("@RETURN_VALUE", SqlDbType.Int);
				prmReturnValue.Direction = ParameterDirection.ReturnValue;
				
				SqlParameter prmUserId = cmd.Parameters.Add("@UserId", SqlDbType.Int);
				if (_userIdSet == true)
				{
				prmUserId.Direction = ParameterDirection.InputOutput;
				}
				else
				{
					prmUserId.Direction = ParameterDirection.Output;
				}
				if (_userIdSet == true || this.UserId.IsNull == false)
				{
					prmUserId.Value = this.UserId;
				}
				
				SqlParameter prmUserName = cmd.Parameters.Add("@UserName", SqlDbType.NVarChar);
				prmUserName.Direction = ParameterDirection.Input;
					prmUserName.Size = 50;
				if (_userNameSet == true || this.UserName.IsNull == false)
				{
					prmUserName.Value = this.UserName;
				}
				
				SqlParameter prmUserPassword = cmd.Parameters.Add("@UserPassword", SqlDbType.NVarChar);
				prmUserPassword.Direction = ParameterDirection.Input;
					prmUserPassword.Size = 50;
				if (_userPasswordSet == true || this.UserPassword.IsNull == false)
				{
					prmUserPassword.Value = this.UserPassword;
				}
				
				SqlParameter prmDeleted = cmd.Parameters.Add("@Deleted", SqlDbType.Int);
				prmDeleted.Direction = ParameterDirection.Input;
				if (_deletedSet == true || this.Deleted.IsNull == false)
				{
					prmDeleted.Value = this.Deleted;
				}
				
				SqlParameter prmEmployeeId = cmd.Parameters.Add("@EmployeeId", SqlDbType.Int);
				prmEmployeeId.Direction = ParameterDirection.Input;
				if (_employeeIdSet == true || this.EmployeeId.IsNull == false)
				{
					prmEmployeeId.Value = this.EmployeeId;
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
				
				if (prmUserId != null && prmUserId.Value != null)
				{
					if (prmUserId.Value is SqlInt32)
					{
						this.UserId = (SqlInt32)prmUserId.Value;
					}
					else
					{
						if (prmUserId.Value != DBNull.Value)
						{
							this.UserId = new SqlInt32((int)prmUserId.Value);
						}
						else
						{
							this.UserId = SqlInt32.Null;
						}
					}
				}
				else
				{
					this.UserId = SqlInt32.Null;
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
		/// This method calls the USERS_Insert stored procedure.
		/// </summary>
		/// <param name="connectionString">The connection string to use</param>
		/// <param name="userName"></param>
		/// <param name="userPassword"></param>
		/// <param name="deleted"></param>
		/// <param name="employeeId"></param>
		/// <param name="userId"></param>
		public static void Execute(
				#region Parameters
				string connectionString,
				SqlString userName,
				SqlString userPassword,
				SqlInt32 deleted,
				SqlInt32 employeeId,
				ref SqlInt32 userId
				#endregion
		    )
		{
			USERS_Insert uSERS_Insert = new USERS_Insert();
			
			#region Assign Property Values
			uSERS_Insert.ConnectionString = connectionString;
			uSERS_Insert.UserId = userId;
			uSERS_Insert.UserName = userName;
			uSERS_Insert.UserPassword = userPassword;
			uSERS_Insert.Deleted = deleted;
			uSERS_Insert.EmployeeId = employeeId;
			#endregion
			
			uSERS_Insert.Execute();
			
			#region Get Property Values
			userId = uSERS_Insert.UserId;
			#endregion
		}
		#endregion
	}
	#endregion
}