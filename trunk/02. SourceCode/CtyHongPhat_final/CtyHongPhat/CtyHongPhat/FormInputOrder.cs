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
    public partial class FormInputOrder : Form
    {
        private string employeeName = "";
        public FormInputOrder()
        {
            InitializeComponent();
        }

        public FormInputOrder(string employeeName)
        {
            InitializeComponent();
            this.employeeName = employeeName;
        }
    }
}
