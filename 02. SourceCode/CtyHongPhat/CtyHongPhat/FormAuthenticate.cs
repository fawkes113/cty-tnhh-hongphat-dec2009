using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CtyHongPhat.Utility;

namespace CtyHongPhat
{
    public partial class FormAuthenticate : Form
    {
        private bool iRestart = false;

        public FormAuthenticate()
        {
            InitializeComponent();
        }
        public FormAuthenticate(bool iRestart)
        {
            InitializeComponent();
            this.iRestart = iRestart;
        }

        private bool TestConnection()
        {
            string connString = string.Format("Data Source={0}; Initial Catalog={1}; User ID={2}; Password={3}",
                tbxDatabase.Text.Trim(),
                tbxDatabase.Text.Trim(),
                tbxUsername.Text.Trim(),
                tbxPassword.Text.Trim()
                );
            SqlConnection sqlConn = new SqlConnection(connString);

            try
            {
                sqlConn.Open();
                return true;
            }
            catch
            {
                MessageBox.Error(this, "Không kết nối được với cơ sở dữ liệu, hãy kiểm tra lại cấu hình");
                return false;
            }
            finally
            {
                sqlConn.Close();
            }
        }
        private bool TestValidation()
        {
            if (tbxServer.Text != "" && tbxDatabase.Text != "" && tbxUsername.Text != "" && tbxPassword.Text != "")
                return true;
            return false;
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            if (TestValidation())
            {
                if (TestConnection())
                    MessageBox.Infor(this, "Kết nối cơ sở dữ liệu thành công!");
            }
            else
            {
                MessageBox.Error(this, "Bạn phải nhập đầy đủ thông tin!");
                return;
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!TestConnection())
            {
                MessageBox.Error(this, "Bạn phải nhập đầy đủ thông tin!");
                return;
            }

            if (!TestConnection())
            {
                return;
            }

            try
            {
                Config.DataSource = tbxServer.Text.Trim();
                Config.InitialCatalog = tbxDatabase.Text.Trim();
                Config.UserName = tbxUsername.Text.Trim();
                Config.Password = tbxPassword.Text.Trim();

                SystemConfig.SetValue(SYSTEM_CONFIG.DATASOURCE, tbxServer.Text.Trim());
                SystemConfig.SetValue(SYSTEM_CONFIG.INITIALCATALOG, tbxDatabase.Text.Trim());
                SystemConfig.SetValue(SYSTEM_CONFIG.USERNAME, tbxUsername.Text.Trim());
                SystemConfig.SetValue(SYSTEM_CONFIG.PASSWORD, tbxPassword.Text.Trim());

                if (this.iRestart)
                {
                    MessageBox.Infor(this, "Đã cập nhật thành công. Hãy khởi động lại chương trình để cập nhật dữ liệu mới!");
                    Application.Exit();
                }
            }
            catch
            {
                MessageBox.Error(this, "Có lỗi. Không thể truy cập được cơ sở dữ liệu");
            }
        }
        private void FormAuthenticate_Load(object sender, EventArgs e)
        {
            this.tbxServer.Text = SystemConfig.GetValue(SYSTEM_CONFIG.DATASOURCE);
            this.tbxDatabase.Text = SystemConfig.GetValue(SYSTEM_CONFIG.INITIALCATALOG);
            this.tbxUsername.Text = SystemConfig.GetValue(SYSTEM_CONFIG.USERNAME);
            this.tbxPassword.Text = SystemConfig.GetValue(SYSTEM_CONFIG.PASSWORD);
        }
    }
}
