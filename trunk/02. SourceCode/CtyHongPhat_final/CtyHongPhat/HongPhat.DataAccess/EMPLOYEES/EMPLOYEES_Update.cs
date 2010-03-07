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
	#region EMPLOYEES_Update Wrapper
    /// <summary>
    /// This class is a wrapper for the EMPLOYEES_Update stored procedure.
    /// </summary>
    public class EMPLOYEES_Update
    {
		#region Member Variables
		protected string _connectionString = String.Empty;
		protected int _recordsAffected = -1;
		protected int _returnValue = 0;
		protected SqlInt32 _employeeId = SqlInt32.Null;
		protected bool _employeeIdSet = false;
		protected SqlString _employeeName = SqlString.Null;
		protected bool _employeeNameSet = false;
		protected SqlDecimal _salary = SqlDecimal.Null;
		protected bool _salarySet = false;
		protected SqlInt32 _deleted = SqlInt32.Null;
		protected bool _deletedSet = false;
		protected SqlString _position = SqlString.Null;
		protected bool _positionSet = false;
		#endregion
		
		#region Constructors
		public EMPLOYEES_Update()
		{
		}
		
		public EMPLOYEES_Update(string connectionString)
		{
			this.ConnectionString = connectionString;
		}
		#endregion
		
		#region Public Properties
		/// <summary>
		/// The connection string to use when executing the EMPLOYEES_Update stored procedure.
		/// </summary>
		public string ConnectionString
		{
			get {return _connectionString;}
			set {_connectionString = value;}
		}
		
		/// <summary>
		/// Gets the return value from the EMPLOYEES_Update stored procedure.
		/// </summary>
		public int ReturnValue
		{
			get {return _returnValue;}
		}
		
		/// <summary>
		/// Gets the number of rows changed, inserted, or deleted by execution of the EMPLOYEES_Update stored procedure.
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

		/// <summary>
		/// 
		/// </summary>
		public SqlString EmployeeName
		{
			get {return _employeeName;}
			set
			{
				_employeeName = value;
				_employeeNameSet = true;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public SqlDecimal Salary
		{
			get {return _salary;}
			set
			{
				_salary = value;
				_salarySet = true;
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
		public SqlString Position
		{
			get {return _position;}
			set
			{
				_position = value;
				_positionSet = true;
			}
		}
		#endregion
		
		#region Execute Methods
		/// <summary>
		/// This method calls the EMPLOYEES_Update stored procedure.
		/// </summary>
		public virtual void Execute()
		{
			SqlCommand cmd = new SqlCommand();
			
			System.Diagnostics.Debug.Assert(this.ConnectionString.Length != 0, "You must first set the ConnectionString property before calling this method.");
			SqlConnection cn = new SqlConnection(this.ConnectionString);
			
			try
			{
				cmd.Connection = cn;
				cmd.CommandText = "[dbo].[EMPLOYEES_Update]";
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
				
				SqlParameter prmEmployeeName = cmd.Parameters.Add("@EmployeeName", SqlDbType.NVarChar);
				prmEmployeeName.Direction = ParameterDirection.Input;
					prmEmployeeName.Size = 250;
				if (_employeeNameSet == true || this.EmployeeName.IsNull == false)
				{
					prmEmployeeName.Value = this.EmployeeName;
				}
				
				SqlParameter prmSalary = cmd.Parameters.Add("@Salary", SqlDbType.Decimal);
				prmSalary.Direction = ParameterDirection.Input;
					prmSalary.Precision = 18;
					prmSalary.Scale = 0;
				if (_salarySet == true || this.Salary.IsNull == false)
				{
					prmSalary.Value = this.Salary;
				}
				
				SqlParameter prmDeleted = cmd.Parameters.Add("@Deleted", SqlDbType.Int);
				prmDeleted.Direction = ParameterDirection.Input;
				if (_deletedSet == true || this.Deleted.IsNull == false)
				{
					prmDeleted.Value = this.Deleted;
				}
				
				SqlParameter prmPosition = cmd.Parameters.Add("@Position", SqlDbType.NVarChar);
				prmPosition.Direction = ParameterDirection.Input;
					prmPosition.Size = 250;
				if (_positionSet == true || this.Position.IsNull == false)
				{
					prmPosition.Value = this.Position;
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
		/// This method calls the EMPLOYEES_Update stored procedure.
		/// </summary>
		/// <param name="connectionString">The connection string to use</param>
		/// <param name="employeeId"></param>
		/// <param name="employeeName"></param>
		/// <param name="salary"></param>
		/// <param name="deleted"></param>
		/// <param name="position"></param>
		public static void Execute(
				#region Parameters
				string connectionString,
				SqlInt32 employeeId,
				SqlString employeeName,
				SqlDecimal salary,
				SqlInt32 deleted,
				SqlString position
				#endregion
		    )
		{
			EMPLOYEES_Update eMPLOYEES_Update = new EMPLOYEES_Update();
			
			#region Assign Property Values
			eMPLOYEES_Update.ConnectionString = connectionString;
			eMPLOYEES_Update.EmployeeId = employeeId;
			eMPLOYEES_Update.EmployeeName = employeeName;
			eMPLOYEES_Update.Salary = salary;
			eMPLOYEES_Update.Deleted = deleted;
			eMPLOYEES_Update.Position = position;
			#endregion
			
			eMPLOYEES_Update.Execute();
			
			#region Get Property Values
			
			#endregion
		}
		#endregion
	}
	#endregion
}