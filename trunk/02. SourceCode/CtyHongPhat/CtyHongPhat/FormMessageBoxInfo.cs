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
    public partial class FormMessageBoxInfo : Form
    {
        public FormMessageBoxInfo(System.Windows.Forms.IWin32Window p, string message)
        {
            InitializeComponent();
            this.labelMessage.Text = message;
            this.ShowDialog(p);
        }
    }
}