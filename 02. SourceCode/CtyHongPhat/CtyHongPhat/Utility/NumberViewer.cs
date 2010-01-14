using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CtyHongPhat.Utility
{
    class NumberViewer
    {
        private TextBox txt = null;

        public NumberViewer(TextBox txt)
        {
            this.txt = txt;
            if (this.txt != null)
            {
                this.txt.MaxLength = 28;
                this.txt.TextChanged += new EventHandler(txt_TextChanged);
                this.txt.KeyPress += new KeyPressEventHandler(txt_KeyPress);
            }
        }

        /// <summary>
        /// Sự kiện khi có ấn phím
        /// </summary>
        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false && Char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }

        /// <summary>
        /// Sự kiện khi thay đổi text
        /// </summary>
        private void txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txt.Text))
                    return;
                int selectWidth = this.txt.Text.Length - this.txt.SelectionStart;
                this.txt.Text = this.TTextBoxInsertComma();
                int nowSelect = this.txt.Text.Length - selectWidth;
                if (nowSelect < 0)
                    nowSelect = 0;
                this.txt.SelectionStart = nowSelect;
                if (this.Value == 0)
                    this.txt.Text = string.Empty;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex);
            }
        }

        /// <summary>
        /// Phân tách số theo từng cụm 3 số một bằng dấu phẩy
        /// </summary>
        private string TTextBoxInsertComma()
        {
            return NumberViewer.InsertComma(this.txt.Text);
        }

        public static string InsertComma(string text)
        {
            string temp = text.Replace(",", "");
            bool flag = false;
            if (text.StartsWith("-"))
            {
                temp = temp.Replace("-", "");
                flag = true;
            }
            int length = temp.Length;
            for (int i = length - 1; i >= 0; i--)
                if (temp[i] < '0' || temp[i] > '9')
                    temp = temp.Remove(i);
            length = temp.Length;
            int j = 0;
            for (int i = length; i > 1; i--)
            {
                j++;
                if (j % 3 == 0)
                {
                    temp = temp.Insert(length - j, ",");
                }
            }
            if (flag)
            {
                temp = "-" + temp;
            }
            return temp;
        }

        public static string ClearComma(string str)
        {
            return str.Replace(",", "").Replace(".", "");
        }

        /// <summary>
        /// Giá trị số của textbox
        /// </summary>
        public decimal Value
        {
            get
            {
                try
                {
                    return decimal.Parse(this.txt.Text.Replace(",", ""));
                }
                catch
                {
                    return 0;
                }
            }
            set
            {
                this.txt.Text = value.ToString();
            }
        }

      
    }
}
