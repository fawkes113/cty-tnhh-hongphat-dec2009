//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by CodeSmith.
//
//     Date:    1/13/2010
//     Time:    10:18 PM
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
	#region EMPLOYEES_Delete Wrapper
    /// <summary>
    /// This class is a wrapper for the EMPLOYEES_Delete stored procedure.
    /// </summary>
    public class EMPLOYEES_Delete
    {
		#region Member Variables
		protected string _connectionString = String.Empty;
		protected int _recordsAffected = -1;
		protected int _returnValue = 0;
		protected SqlInt32 _employeeId = SqlInt32.Null;
		protected bool _employeeIdSet = false;
		#endregion
		
		#region Constructors
		public EMPLOYEES_Delete()
		{
		}
		
		public EMPLOYEES_Delete(string connectionString)
		{
			this.ConnectionString = connectionString;
		}
		#endregion
		
		#region Public Properties
		/// <summary>
		/// The connection string to use when executing the EMPLOYEES_Delete stored procedure.
		/// </summary>
		public string ConnectionString
		{
			get {return _connectionString;}
			set {_connectionString = value;}
		}
		
		/// <summary>
		/// Gets the return value from the EMPLOYEES_Delete stored procedure.
		/// </summary>
		public int ReturnValue
		{
			get {return _returnValue;}
		}
		
		/// <summary>
		/// Gets the number of rows changed, inserted, or deleted by execution of the EMPLOYEES_Delete stored procedure.
		/// </summary>
		public int RecordsAffected
		{
			get {return _recordsAffected;}
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
		/// This method calls the EMPLOYEES_Delete stored procedure.
		/// </summary>
		public virtual void Execute()
		{
			SqlCommand cmd = new SqlCommand();
			
			System.Diagnostics.Debug.Assert(this.ConnectionString.Length != 0, "You must first set the ConnectionString property before calling this method.");
			SqlConnection cn = new SqlConnection(this.ConnectionString);
			
			try
			{
				cmd.Connection = cn;
				cmd.CommandText = "[dbo].[EMPLOYEES_Delete]";
				cmd.CommandType = CommandType.StoredProcedure;
				
				#region Populate Parameters
				SqlParameter prmReturnValue = cmd.Parameters.Add("@RETURN_VALUE", SqlDbType.Int);
				prmReturnValue.Direction = ParameterDirection.ReturnValue;
				
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
		/// This method calls the EMPLOYEES_Delete stored procedure.
		/// </summary>
		/// <param name="connectionString">The connection string to use</param>
		/// <param name="employeeId"></param>
		public static void Execute(
				#region Parameters
				string connectionString,
				SqlInt32 employeeId
				#endregion
		    )
		{
			EMPLOYEES_Delete eMPLOYEES_Delete = new EMPLOYEES_Delete();
			
			#region Assign Property Values
			eMPLOYEES_Delete.ConnectionString = connectionString;
			eMPLOYEES_Delete.EmployeeId = employeeId;
			#endregion
			
			eMPLOYEES_Delete.Execute();
			
			#region Get Property Values
			
			#endregion
		}
		#endregion
	}
	#endregion
}
