namespace CtyHongPhat
{
    partial class FormAddBankDebt
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
            this.textBoxBankName = new System.Windows.Forms.TextBox();
            this.dateTimePickerBorrowDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerMaturityDate = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownDebtAmount = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownInterestRate = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPaidAmount = new System.Windows.Forms.NumericUpDown();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDebtAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInterestRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPaidAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxBankName
            // 
            this.textBoxBankName.Location = new System.Drawing.Point(122, 13);
            this.textBoxBankName.Name = "textBoxBankName";
            this.textBoxBankName.Size = new System.Drawing.Size(520, 22);
            this.textBoxBankName.TabIndex = 0;
            // 
            // dateTimePickerBorrowDate
            // 
            this.dateTimePickerBorrowDate.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerBorrowDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerBorrowDate.Location = new System.Drawing.Point(442, 50);
            this.dateTimePickerBorrowDate.Name = "dateTimePickerBorrowDate";
            this.dateTimePickerBorrowDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerBorrowDate.TabIndex = 4;
            // 
            // dateTimePickerMaturityDate
            // 
            this.dateTimePickerMaturityDate.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerMaturityDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerMaturityDate.Location = new System.Drawing.Point(442, 91);
            this.dateTimePickerMaturityDate.Name = "dateTimePickerMaturityDate";
            this.dateTimePickerMaturityDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerMaturityDate.TabIndex = 5;
            // 
            // numericUpDownDebtAmount
            // 
            this.numericUpDownDebtAmount.Location = new System.Drawing.Point(122, 50);
            this.numericUpDownDebtAmount.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.numericUpDownDebtAmount.Name = "numericUpDownDebtAmount";
            this.numericUpDownDebtAmount.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownDebtAmount.TabIndex = 1;
            this.numericUpDownDebtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericUpDownInterestRate
            // 
            this.numericUpDownInterestRate.DecimalPlaces = 2;
            this.numericUpDownInterestRate.Location = new System.Drawing.Point(122, 91);
            this.numericUpDownInterestRate.Name = "numericUpDownInterestRate";
            this.numericUpDownInterestRate.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownInterestRate.TabIndex = 2;
            this.numericUpDownInterestRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericUpDownPaidAmount
            // 
            this.numericUpDownPaidAmount.Location = new System.Drawing.Point(122, 135);
            this.numericUpDownPaidAmount.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.numericUpDownPaidAmount.Name = "numericUpDownPaidAmount";
            this.numericUpDownPaidAmount.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownPaidAmount.TabIndex = 3;
            this.numericUpDownPaidAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(363, 133);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Thêm mới";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(567, 133);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "Thoát";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(468, 133);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 7;
            this.buttonRefresh.Text = "Làm mới";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tên ngân hàng :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tiền vay :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Lãi suất :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Đã trả :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(360, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ngày vay :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(360, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ngày trả :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(248, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "VNĐ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(248, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "VNĐ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(248, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "%";
            // 
            // FormAddBankDebt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 189);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.numericUpDownPaidAmount);
            this.Controls.Add(this.numericUpDownInterestRate);
            this.Controls.Add(this.numericUpDownDebtAmount);
            this.Controls.Add(this.dateTimePickerMaturityDate);
            this.Controls.Add(this.dateTimePickerBorrowDate);
            this.Controls.Add(this.textBoxBankName);
            this.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddBankDebt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddBankDebt";
            this.Load += new System.EventHandler(this.FormAddBankDebt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDebtAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInterestRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPaidAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBankName;
        private System.Windows.Forms.DateTimePicker dateTimePickerBorrowDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerMaturityDate;
        private System.Windows.Forms.NumericUpDown numericUpDownDebtAmount;
        private System.Windows.Forms.NumericUpDown numericUpDownInterestRate;
        private System.Windows.Forms.NumericUpDown numericUpDownPaidAmount;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}