namespace CtyHongPhat
{
    partial class FormUpdateOrder
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.comboBoxOrderStatus = new System.Windows.Forms.ComboBox();
            this.dateTimePickerToDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFromDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxListCustomer = new System.Windows.Forms.ComboBox();
            this.radioButtonSellOrder = new System.Windows.Forms.RadioButton();
            this.radioButtonBuyOrder = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Controls.Add(this.comboBoxOrderStatus);
            this.groupBox1.Controls.Add(this.dateTimePickerToDate);
            this.groupBox1.Controls.Add(this.dateTimePickerFromDate);
            this.groupBox1.Controls.Add(this.comboBoxListCustomer);
            this.groupBox1.Controls.Add(this.radioButtonSellOrder);
            this.groupBox1.Controls.Add(this.radioButtonBuyOrder);
            this.groupBox1.Location = new System.Drawing.Point(4, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1079, 87);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tìm kiếm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(625, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Đến ngày :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(625, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Từ ngày :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(154, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Tình trạng :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(157, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Khách hàng :";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.Image = global::CtyHongPhat.Properties.Resources.search;
            this.buttonSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSearch.Location = new System.Drawing.Point(977, 20);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(87, 51);
            this.buttonSearch.TabIndex = 27;
            this.buttonSearch.Text = "Tìm kiếm";
            this.buttonSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // comboBoxOrderStatus
            // 
            this.comboBoxOrderStatus.FormattingEnabled = true;
            this.comboBoxOrderStatus.Location = new System.Drawing.Point(277, 54);
            this.comboBoxOrderStatus.Name = "comboBoxOrderStatus";
            this.comboBoxOrderStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxOrderStatus.Size = new System.Drawing.Size(192, 21);
            this.comboBoxOrderStatus.TabIndex = 26;
            // 
            // dateTimePickerToDate
            // 
            this.dateTimePickerToDate.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerToDate.Location = new System.Drawing.Point(714, 51);
            this.dateTimePickerToDate.Name = "dateTimePickerToDate";
            this.dateTimePickerToDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePickerToDate.Size = new System.Drawing.Size(233, 21);
            this.dateTimePickerToDate.TabIndex = 25;
            // 
            // dateTimePickerFromDate
            // 
            this.dateTimePickerFromDate.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFromDate.Location = new System.Drawing.Point(714, 23);
            this.dateTimePickerFromDate.Name = "dateTimePickerFromDate";
            this.dateTimePickerFromDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePickerFromDate.Size = new System.Drawing.Size(233, 21);
            this.dateTimePickerFromDate.TabIndex = 24;
            // 
            // comboBoxListCustomer
            // 
            this.comboBoxListCustomer.FormattingEnabled = true;
            this.comboBoxListCustomer.Location = new System.Drawing.Point(277, 20);
            this.comboBoxListCustomer.Name = "comboBoxListCustomer";
            this.comboBoxListCustomer.Size = new System.Drawing.Size(192, 21);
            this.comboBoxListCustomer.TabIndex = 23;
            // 
            // radioButtonSellOrder
            // 
            this.radioButtonSellOrder.AutoSize = true;
            this.radioButtonSellOrder.Location = new System.Drawing.Point(8, 54);
            this.radioButtonSellOrder.Name = "radioButtonSellOrder";
            this.radioButtonSellOrder.Size = new System.Drawing.Size(92, 17);
            this.radioButtonSellOrder.TabIndex = 22;
            this.radioButtonSellOrder.TabStop = true;
            this.radioButtonSellOrder.Text = "Hóa đơn nhập";
            this.radioButtonSellOrder.UseVisualStyleBackColor = true;
            // 
            // radioButtonBuyOrder
            // 
            this.radioButtonBuyOrder.AutoSize = true;
            this.radioButtonBuyOrder.Location = new System.Drawing.Point(8, 20);
            this.radioButtonBuyOrder.Name = "radioButtonBuyOrder";
            this.radioButtonBuyOrder.Size = new System.Drawing.Size(90, 17);
            this.radioButtonBuyOrder.TabIndex = 21;
            this.radioButtonBuyOrder.TabStop = true;
            this.radioButtonBuyOrder.Text = "Hóa đơn xuất";
            this.radioButtonBuyOrder.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Location = new System.Drawing.Point(4, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1079, 101);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin hoá đơn";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(4, 214);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1079, 219);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách mặt hàng";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(4, 451);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1079, 119);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin cập nhật";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(138, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(209, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // FormUpdateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 647);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormUpdateOrder";
            this.Text = "FormUpdateOrder";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ComboBox comboBoxOrderStatus;
        private System.Windows.Forms.DateTimePicker dateTimePickerToDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerFromDate;
        private System.Windows.Forms.ComboBox comboBoxListCustomer;
        private System.Windows.Forms.RadioButton radioButtonSellOrder;
        private System.Windows.Forms.RadioButton radioButtonBuyOrder;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}