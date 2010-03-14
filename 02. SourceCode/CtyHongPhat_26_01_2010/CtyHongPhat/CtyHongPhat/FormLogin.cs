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
    public partial class FormLogin : Form
    {
        private bool isOK = false;
        private int isNotOK = 0;
        private Database database = new Database();
        public FormMain formMain = null;

        public bool IsOK
        {
            get
            {
                return this.isOK;
            }
        }
        public string UserName
        {
            get
            {
                return this.textBoxUserName.Text;
            }
            set
            {
                this.textBoxUserName.Text = value;
            }
        }
        public FormLogin(FormMain main)
        {
            this.formMain = main;
            InitializeComponent();
            if (!this.InitialConnection()) return;
        }
        public FormLogin()
        {
            InitializeComponent();
            if (!this.InitialConnection()) return;
        }

        public void SetUserNameReadOnly()
        {
            this.textBoxUserName.ReadOnly = true;
            this.textBoxPassword.SelectAll();
            this.textBoxPassword.Focus();
            this.Activate();
        }
        private bool InitialConnection()
        {
            Config.DataSource = SystemConfig.GetValue(SYSTEM_CONFIG.DATASOURCE);
            Config.InitialCatalog = SystemConfig.GetValue(SYSTEM_CONFIG.INITIALCATALOG);
            Config.UserName = SystemConfig.GetValue(SYSTEM_CONFIG.USERNAME);
            Config.Password = SystemConfig.GetValue(SYSTEM_CONFIG.PASSWORD);

            if (Config.DataSource == "" || Config.InitialCatalog == "" || Config.UserName == "" || Config.Password == "")
            {
                MessageBox.Error(this, "Không thể truy cập cơ sở dữ liệu");
                return false;
            }

            string connStr = "Data Source=" + Config.DataSource + ";Initial Catalog=" + Config.InitialCatalog + ";User ID=" + Config.UserName + ";Password=" + Config.Password;
            //string connStr = "Data Source=" + Config.DataSource + ";Initial Catalog=" + Config.InitialCatalog + ";Integrated Security=True"  + ";User ID=" + Config.UserName + ";Password=" + Config.Password;
            SqlConnection sqlConn = new SqlConnection(connStr);
            try
            {
                sqlConn.Open();
            }
            catch
            {
                MessageBox.Error(this, "Không thể truy cập cơ sở dữ liệu!");
                return false;
            }
            finally
            {
                sqlConn.Close();
            }

            return true;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (this.textBoxUserName.Text.Length <= 0)
            {
                MessageBox.Error(this, "Nhập vào tên đăng nhập");
                this.textBoxUserName.SelectAll();
                this.textBoxUserName.Focus();
                this.Activate();
                return;
            }

            if (this.textBoxPassword.Text.Length <= 0)
            {
                MessageBox.Error(this, "Nhập vào mật khẩu");
                this.textBoxPassword.SelectAll();
                this.textBoxPassword.Focus();
                this.Activate();
                return;
            }

            this.textBoxUserName.Text = this.textBoxUserName.Text.ToUpper();
            bool checklogin = false;
            try
            {
                checklogin = database.CheckUserPassword(this.textBoxUserName.Text, this.textBoxPassword.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Error(this, ex.ToString());
                checklogin = false;
            }

            if (checklogin)
            {
                this.isOK = true;
                if (this.formMain != null)
                {
                    //prcess get userfunctions
                    this.Close();
                    return;
                }
                else this.Close();
            }
            else
            {
                MessageBox.Error(this, "Tên đăng nhập hoặc mật khẩu không đúng");
                this.textBoxUserName.SelectAll();
                this.textBoxPassword.SelectAll();
                this.textBoxUserName.Focus();
                this.Activate();
                this.FormLogin_Shown(sender, e);
                isNotOK += 1;
                if (isNotOK >= 3)
                    Application.Exit();
            }


        }
        private void FormLogin_Shown(object sender, EventArgs e)
        {
            if (this.textBoxUserName.ReadOnly == true)
                this.textBoxPassword.Focus();
        }
        private void buttonConfig_Click(object sender, EventArgs e)
        {
            FormAuthenticate frm = new FormAuthenticate(false);
            frm.ShowDialog();
        }
    }
}
