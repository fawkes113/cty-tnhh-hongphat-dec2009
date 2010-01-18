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
    public partial class FormUserPasswordChange : Form
    {
        public string Username
        {
            get
            {
                return this.textBoxUsername.Text;
            }
            set
            {
                this.textBoxUsername.Text = value;
            }
        }

        public FormUserPasswordChange()
        {
            InitializeComponent();
        }

        public void SetUserNameReadOnly()
        {
            this.textBoxUsername.ReadOnly = true;
            this.textBoxPasswordOld.SelectAll();
            this.textBoxPasswordOld.Focus();
            this.Activate();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            String szUsername = this.textBoxUsername.Text;
            String szPasswordOld = this.textBoxPasswordOld.Text;
            String szPasswordNew = this.textBoxPasswordNew.Text;
            String szPasswordConfirm = this.textBoxPasswordConfirm.Text;

            // Kiem tra du lieu
            if (szUsername.Length <= 0)
            {
                MessageBox.Error(this, "Nhập vào tên đăng nhập");
                this.textBoxUsername.SelectAll();
                this.textBoxUsername.Focus();
                this.Activate();
                return;
            }

            if (szPasswordOld.Length <= 0)
            {
                MessageBox.Error(this, "Nhập vào mật khẩu hiện tại");
                this.textBoxPasswordOld.SelectAll();
                this.textBoxPasswordOld.Focus();
                this.Activate();
                return;
            }

            if (szPasswordNew.Length <= 0)
            {
                MessageBox.Error(this, "Nhập vào mật khẩu mới");
                this.textBoxPasswordNew.SelectAll();
                this.textBoxPasswordNew.Focus();
                this.Activate();
                return;
            }

            if (szPasswordConfirm.Length <= 0)
            {
                MessageBox.Error(this, "Nhập vào xác nhận mật khẩu mới");
                this.textBoxPasswordConfirm.SelectAll();
                this.textBoxPasswordConfirm.Focus();
                this.Activate();
                return;
            }

            // Kiem tra Username va Password
            bool okCheck = false;
            try
            {
                //okCheck = UserController.CheckUserPassword(szUsername, szPasswordOld);
                okCheck = true;
            }
            catch (Exception ex)
            {
                MessageBox.Error(this, ex.Message);
                okCheck = false;

            }

            if (okCheck)
            {
                // Kiem tra Password moi
                if (szPasswordNew != szPasswordConfirm)
                {
                    MessageBox.Error(this, "Xác nhận mật khẩu mới không đúng");
                    return;
                }

                // Thuc hien cap nhap
                bool okChange = false;
                try
                {
                    //okChange = UserController.ChangePassword(szUsername, szPasswordOld, szPasswordNew);
                    okChange = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Error(this, ex.Message);
                    okChange = false;
                }

                if (okChange)
                {
                    MessageBox.Infor(this, "Đổi mật khẩu thành công");
                }
                else
                {
                    MessageBox.Error(this, "Đổi mật khẩu thất bại, thử lại lần nữa");
                }
            }
            else
            {
                MessageBox.Error(this, "Tên đăng nhập hoặc mật khẩu không đúng");
                this.Activate();
            }  
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
