namespace CtyHongPhat
{
    partial class FormManageBankDebts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dataGridViewListBankDebts = new System.Windows.Forms.DataGridView();
            this.ColumnCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnBankDebtId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBankName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBorrowDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaturityDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInterestRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDebtAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPaidAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonPayDebt = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownPayAmount = new System.Windows.Forms.NumericUpDown();
            this.textBoxRateAmount = new System.Windows.Forms.TextBox();
            this.textBoxBorrowDate = new System.Windows.Forms.TextBox();
            this.textBoxMaturityDate = new System.Windows.Forms.TextBox();
            this.textBoxPaidAmount = new System.Windows.Forms.TextBox();
            this.textBoxDebtAmount = new System.Windows.Forms.TextBox();
            this.textBoxBankName = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewListInterestRate = new System.Windows.Forms.DataGridView();
            this.ColumnBankInterestRateId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPayDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRateAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPayAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIRNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelBankDebtId = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListBankDebts)).BeginInit();
            this.b.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPayAmount)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListInterestRate)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.dataGridViewListBankDebts);
            this.groupBox1.Location = new System.Drawing.Point(15, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(965, 286);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách nợ ngân hàng";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(9, 21);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(126, 20);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Xem cả nợ đã trả";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dataGridViewListBankDebts
            // 
            this.dataGridViewListBankDebts.AllowUserToAddRows = false;
            this.dataGridViewListBankDebts.AllowUserToDeleteRows = false;
            this.dataGridViewListBankDebts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewListBankDebts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListBankDebts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCheck,
            this.ColumnBankDebtId,
            this.ColumnBankName,
            this.ColumnBorrowDate,
            this.MaturityDate,
            this.ColumnInterestRate,
            this.ColumnDebtAmount,
            this.ColumnPaidAmount,
            this.ColumnNote});
            this.dataGridViewListBankDebts.Location = new System.Drawing.Point(6, 45);
            this.dataGridViewListBankDebts.MultiSelect = false;
            this.dataGridViewListBankDebts.Name = "dataGridViewListBankDebts";
            this.dataGridViewListBankDebts.RowHeadersVisible = false;
            this.dataGridViewListBankDebts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListBankDebts.Size = new System.Drawing.Size(953, 234);
            this.dataGridViewListBankDebts.TabIndex = 0;
            this.dataGridViewListBankDebts.SelectionChanged += new System.EventHandler(this.dataGridViewListBankDebts_SelectionChanged);
            // 
            // ColumnCheck
            // 
            this.ColumnCheck.HeaderText = "";
            this.ColumnCheck.Name = "ColumnCheck";
            this.ColumnCheck.Visible = false;
            this.ColumnCheck.Width = 25;
            // 
            // ColumnBankDebtId
            // 
            this.ColumnBankDebtId.HeaderText = "Mã nợ";
            this.ColumnBankDebtId.Name = "ColumnBankDebtId";
            this.ColumnBankDebtId.Visible = false;
            // 
            // ColumnBankName
            // 
            this.ColumnBankName.HeaderText = "Tên ngân hàng";
            this.ColumnBankName.Name = "ColumnBankName";
            this.ColumnBankName.ReadOnly = true;
            this.ColumnBankName.Width = 250;
            // 
            // ColumnBorrowDate
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColumnBorrowDate.DefaultCellStyle = dataGridViewCellStyle8;
            this.ColumnBorrowDate.HeaderText = "Ngày vay";
            this.ColumnBorrowDate.Name = "ColumnBorrowDate";
            this.ColumnBorrowDate.ReadOnly = true;
            // 
            // MaturityDate
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.MaturityDate.DefaultCellStyle = dataGridViewCellStyle9;
            this.MaturityDate.HeaderText = "Ngày đáo hạn";
            this.MaturityDate.Name = "MaturityDate";
            this.MaturityDate.ReadOnly = true;
            this.MaturityDate.Width = 120;
            // 
            // ColumnInterestRate
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColumnInterestRate.DefaultCellStyle = dataGridViewCellStyle10;
            this.ColumnInterestRate.HeaderText = "Lãi suất";
            this.ColumnInterestRate.Name = "ColumnInterestRate";
            this.ColumnInterestRate.ReadOnly = true;
            // 
            // ColumnDebtAmount
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColumnDebtAmount.DefaultCellStyle = dataGridViewCellStyle11;
            this.ColumnDebtAmount.HeaderText = "Tiền vay";
            this.ColumnDebtAmount.Name = "ColumnDebtAmount";
            this.ColumnDebtAmount.ReadOnly = true;
            this.ColumnDebtAmount.Width = 125;
            // 
            // ColumnPaidAmount
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColumnPaidAmount.DefaultCellStyle = dataGridViewCellStyle12;
            this.ColumnPaidAmount.HeaderText = "Đã trả";
            this.ColumnPaidAmount.Name = "ColumnPaidAmount";
            this.ColumnPaidAmount.ReadOnly = true;
            this.ColumnPaidAmount.Width = 125;
            // 
            // ColumnNote
            // 
            this.ColumnNote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnNote.HeaderText = "Ghi chú";
            this.ColumnNote.Name = "ColumnNote";
            this.ColumnNote.ReadOnly = true;
            // 
            // b
            // 
            this.b.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.b.Controls.Add(this.labelBankDebtId);
            this.b.Controls.Add(this.label11);
            this.b.Controls.Add(this.label10);
            this.b.Controls.Add(this.buttonPayDebt);
            this.b.Controls.Add(this.label9);
            this.b.Controls.Add(this.label8);
            this.b.Controls.Add(this.label6);
            this.b.Controls.Add(this.label5);
            this.b.Controls.Add(this.label3);
            this.b.Controls.Add(this.label7);
            this.b.Controls.Add(this.label4);
            this.b.Controls.Add(this.label2);
            this.b.Controls.Add(this.label1);
            this.b.Controls.Add(this.numericUpDownPayAmount);
            this.b.Controls.Add(this.textBoxRateAmount);
            this.b.Controls.Add(this.textBoxBorrowDate);
            this.b.Controls.Add(this.textBoxMaturityDate);
            this.b.Controls.Add(this.textBoxPaidAmount);
            this.b.Controls.Add(this.textBoxDebtAmount);
            this.b.Controls.Add(this.textBoxBankName);
            this.b.Location = new System.Drawing.Point(15, 306);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(966, 146);
            this.b.TabIndex = 1;
            this.b.TabStop = false;
            this.b.Text = "Thông tin nợ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(681, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 16);
            this.label11.TabIndex = 24;
            this.label11.Text = "VNĐ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(681, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "VNĐ";
            // 
            // buttonPayDebt
            // 
            this.buttonPayDebt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPayDebt.Image = global::CtyHongPhat.Properties.Resources.money;
            this.buttonPayDebt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonPayDebt.Location = new System.Drawing.Point(806, 62);
            this.buttonPayDebt.Name = "buttonPayDebt";
            this.buttonPayDebt.Size = new System.Drawing.Size(90, 66);
            this.buttonPayDebt.TabIndex = 22;
            this.buttonPayDebt.Text = "Trả lãi";
            this.buttonPayDebt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonPayDebt.UseVisualStyleBackColor = true;
            this.buttonPayDebt.Click += new System.EventHandler(this.buttonPayDebt_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(461, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Trả nợ :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(461, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Tiền lãi";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(705, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Ngày đáo hạn :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(461, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Ngày vay :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "VNĐ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(261, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "VNĐ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Đã trả :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tiền vay :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tên ngân hàng :";
            // 
            // numericUpDownPayAmount
            // 
            this.numericUpDownPayAmount.DecimalPlaces = 2;
            this.numericUpDownPayAmount.Location = new System.Drawing.Point(535, 105);
            this.numericUpDownPayAmount.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.numericUpDownPayAmount.Name = "numericUpDownPayAmount";
            this.numericUpDownPayAmount.Size = new System.Drawing.Size(140, 22);
            this.numericUpDownPayAmount.TabIndex = 6;
            this.numericUpDownPayAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxRateAmount
            // 
            this.textBoxRateAmount.Location = new System.Drawing.Point(535, 62);
            this.textBoxRateAmount.Name = "textBoxRateAmount";
            this.textBoxRateAmount.ReadOnly = true;
            this.textBoxRateAmount.Size = new System.Drawing.Size(140, 22);
            this.textBoxRateAmount.TabIndex = 5;
            this.textBoxRateAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxBorrowDate
            // 
            this.textBoxBorrowDate.Location = new System.Drawing.Point(535, 25);
            this.textBoxBorrowDate.Name = "textBoxBorrowDate";
            this.textBoxBorrowDate.ReadOnly = true;
            this.textBoxBorrowDate.Size = new System.Drawing.Size(140, 22);
            this.textBoxBorrowDate.TabIndex = 4;
            this.textBoxBorrowDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxMaturityDate
            // 
            this.textBoxMaturityDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMaturityDate.Location = new System.Drawing.Point(806, 25);
            this.textBoxMaturityDate.Name = "textBoxMaturityDate";
            this.textBoxMaturityDate.ReadOnly = true;
            this.textBoxMaturityDate.Size = new System.Drawing.Size(140, 22);
            this.textBoxMaturityDate.TabIndex = 3;
            this.textBoxMaturityDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxPaidAmount
            // 
            this.textBoxPaidAmount.Location = new System.Drawing.Point(115, 104);
            this.textBoxPaidAmount.Name = "textBoxPaidAmount";
            this.textBoxPaidAmount.ReadOnly = true;
            this.textBoxPaidAmount.Size = new System.Drawing.Size(140, 22);
            this.textBoxPaidAmount.TabIndex = 2;
            this.textBoxPaidAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxDebtAmount
            // 
            this.textBoxDebtAmount.Location = new System.Drawing.Point(115, 62);
            this.textBoxDebtAmount.Name = "textBoxDebtAmount";
            this.textBoxDebtAmount.ReadOnly = true;
            this.textBoxDebtAmount.Size = new System.Drawing.Size(140, 22);
            this.textBoxDebtAmount.TabIndex = 1;
            this.textBoxDebtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxBankName
            // 
            this.textBoxBankName.Location = new System.Drawing.Point(115, 22);
            this.textBoxBankName.Name = "textBoxBankName";
            this.textBoxBankName.ReadOnly = true;
            this.textBoxBankName.Size = new System.Drawing.Size(210, 22);
            this.textBoxBankName.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Image = global::CtyHongPhat.Properties.Resources.Good_32x32;
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAdd.Location = new System.Drawing.Point(1000, 35);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(90, 71);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Thêm  nợ mới";
            this.buttonAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dataGridViewListInterestRate);
            this.groupBox3.Location = new System.Drawing.Point(15, 458);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(967, 242);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin lãi và trả nợ";
            // 
            // dataGridViewListInterestRate
            // 
            this.dataGridViewListInterestRate.AllowUserToAddRows = false;
            this.dataGridViewListInterestRate.AllowUserToDeleteRows = false;
            this.dataGridViewListInterestRate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewListInterestRate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListInterestRate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnBankInterestRateId,
            this.ColumnPayDate,
            this.ColumnRateAmount,
            this.ColumnPayAmount,
            this.ColumnIRNote});
            this.dataGridViewListInterestRate.Location = new System.Drawing.Point(8, 21);
            this.dataGridViewListInterestRate.MultiSelect = false;
            this.dataGridViewListInterestRate.Name = "dataGridViewListInterestRate";
            this.dataGridViewListInterestRate.ReadOnly = true;
            this.dataGridViewListInterestRate.RowHeadersVisible = false;
            this.dataGridViewListInterestRate.Size = new System.Drawing.Size(953, 215);
            this.dataGridViewListInterestRate.TabIndex = 0;
            // 
            // ColumnBankInterestRateId
            // 
            this.ColumnBankInterestRateId.HeaderText = "Mã lãi";
            this.ColumnBankInterestRateId.Name = "ColumnBankInterestRateId";
            this.ColumnBankInterestRateId.ReadOnly = true;
            this.ColumnBankInterestRateId.Visible = false;
            // 
            // ColumnPayDate
            // 
            this.ColumnPayDate.HeaderText = "Ngày trả lãi";
            this.ColumnPayDate.Name = "ColumnPayDate";
            this.ColumnPayDate.ReadOnly = true;
            // 
            // ColumnRateAmount
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColumnRateAmount.DefaultCellStyle = dataGridViewCellStyle13;
            this.ColumnRateAmount.HeaderText = "Tiền lãi";
            this.ColumnRateAmount.Name = "ColumnRateAmount";
            this.ColumnRateAmount.ReadOnly = true;
            this.ColumnRateAmount.Width = 150;
            // 
            // ColumnPayAmount
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColumnPayAmount.DefaultCellStyle = dataGridViewCellStyle14;
            this.ColumnPayAmount.HeaderText = "Trả nợ";
            this.ColumnPayAmount.Name = "ColumnPayAmount";
            this.ColumnPayAmount.ReadOnly = true;
            this.ColumnPayAmount.Width = 150;
            // 
            // ColumnIRNote
            // 
            this.ColumnIRNote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnIRNote.HeaderText = "Ghi chú";
            this.ColumnIRNote.Name = "ColumnIRNote";
            this.ColumnIRNote.ReadOnly = true;
            // 
            // labelBankDebtId
            // 
            this.labelBankDebtId.AutoSize = true;
            this.labelBankDebtId.Location = new System.Drawing.Point(332, 25);
            this.labelBankDebtId.Name = "labelBankDebtId";
            this.labelBankDebtId.Size = new System.Drawing.Size(0, 16);
            this.labelBankDebtId.TabIndex = 25;
            this.labelBankDebtId.Visible = false;
            // 
            // FormManageBankDebts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 712);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.b);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.Name = "FormManageBankDebts";
            this.Text = "FormManageBankDebts";
            this.Load += new System.EventHandler(this.FormManageBankDebts_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListBankDebts)).EndInit();
            this.b.ResumeLayout(false);
            this.b.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPayAmount)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListInterestRate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox b;
        private System.Windows.Forms.DataGridView dataGridViewListBankDebts;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewListInterestRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBankInterestRateId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPayDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRateAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPayAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIRNote;
        private System.Windows.Forms.TextBox textBoxMaturityDate;
        private System.Windows.Forms.TextBox textBoxPaidAmount;
        private System.Windows.Forms.TextBox textBoxDebtAmount;
        private System.Windows.Forms.TextBox textBoxBankName;
        private System.Windows.Forms.TextBox textBoxBorrowDate;
        private System.Windows.Forms.TextBox textBoxRateAmount;
        private System.Windows.Forms.NumericUpDown numericUpDownPayAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonPayDebt;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBankDebtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBankName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBorrowDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaturityDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInterestRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDebtAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPaidAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNote;
        private System.Windows.Forms.Label labelBankDebtId;
    }
}