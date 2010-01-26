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
	#region DEBT_Insert Wrapper
    /// <summary>
    /// This class is a wrapper for the DEBT_Insert stored procedure.
    /// </summary>
    public class DEBT_Insert
    {
		#region Member Variables
		protected string _connectionString = String.Empty;
		protected int _recordsAffected = -1;
		protected int _returnValue = 0;
		protected SqlInt32 _debtId = SqlInt32.Null;
		protected bool _debtIdSet = false;
		protected SqlDecimal _oldDebtValue = SqlDecimal.Null;
		protected bool _oldDebtValueSet = false;
		protected SqlDecimal _newDebtValue = SqlDecimal.Null;
		protected bool _newDebtValueSet = false;
		protected SqlDecimal _payment = SqlDecimal.Null;
		protected bool _paymentSet = false;
		protected SqlDecimal _currentDebtValue = SqlDecimal.Null;
		protected bool _currentDebtValueSet = false;
		protected SqlInt32 _customerId = SqlInt32.Null;
		protected bool _customerIdSet = false;
		protected SqlInt32 _deleted = SqlInt32.Null;
		protected bool _deletedSet = false;
		protected SqlString _createdBy = SqlString.Null;
		protected bool _createdBySet = false;
		protected SqlDateTime _createDate = SqlDateTime.Null;
		protected bool _createDateSet = false;
		protected SqlString _modifiedBy = SqlString.Null;
		protected bool _modifiedBySet = false;
		protected SqlDateTime _modifiedDate = SqlDateTime.Null;
		protected bool _modifiedDateSet = false;
		protected SqlInt32 _debtKind = SqlInt32.Null;
		protected bool _debtKindSet = false;
		protected SqlString _note = SqlString.Null;
		protected bool _noteSet = false;
		#endregion
		
		#region Constructors
		public DEBT_Insert()
		{
		}
		
		public DEBT_Insert(string connectionString)
		{
			this.ConnectionString = connectionString;
		}
		#endregion
		
		#region Public Properties
		/// <summary>
		/// The connection string to use when executing the DEBT_Insert stored procedure.
		/// </summary>
		public string ConnectionString
		{
			get {return _connectionString;}
			set {_connectionString = value;}
		}
		
		/// <summary>
		/// Gets the return value from the DEBT_Insert stored procedure.
		/// </summary>
		public int ReturnValue
		{
			get {return _returnValue;}
		}
		
		/// <summary>
		/// Gets the number of rows changed, inserted, or deleted by execution of the DEBT_Insert stored procedure.
		/// </summary>
		public int RecordsAffected
		{
			get {return _recordsAffected;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		public SqlInt32 DebtId
		{
			get {return _debtId;}
			set
			{
				_debtId = value;
				_debtIdSet = true;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public SqlDecimal OldDebtValue
		{
			get {return _oldDebtValue;}
			set
			{
				_oldDebtValue = value;
				_oldDebtValueSet = true;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public SqlDecimal NewDebtValue
		{
			get {return _newDebtValue;}
			set
			{
				_newDebtValue = value;
				_newDebtValueSet = true;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public SqlDecimal Payment
		{
			get {return _payment;}
			set
			{
				_payment = value;
				_paymentSet = true;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public SqlDecimal CurrentDebtValue
		{
			get {return _currentDebtValue;}
			set
			{
				_currentDebtValue = value;
				_currentDebtValueSet = true;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public SqlInt32 CustomerId
		{
			get {return _customerId;}
			set
			{
				_customerId = value;
				_customerIdSet = true;
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
		public SqlString CreatedBy
		{
			get {return _createdBy;}
			set
			{
				_createdBy = value;
				_createdBySet = true;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public SqlDateTime CreateDate
		{
			get {return _createDate;}
			set
			{
				_createDate = value;
				_createDateSet = true;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public SqlString ModifiedBy
		{
			get {return _modifiedBy;}
			set
			{
				_modifiedBy = value;
				_modifiedBySet = true;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public SqlDateTime ModifiedDate
		{
			get {return _modifiedDate;}
			set
			{
				_modifiedDate = value;
				_modifiedDateSet = true;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public SqlInt32 DebtKind
		{
			get {return _debtKind;}
			set
			{
				_debtKind = value;
				_debtKindSet = true;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public SqlString Note
		{
			get {return _note;}
			set
			{
				_note = value;
				_noteSet = true;
			}
		}
		#endregion
		
		#region Execute Methods
		/// <summary>
		/// This method calls the DEBT_Insert stored procedure.
		/// </summary>
		public virtual void Execute()
		{
			SqlCommand cmd = new SqlCommand();
			
			System.Diagnostics.Debug.Assert(this.ConnectionString.Length != 0, "You must first set the ConnectionString property before calling this method.");
			SqlConnection cn = new SqlConnection(this.ConnectionString);
			
			try
			{
				cmd.Connection = cn;
				cmd.CommandText = "[dbo].[DEBT_Insert]";
				cmd.CommandType = CommandType.StoredProcedure;
				
				#region Populate Parameters
				SqlParameter prmReturnValue = cmd.Parameters.Add("@RETURN_VALUE", SqlDbType.Int);
				prmReturnValue.Direction = ParameterDirection.ReturnValue;
				
				SqlParameter prmDebtId = cmd.Parameters.Add("@DebtId", SqlDbType.Int);
				if (_debtIdSet == true)
				{
				prmDebtId.Direction = ParameterDirection.InputOutput;
				}
				else
				{
					prmDebtId.Direction = ParameterDirection.Output;
				}
				if (_debtIdSet == true || this.DebtId.IsNull == false)
				{
					prmDebtId.Value = this.DebtId;
				}
				
				SqlParameter prmOldDebtValue = cmd.Parameters.Add("@OldDebtValue", SqlDbType.Decimal);
				prmOldDebtValue.Direction = ParameterDirection.Input;
					prmOldDebtValue.Precision = 18;
					prmOldDebtValue.Scale = 0;
				if (_oldDebtValueSet == true || this.OldDebtValue.IsNull == false)
				{
					prmOldDebtValue.Value = this.OldDebtValue;
				}
				
				SqlParameter prmNewDebtValue = cmd.Parameters.Add("@NewDebtValue", SqlDbType.Decimal);
				prmNewDebtValue.Direction = ParameterDirection.Input;
					prmNewDebtValue.Precision = 18;
					prmNewDebtValue.Scale = 0;
				if (_newDebtValueSet == true || this.NewDebtValue.IsNull == false)
				{
					prmNewDebtValue.Value = this.NewDebtValue;
				}
				
				SqlParameter prmPayment = cmd.Parameters.Add("@Payment", SqlDbType.Decimal);
				prmPayment.Direction = ParameterDirection.Input;
					prmPayment.Precision = 18;
					prmPayment.Scale = 0;
				if (_paymentSet == true || this.Payment.IsNull == false)
				{
					prmPayment.Value = this.Payment;
				}
				
				SqlParameter prmCurrentDebtValue = cmd.Parameters.Add("@CurrentDebtValue", SqlDbType.Decimal);
				prmCurrentDebtValue.Direction = ParameterDirection.Input;
					prmCurrentDebtValue.Precision = 18;
					prmCurrentDebtValue.Scale = 0;
				if (_currentDebtValueSet == true || this.CurrentDebtValue.IsNull == false)
				{
					prmCurrentDebtValue.Value = this.CurrentDebtValue;
				}
				
				SqlParameter prmCustomerId = cmd.Parameters.Add("@CustomerId", SqlDbType.Int);
				prmCustomerId.Direction = ParameterDirection.Input;
				if (_customerIdSet == true || this.CustomerId.IsNull == false)
				{
					prmCustomerId.Value = this.CustomerId;
				}
				
				SqlParameter prmDeleted = cmd.Parameters.Add("@Deleted", SqlDbType.Int);
				prmDeleted.Direction = ParameterDirection.Input;
				if (_deletedSet == true || this.Deleted.IsNull == false)
				{
					prmDeleted.Value = this.Deleted;
				}
				
				SqlParameter prmCreatedBy = cmd.Parameters.Add("@CreatedBy", SqlDbType.NVarChar);
				prmCreatedBy.Direction = ParameterDirection.Input;
					prmCreatedBy.Size = 250;
				if (_createdBySet == true || this.CreatedBy.IsNull == false)
				{
					prmCreatedBy.Value = this.CreatedBy;
				}
				
				SqlParameter prmCreateDate = cmd.Parameters.Add("@CreateDate", SqlDbType.DateTime);
				prmCreateDate.Direction = ParameterDirection.Input;
				if (_createDateSet == true || this.CreateDate.IsNull == false)
				{
					prmCreateDate.Value = this.CreateDate;
				}
				
				SqlParameter prmModifiedBy = cmd.Parameters.Add("@ModifiedBy", SqlDbType.NVarChar);
				prmModifiedBy.Direction = ParameterDirection.Input;
					prmModifiedBy.Size = 250;
				if (_modifiedBySet == true || this.ModifiedBy.IsNull == false)
				{
					prmModifiedBy.Value = this.ModifiedBy;
				}
				
				SqlParameter prmModifiedDate = cmd.Parameters.Add("@ModifiedDate", SqlDbType.DateTime);
				prmModifiedDate.Direction = ParameterDirection.Input;
				if (_modifiedDateSet == true || this.ModifiedDate.IsNull == false)
				{
					prmModifiedDate.Value = this.ModifiedDate;
				}
				
				SqlParameter prmDebtKind = cmd.Parameters.Add("@DebtKind", SqlDbType.Int);
				prmDebtKind.Direction = ParameterDirection.Input;
				if (_debtKindSet == true || this.DebtKind.IsNull == false)
				{
					prmDebtKind.Value = this.DebtKind;
				}
				
				SqlParameter prmNote = cmd.Parameters.Add("@Note", SqlDbType.Text);
				prmNote.Direction = ParameterDirection.Input;
					prmNote.Size = 16;
				if (_noteSet == true || this.Note.IsNull == false)
				{
					prmNote.Value = this.Note;
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
				
				if (prmDebtId != null && prmDebtId.Value != null)
				{
					if (prmDebtId.Value is SqlInt32)
					{
						this.DebtId = (SqlInt32)prmDebtId.Value;
					}
					else
					{
						if (prmDebtId.Value != DBNull.Value)
						{
							this.DebtId = new SqlInt32((int)prmDebtId.Value);
						}
						else
						{
							this.DebtId = SqlInt32.Null;
						}
					}
				}
				else
				{
					this.DebtId = SqlInt32.Null;
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
		/// This method calls the DEBT_Insert stored procedure.
		/// </summary>
		/// <param name="connectionString">The connection string to use</param>
		/// <param name="oldDebtValue"></param>
		/// <param name="newDebtValue"></param>
		/// <param name="payment"></param>
		/// <param name="currentDebtValue"></param>
		/// <param name="customerId"></param>
		/// <param name="deleted"></param>
		/// <param name="createdBy"></param>
		/// <param name="createDate"></param>
		/// <param name="modifiedBy"></param>
		/// <param name="modifiedDate"></param>
		/// <param name="debtKind"></param>
		/// <param name="note"></param>
		/// <param name="debtId"></param>
		public static void Execute(
				#region Parameters
				string connectionString,
				SqlDecimal oldDebtValue,
				SqlDecimal newDebtValue,
				SqlDecimal payment,
				SqlDecimal currentDebtValue,
				SqlInt32 customerId,
				SqlInt32 deleted,
				SqlString createdBy,
				SqlDateTime createDate,
				SqlString modifiedBy,
				SqlDateTime modifiedDate,
				SqlInt32 debtKind,
				SqlString note,
				ref SqlInt32 debtId
				#endregion
		    )
		{
			DEBT_Insert dEBT_Insert = new DEBT_Insert();
			
			#region Assign Property Values
			dEBT_Insert.ConnectionString = connectionString;
			dEBT_Insert.DebtId = debtId;
			dEBT_Insert.OldDebtValue = oldDebtValue;
			dEBT_Insert.NewDebtValue = newDebtValue;
			dEBT_Insert.Payment = payment;
			dEBT_Insert.CurrentDebtValue = currentDebtValue;
			dEBT_Insert.CustomerId = customerId;
			dEBT_Insert.Deleted = deleted;
			dEBT_Insert.CreatedBy = createdBy;
			dEBT_Insert.CreateDate = createDate;
			dEBT_Insert.ModifiedBy = modifiedBy;
			dEBT_Insert.ModifiedDate = modifiedDate;
			dEBT_Insert.DebtKind = debtKind;
			dEBT_Insert.Note = note;
			#endregion
			
			dEBT_Insert.Execute();
			
			#region Get Property Values
			debtId = dEBT_Insert.DebtId;
			#endregion
		}
		#endregion
	}
	#endregion
}