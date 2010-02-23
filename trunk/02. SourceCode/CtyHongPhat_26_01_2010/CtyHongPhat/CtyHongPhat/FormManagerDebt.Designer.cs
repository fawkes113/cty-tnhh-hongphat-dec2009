namespace CtyHongPhat
{
    partial class FormManagerDebt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonPayAllDebt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonPayDebt = new System.Windows.Forms.Button();
            this.numericUpDownPayAmount = new System.Windows.Forms.NumericUpDown();
            this.labelDebtAmount = new System.Windows.Forms.Label();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewListOrders = new System.Windows.Forms.DataGridView();
            this.columnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPayAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDebt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.comboBoxOrderStatus = new System.Windows.Forms.ComboBox();
            this.dateTimePickerToDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFromDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxListCustomer = new System.Windows.Forms.ComboBox();
            this.radioButtonSellOrder = new System.Windows.Forms.RadioButton();
            this.radioButtonBuyOrder = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPayAmount)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListOrders)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonPayAllDebt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.buttonPayDebt);
            this.groupBox1.Controls.Add(this.numericUpDownPayAmount);
            this.groupBox1.Controls.Add(this.labelDebtAmount);
            this.groupBox1.Controls.Add(this.labelCustomerName);
            this.groupBox1.Location = new System.Drawing.Point(12, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1150, 108);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // buttonPayAllDebt
            // 
            this.buttonPayAllDebt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPayAllDebt.Image = global::CtyHongPhat.Properties.Resources.money;
            this.buttonPayAllDebt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonPayAllDebt.Location = new System.Drawing.Point(1037, 21);
            this.buttonPayAllDebt.Name = "buttonPayAllDebt";
            this.buttonPayAllDebt.Size = new System.Drawing.Size(90, 66);
            this.buttonPayAllDebt.TabIndex = 15;
            this.buttonPayAllDebt.Text = "Trả hết nợ";
            this.buttonPayAllDebt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonPayAllDebt.UseVisualStyleBackColor = true;
            this.buttonPayAllDebt.Click += new System.EventHandler(this.buttonPayAllDebt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(592, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "VNĐ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "VNĐ";
            // 
            // buttonPayDebt
            // 
            this.buttonPayDebt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPayDebt.Image = global::CtyHongPhat.Properties.Resources.money;
            this.buttonPayDebt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonPayDebt.Location = new System.Drawing.Point(921, 21);
            this.buttonPayDebt.Name = "buttonPayDebt";
            this.buttonPayDebt.Size = new System.Drawing.Size(90, 66);
            this.buttonPayDebt.TabIndex = 5;
            this.buttonPayDebt.Text = "Trả nợ";
            this.buttonPayDebt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonPayDebt.UseVisualStyleBackColor = true;
            this.buttonPayDebt.Click += new System.EventHandler(this.buttonPayDebt_Click);
            // 
            // numericUpDownPayAmount
            // 
            this.numericUpDownPayAmount.Location = new System.Drawing.Point(452, 25);
            this.numericUpDownPayAmount.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.numericUpDownPayAmount.Name = "numericUpDownPayAmount";
            this.numericUpDownPayAmount.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownPayAmount.TabIndex = 2;
            this.numericUpDownPayAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelDebtAmount
            // 
            this.labelDebtAmount.Location = new System.Drawing.Point(123, 61);
            this.labelDebtAmount.Name = "labelDebtAmount";
            this.labelDebtAmount.Size = new System.Drawing.Size(73, 16);
            this.labelDebtAmount.TabIndex = 1;
            this.labelDebtAmount.Text = "<Tiền nợ >";
            this.labelDebtAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Location = new System.Drawing.Point(123, 27);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(117, 16);
            this.labelCustomerName.TabIndex = 0;
            this.labelCustomerName.Text = "<Tên khách hàng>";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataGridViewListOrders);
            this.groupBox2.Location = new System.Drawing.Point(12, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1150, 377);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách hóa đơn";
            // 
            // dataGridViewListOrders
            // 
            this.dataGridViewListOrders.AllowUserToAddRows = false;
            this.dataGridViewListOrders.AllowUserToDeleteRows = false;
            this.dataGridViewListOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewListOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnId,
            this.columnCreatedDate,
            this.columnTotalAmount,
            this.columnPayAmount,
            this.columnDebt,
            this.columnStatus});
            this.dataGridViewListOrders.Location = new System.Drawing.Point(6, 21);
            this.dataGridViewListOrders.MultiSelect = false;
            this.dataGridViewListOrders.Name = "dataGridViewListOrders";
            this.dataGridViewListOrders.ReadOnly = true;
            this.dataGridViewListOrders.RowHeadersVisible = false;
            this.dataGridViewListOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListOrders.Size = new System.Drawing.Size(1137, 349);
            this.dataGridViewListOrders.TabIndex = 0;
            this.dataGridViewListOrders.SelectionChanged += new System.EventHandler(this.dataGridViewListOrders_SelectionChanged);
            // 
            // columnId
            // 
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.columnId.DefaultCellStyle = dataGridViewCellStyle37;
            this.columnId.HeaderText = "Mã hóa đơn";
            this.columnId.Name = "columnId";
            this.columnId.ReadOnly = true;
            // 
            // columnCreatedDate
            // 
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.columnCreatedDate.DefaultCellStyle = dataGridViewCellStyle38;
            this.columnCreatedDate.HeaderText = "Ngày lập hóa đơn";
            this.columnCreatedDate.Name = "columnCreatedDate";
            this.columnCreatedDate.ReadOnly = true;
            this.columnCreatedDate.Width = 250;
            // 
            // columnTotalAmount
            // 
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.columnTotalAmount.DefaultCellStyle = dataGridViewCellStyle39;
            this.columnTotalAmount.HeaderText = "Tổng tiền";
            this.columnTotalAmount.Name = "columnTotalAmount";
            this.columnTotalAmount.ReadOnly = true;
            this.columnTotalAmount.ToolTipText = "Tổng tiền";
            this.columnTotalAmount.Width = 200;
            // 
            // columnPayAmount
            // 
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.columnPayAmount.DefaultCellStyle = dataGridViewCellStyle40;
            this.columnPayAmount.HeaderText = "Số tiến đã trả";
            this.columnPayAmount.Name = "columnPayAmount";
            this.columnPayAmount.ReadOnly = true;
            this.columnPayAmount.Width = 200;
            // 
            // columnDebt
            // 
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.columnDebt.DefaultCellStyle = dataGridViewCellStyle41;
            this.columnDebt.HeaderText = "Còn nợ";
            this.columnDebt.Name = "columnDebt";
            this.columnDebt.ReadOnly = true;
            this.columnDebt.Width = 200;
            // 
            // columnStatus
            // 
            this.columnStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.columnStatus.DefaultCellStyle = dataGridViewCellStyle42;
            this.columnStatus.HeaderText = "Trạng thái";
            this.columnStatus.Name = "columnStatus";
            this.columnStatus.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.buttonSearch);
            this.groupBox3.Controls.Add(this.comboBoxOrderStatus);
            this.groupBox3.Controls.Add(this.dateTimePickerToDate);
            this.groupBox3.Controls.Add(this.dateTimePickerFromDate);
            this.groupBox3.Controls.Add(this.comboBoxListCustomer);
            this.groupBox3.Controls.Add(this.radioButtonSellOrder);
            this.groupBox3.Controls.Add(this.radioButtonBuyOrder);
            this.groupBox3.Location = new System.Drawing.Point(12, 513);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1150, 108);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin tìm kiếm";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.Image = global::CtyHongPhat.Properties.Resources.search;
            this.buttonSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSearch.Location = new System.Drawing.Point(1027, 26);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(87, 51);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.Text = "Tìm kiếm";
            this.buttonSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // comboBoxOrderStatus
            // 
            this.comboBoxOrderStatus.FormattingEnabled = true;
            this.comboBoxOrderStatus.Location = new System.Drawing.Point(277, 57);
            this.comboBoxOrderStatus.Name = "comboBoxOrderStatus";
            this.comboBoxOrderStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxOrderStatus.Size = new System.Drawing.Size(192, 22);
            this.comboBoxOrderStatus.TabIndex = 5;
            // 
            // dateTimePickerToDate
            // 
            this.dateTimePickerToDate.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerToDate.Location = new System.Drawing.Point(714, 54);
            this.dateTimePickerToDate.Name = "dateTimePickerToDate";
            this.dateTimePickerToDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePickerToDate.Size = new System.Drawing.Size(233, 22);
            this.dateTimePickerToDate.TabIndex = 4;
            // 
            // dateTimePickerFromDate
            // 
            this.dateTimePickerFromDate.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFromDate.Location = new System.Drawing.Point(714, 26);
            this.dateTimePickerFromDate.Name = "dateTimePickerFromDate";
            this.dateTimePickerFromDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePickerFromDate.Size = new System.Drawing.Size(233, 22);
            this.dateTimePickerFromDate.TabIndex = 3;
            // 
            // comboBoxListCustomer
            // 
            this.comboBoxListCustomer.FormattingEnabled = true;
            this.comboBoxListCustomer.Location = new System.Drawing.Point(277, 23);
            this.comboBoxListCustomer.Name = "comboBoxListCustomer";
            this.comboBoxListCustomer.Size = new System.Drawing.Size(192, 22);
            this.comboBoxListCustomer.TabIndex = 2;
            // 
            // radioButtonSellOrder
            // 
            this.radioButtonSellOrder.AutoSize = true;
            this.radioButtonSellOrder.Location = new System.Drawing.Point(8, 57);
            this.radioButtonSellOrder.Name = "radioButtonSellOrder";
            this.radioButtonSellOrder.Size = new System.Drawing.Size(105, 20);
            this.radioButtonSellOrder.TabIndex = 1;
            this.radioButtonSellOrder.TabStop = true;
            this.radioButtonSellOrder.Text = "Hóa đơn nhập";
            this.radioButtonSellOrder.UseVisualStyleBackColor = true;
            this.radioButtonSellOrder.CheckedChanged += new System.EventHandler(this.radioButtonSellOrder_CheckedChanged);
            // 
            // radioButtonBuyOrder
            // 
            this.radioButtonBuyOrder.AutoSize = true;
            this.radioButtonBuyOrder.Location = new System.Drawing.Point(8, 23);
            this.radioButtonBuyOrder.Name = "radioButtonBuyOrder";
            this.radioButtonBuyOrder.Size = new System.Drawing.Size(101, 20);
            this.radioButtonBuyOrder.TabIndex = 0;
            this.radioButtonBuyOrder.TabStop = true;
            this.radioButtonBuyOrder.Text = "Hóa đơn xuất";
            this.radioButtonBuyOrder.UseVisualStyleBackColor = true;
            this.radioButtonBuyOrder.CheckedChanged += new System.EventHandler(this.radioButtonBuyOrder_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tên khách hàng :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tiền nợ :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Trả nợ :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(157, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Khách hàng :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(154, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Tình trạng :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(625, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Từ ngày :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(625, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Đến ngày :";
            // 
            // FormListOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 633);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.Name = "FormListOrders";
            this.Text = "FormListOrders";
            this.Load += new System.EventHandler(this.FormListOrders_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPayAmount)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListOrders)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBoxListCustomer;
        private System.Windows.Forms.RadioButton radioButtonSellOrder;
        private System.Windows.Forms.RadioButton radioButtonBuyOrder;
        private System.Windows.Forms.DateTimePicker dateTimePickerFromDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerToDate;
        private System.Windows.Forms.ComboBox comboBoxOrderStatus;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelDebtAmount;
        private System.Windows.Forms.NumericUpDown numericUpDownPayAmount;
        private System.Windows.Forms.Button buttonPayDebt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewListOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPayAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDebt;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnStatus;
        private System.Windows.Forms.Button buttonPayAllDebt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}