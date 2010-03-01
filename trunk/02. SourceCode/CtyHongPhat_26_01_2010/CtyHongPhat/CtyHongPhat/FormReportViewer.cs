﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Windows.Forms;

namespace CtyHongPhat
{
    public partial class FormReportViewer : Form
    {
        public FormReportViewer()
        {
            InitializeComponent();
        }

        private void FormReportViewer_Load(object sender, EventArgs e)
        {

            this.reportViewer.RefreshReport();
        }

        public CrystalReportViewer Report
        {
            get
            {
                return this.reportViewer;
            }
        }
    }
}
