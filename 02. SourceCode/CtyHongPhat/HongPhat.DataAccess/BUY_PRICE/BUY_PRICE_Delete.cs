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
	#region BUY_PRICE_Delete Wrapper
    /// <summary>
    /// This class is a wrapper for the BUY_PRICE_Delete stored procedure.
    /// </summary>
    public class BUY_PRICE_Delete
    {
		#region Member Variables
		protected string _connectionString = String.Empty;
		protected int _recordsAffected = -1;
		protected int _returnValue = 0;
		protected SqlInt32 _id = SqlInt32.Null;
		protected bool _idSet = false;
		#endregion
		
		#region Constructors
		public BUY_PRICE_Delete()
		{
		}
		
		public BUY_PRICE_Delete(string connectionString)
		{
			this.ConnectionString = connectionString;
		}
		#endregion
		
		#region Public Properties
		/// <summary>
		/// The connection string to use when executing the BUY_PRICE_Delete stored procedure.
		/// </summary>
		public string ConnectionString
		{
			get {return _connectionString;}
			set {_connectionString = value;}
		}
		
		/// <summary>
		/// Gets the return value from the BUY_PRICE_Delete stored procedure.
		/// </summary>
		public int ReturnValue
		{
			get {return _returnValue;}
		}
		
		/// <summary>
		/// Gets the number of rows changed, inserted, or deleted by execution of the BUY_PRICE_Delete stored procedure.
		/// </summary>
		public int RecordsAffected
		{
			get {return _recordsAffected;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		public SqlInt32 Id
		{
			get {return _id;}
			set
			{
				_id = value;
				_idSet = true;
			}
		}
		#endregion
		
		#region Execute Methods
		/// <summary>
		/// This method calls the BUY_PRICE_Delete stored procedure.
		/// </summary>
		public virtual void Execute()
		{
			SqlCommand cmd = new SqlCommand();
			
			System.Diagnostics.Debug.Assert(this.ConnectionString.Length != 0, "You must first set the ConnectionString property before calling this method.");
			SqlConnection cn = new SqlConnection(this.ConnectionString);
			
			try
			{
				cmd.Connection = cn;
				cmd.CommandText = "[dbo].[BUY_PRICE_Delete]";
				cmd.CommandType = CommandType.StoredProcedure;
				
				#region Populate Parameters
				SqlParameter prmReturnValue = cmd.Parameters.Add("@RETURN_VALUE", SqlDbType.Int);
				prmReturnValue.Direction = ParameterDirection.ReturnValue;
				
				SqlParameter prmId = cmd.Parameters.Add("@Id", SqlDbType.Int);
				prmId.Direction = ParameterDirection.Input;
				if (_idSet == true || this.Id.IsNull == false)
				{
					prmId.Value = this.Id;
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
		/// This method calls the BUY_PRICE_Delete stored procedure.
		/// </summary>
		/// <param name="connectionString">The connection string to use</param>
		/// <param name="id"></param>
		public static void Execute(
				#region Parameters
				string connectionString,
				SqlInt32 id
				#endregion
		    )
		{
			BUY_PRICE_Delete bUY_PRICE_Delete = new BUY_PRICE_Delete();
			
			#region Assign Property Values
			bUY_PRICE_Delete.ConnectionString = connectionString;
			bUY_PRICE_Delete.Id = id;
			#endregion
			
			bUY_PRICE_Delete.Execute();
			
			#region Get Property Values
			
			#endregion
		}
		#endregion
	}
	#endregion
}
