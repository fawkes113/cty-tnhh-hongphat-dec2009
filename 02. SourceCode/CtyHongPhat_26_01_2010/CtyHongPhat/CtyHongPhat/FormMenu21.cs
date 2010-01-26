using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CtyHongPhat
{
    public partial class FormMenu21 : Form
    {
        private string userName = "";
        public FormMenu21()
        {
            InitializeComponent();
        }

        public FormMenu21(string userName)
        {
            this.userName = userName;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
