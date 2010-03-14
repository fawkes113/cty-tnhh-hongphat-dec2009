using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CtyHongPhat.Utility;
using CtyHongPhatDatabase.Table;
using CtyHongPhat.Report;

namespace CtyHongPhat
{
    public partial class FormManageEmployee : Form
    {
        private string employeeName = "";
        private Database database = new Database();

        public FormManageEmployee()
        {
            InitializeComponent();
        }
        public FormManageEmployee(string employeeName)
        {
            InitializeComponent();
            this.employeeName = employeeName;
            Init();
        }

        private void Init()
        {
            BindData();
        }
        private void BindData()
        {
            try
            {
                this.dataGridViewListEmployees.Rows.Clear();
                this.dataGridViewListEmployees.DataSource = null;

                ArrayList listEmployees = null;
                listEmployees = database.EmloyeeGetAll();
                if (listEmployees != null && listEmployees.Count > 0)
                {
                    for (int i = 0; i < listEmployees.Count; i++)
                    {
                        EmployeesInfo employee = (EmployeesInfo)listEmployees[i];
                        this.dataGridViewListEmployees.Rows.Add(false,
                                employee.EmployeeId,
                                employee.EmployeeName,
                                employee.Birthday.ToString("dd/MM/yyyy"),
                                NumberViewer.InsertComma(employee.Salary.ToString()),
                                employee.Position,
                                employee.Address

                            );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Error(this, ex.ToString());
            }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeesInfo employeeInfo = new EmployeesInfo();
                employeeInfo.EmployeeName = this.textBoxName.Text;
                employeeInfo.Address = this.textBoxAddress.Text;
                employeeInfo.Birthday = this.dateTimePickerBirthday.Value;
                employeeInfo.Position = this.textBoxPosition.Text;
                employeeInfo.Salary = this.numericUpDownSalary.Value;
                employeeInfo.Deleted = 0;

                int employeeId = database.EmployeeAdd(employeeInfo);

                if (employeeId < 0)
                {
                    MessageBox.Error(this, "Có lỗi trong quá trình thêm nhân viên");
                    return;
                }
                this.BindData();
            }
            catch (Exception ex)
            {
                MessageBox.Error(this, ex.ToString());
            }
            

        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewListEmployees.SelectedRows != null && this.dataGridViewListEmployees.SelectedRows.Count > 0)
            {
                DataGridViewRow row = this.dataGridViewListEmployees.SelectedRows[0];

                try
                {
                    EmployeesInfo employeeInfo = database.EmployeeGetById(int.Parse(row.Cells[ColumnEmployeeId.Index].Value.ToString()));
                    if (employeeInfo != null)
                    {
                        employeeInfo.EmployeeName = this.textBoxName.Text;
                        employeeInfo.Birthday = this.dateTimePickerBirthday.Value;
                        employeeInfo.Position = this.textBoxPosition.Text;
                        employeeInfo.Salary = this.numericUpDownSalary.Value;
                        employeeInfo.Address = this.textBoxAddress.Text;

                        database.EmployeeUpdate(employeeInfo);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Error(this, ex.ToString());
                }
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.dataGridViewListEmployees.Rows.Count; i++)
            {
                if ((bool)this.dataGridViewListEmployees.Rows[i].Cells[ColumnChecked.Index].Value == true)
                {
                    DataGridViewRow row = this.dataGridViewListEmployees.Rows[i];

                    int employeeId = int.Parse(row.Cells[ColumnEmployeeId.Index].Value.ToString());
                    try
                    {
                        database.EmployeeDelete(employeeId);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Error(this, ex.ToString());
                    }
                }
            }

            BindData();
        }
        private void dataGridViewListEmployees_SelectionChanged(object sender, EventArgs e)
        {
            if(this.dataGridViewListEmployees.SelectedRows != null && this.dataGridViewListEmployees.SelectedRows.Count > 0)
            {
                DataGridViewRow row = this.dataGridViewListEmployees.SelectedRows[0];

                try
                {
                    EmployeesInfo employeeInfo = database.EmployeeGetById(int.Parse(row.Cells[ColumnEmployeeId.Index].Value.ToString()));
                    if (employeeInfo != null)
                    {
                        this.textBoxName.Text = employeeInfo.EmployeeName;
                        this.dateTimePickerBirthday.Value = employeeInfo.Birthday;
                        this.numericUpDownSalary.Value = employeeInfo.Salary;
                        this.textBoxPosition.Text  = employeeInfo.Position;
                        this.textBoxAddress.Text = employeeInfo.Address;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Error(this, ex.ToString());
                }
            }
        }
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            this.BindData();
        }
        private void buttonPrint_Click(object sender, EventArgs e)
        {
            try
            {
                ArrayList listEmployees = database.EmloyeeGetAll();
                if (listEmployees != null && listEmployees.Count > 0)
                {
                    List<EmployessView> listEmployeesViews = new List<EmployessView>();
                    for (int i = 0; i < listEmployees.Count; i++)
                    {
                        EmployeesInfo employessInfo = (EmployeesInfo)listEmployees[i];
                        EmployessView employessView = new EmployessView();
                        employessView.EmployeeId = employessInfo.EmployeeId.ToString();
                        employessView.EmployeeName = employessInfo.EmployeeName;
                        employessView.Address = employessInfo.Address;
                        employessView.Birthday = employessInfo.Birthday.ToString("dd/MM/yyyy");
                        employessView.Deleted = employessInfo.Deleted;
                        employessView.Position = employessInfo.Position;
                        employessView.Salary = employessInfo.Salary;

                        listEmployeesViews.Add(employessView);

                    }

                    FormReportViewer reportViewer = new FormReportViewer();
                    CrystalDecisions.Shared.TableLogOnInfo tableLogOnInfo = new CrystalDecisions.Shared.TableLogOnInfo();
                    tableLogOnInfo.ConnectionInfo.ServerName = Config.DataSource;
                    tableLogOnInfo.ConnectionInfo.DatabaseName = Config.InitialCatalog;
                    tableLogOnInfo.ConnectionInfo.IntegratedSecurity = true;
                    tableLogOnInfo.ConnectionInfo.UserID = Config.UserName;
                    tableLogOnInfo.ConnectionInfo.Password = Config.Password;

                    CrystalReportListEmployees crystalReportListEmployees = new CrystalReportListEmployees();
                    for (int i = 0; i < crystalReportListEmployees.Database.Tables.Count; i++)
                    {
                        CrystalDecisions.CrystalReports.Engine.Table table = crystalReportListEmployees.Database.Tables[i];
                        table.ApplyLogOnInfo(tableLogOnInfo);
                    }
                    crystalReportListEmployees.SetDataSource(listEmployeesViews);
                    crystalReportListEmployees.DataDefinition.FormulaFields["f_printdate"].Text = "'" + DateTime.Now.ToString("dd/MM/yyyy") + "'";

                    reportViewer.Report.ReportSource = crystalReportListEmployees;
                    reportViewer.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Error(this, ex.ToString());
            }
        }

        public class EmployessView
        {
            private string employeesId;
            private string employeeName = String.Empty;
            private decimal salary;
            private int deleted;
            private string position = String.Empty;
            private string birthday;
            private string address;

            #region Public Properties
            public string EmployeeId
            {
                get { return employeesId; }
                set { employeesId = value; }
            }

            public string EmployeeName
            {
                get { return employeeName; }
                set { employeeName = value; }
            }

            public decimal Salary
            {
                get { return salary; }
                set { salary = value; }
            }

            public int Deleted
            {
                get { return deleted; }
                set { deleted = value; }
            }

            public string Position
            {
                get { return position; }
                set { position = value; }
            }

            public string Birthday
            {
                get { return birthday; }
                set { birthday = value; }
            }

            public string Address
            {
                get { return address; }
                set { address = value; }
            }
            #endregion
        }
    }
}
