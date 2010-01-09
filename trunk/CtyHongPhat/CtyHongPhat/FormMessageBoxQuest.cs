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
    public partial class FormMessageBoxQuest : Form
    {
        public FormMessageBoxQuest(System.Windows.Forms.IWin32Window p, string message, int line)
        {
            InitializeComponent();
            message = message.Replace("\t", "     ");
            this.labelMessage.Text = message;
            //if (line > 3)
            //{
            //    Size s = new Size(this.Width, this.Height + 10 * (line - 3));
            //    this.ClientSize = s;
            //}
            this.ShowDialog(p);
        }
    }
}