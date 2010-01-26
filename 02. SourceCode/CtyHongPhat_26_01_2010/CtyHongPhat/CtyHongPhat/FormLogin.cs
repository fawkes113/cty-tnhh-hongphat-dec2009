using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CtyHongPhat
{
    public partial class FormLogin : Form
    {
        private bool isOK = false;
        private int isNotOK = 0;
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
        }
        public FormLogin()
        {
            InitializeComponent();
        }

        public void SetUserNameReadOnly()
        {
            this.textBoxUserName.ReadOnly = true;
            this.textBoxPassword.SelectAll();
            this.textBoxPassword.Focus();
            this.Activate();
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
                //checklogin = UserController.CheckUserPassword(this.textBoxUserName.Text, this.textBoxPassword.Text);
                checklogin = true;
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
