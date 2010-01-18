namespace CtyHongPhat
{
    partial class FormOutputOrder
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
            this.button3 = new System.Windows.Forms.Button();
            this.groupBoxInforAgent = new System.Windows.Forms.GroupBox();
            this.labelTotalDebt = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelKindOfAngent = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxListAgentName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelMeasurement = new System.Windows.Forms.Label();
            this.dataGridViewListItem = new System.Windows.Forms.DataGridView();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBoxListItems = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxInforItem = new System.Windows.Forms.GroupBox();
            this.columnDelete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.columnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMeasurement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTotalMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxInforAgent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            this.groupBoxListItems.SuspendLayout();
            this.groupBoxInforItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(673, 589);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(192, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Loại các mặt hàng đã chọn";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBoxInforAgent
            // 
            this.groupBoxInforAgent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInforAgent.Controls.Add(this.labelTotalDebt);
            this.groupBoxInforAgent.Controls.Add(this.label6);
            this.groupBoxInforAgent.Controls.Add(this.labelKindOfAngent);
            this.groupBoxInforAgent.Controls.Add(this.label2);
            this.groupBoxInforAgent.Controls.Add(this.comboBoxListAgentName);
            this.groupBoxInforAgent.Controls.Add(this.label1);
            this.groupBoxInforAgent.Location = new System.Drawing.Point(14, 4);
            this.groupBoxInforAgent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxInforAgent.Name = "groupBoxInforAgent";
            this.groupBoxInforAgent.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxInforAgent.Size = new System.Drawing.Size(958, 64);
            this.groupBoxInforAgent.TabIndex = 6;
            this.groupBoxInforAgent.TabStop = false;
            this.groupBoxInforAgent.Text = "Thông tin công ty";
            // 
            // labelTotalDebt
            // 
            this.labelTotalDebt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotalDebt.AutoSize = true;
            this.labelTotalDebt.Location = new System.Drawing.Point(843, 26);
            this.labelTotalDebt.Name = "labelTotalDebt";
            this.labelTotalDebt.Size = new System.Drawing.Size(82, 14);
            this.labelTotalDebt.TabIndex = 11;
            this.labelTotalDebt.Text = "<Số tiền nợ>";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(768, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 14);
            this.label6.TabIndex = 10;
            this.label6.Text = "Còn nợ :";
            // 
            // labelKindOfAngent
            // 
            this.labelKindOfAngent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKindOfAngent.AutoSize = true;
            this.labelKindOfAngent.Location = new System.Drawing.Point(641, 26);
            this.labelKindOfAngent.Name = "labelKindOfAngent";
            this.labelKindOfAngent.Size = new System.Drawing.Size(81, 14);
            this.labelKindOfAngent.TabIndex = 9;
            this.labelKindOfAngent.Text = "<Loại đại lý >";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(548, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 14);
            this.label2.TabIndex = 8;
            this.label2.Text = "Loại đại lý :";
            // 
            // comboBoxListAgentName
            // 
            this.comboBoxListAgentName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxListAgentName.FormattingEnabled = true;
            this.comboBoxListAgentName.Location = new System.Drawing.Point(100, 23);
            this.comboBoxListAgentName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxListAgentName.Name = "comboBoxListAgentName";
            this.comboBoxListAgentName.Size = new System.Drawing.Size(381, 22);
            this.comboBoxListAgentName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đại lý :";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(442, 59);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(145, 22);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Thêm  vào hóa đơn";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(806, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 14);
            this.label10.TabIndex = 16;
            this.label10.Text = "<Số lương tồn kho >";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(726, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 14);
            this.label9.TabIndex = 15;
            this.label9.Text = "Tồn kho :";
            // 
            // labelMeasurement
            // 
            this.labelMeasurement.AutoSize = true;
            this.labelMeasurement.Location = new System.Drawing.Point(307, 63);
            this.labelMeasurement.Name = "labelMeasurement";
            this.labelMeasurement.Size = new System.Drawing.Size(63, 14);
            this.labelMeasurement.TabIndex = 18;
            this.labelMeasurement.Text = "<Đơn vị >";
            // 
            // dataGridViewListItem
            // 
            this.dataGridViewListItem.AllowUserToAddRows = false;
            this.dataGridViewListItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewListItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnDelete,
            this.columnId,
            this.columnItemName,
            this.columnQuantity,
            this.columnMeasurement,
            this.columnPrice,
            this.columnTotalMoney});
            this.dataGridViewListItem.Location = new System.Drawing.Point(8, 24);
            this.dataGridViewListItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewListItem.Name = "dataGridViewListItem";
            this.dataGridViewListItem.ReadOnly = true;
            this.dataGridViewListItem.RowHeadersVisible = false;
            this.dataGridViewListItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListItem.Size = new System.Drawing.Size(940, 358);
            this.dataGridViewListItem.TabIndex = 19;
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Location = new System.Drawing.Point(100, 60);
            this.numericUpDownQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownQuantity.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(201, 22);
            this.numericUpDownQuantity.TabIndex = 3;
            this.numericUpDownQuantity.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 14);
            this.label7.TabIndex = 17;
            this.label7.Text = "Số lượng :";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(100, 21);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(381, 22);
            this.comboBox1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(501, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 14);
            this.label4.TabIndex = 13;
            this.label4.Text = "Giá :";
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(871, 590);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(101, 22);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Lưu hóa đơn";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // groupBoxListItems
            // 
            this.groupBoxListItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxListItems.Controls.Add(this.dataGridViewListItem);
            this.groupBoxListItems.Location = new System.Drawing.Point(14, 185);
            this.groupBoxListItems.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxListItems.Name = "groupBoxListItems";
            this.groupBoxListItems.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxListItems.Size = new System.Drawing.Size(958, 396);
            this.groupBoxListItems.TabIndex = 7;
            this.groupBoxListItems.TabStop = false;
            this.groupBoxListItems.Text = "Danh sách mặt hàng";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(538, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 14);
            this.label5.TabIndex = 14;
            this.label5.Text = "<Đơn giá mặt hàng>";
            // 
            // buttonPrint
            // 
            this.buttonPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPrint.Location = new System.Drawing.Point(16, 589);
            this.buttonPrint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(93, 23);
            this.buttonPrint.TabIndex = 7;
            this.buttonPrint.Text = "In phiếu";
            this.buttonPrint.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 14);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mặt hàng :";
            // 
            // groupBoxInforItem
            // 
            this.groupBoxInforItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInforItem.Controls.Add(this.buttonAdd);
            this.groupBoxInforItem.Controls.Add(this.label10);
            this.groupBoxInforItem.Controls.Add(this.label9);
            this.groupBoxInforItem.Controls.Add(this.labelMeasurement);
            this.groupBoxInforItem.Controls.Add(this.numericUpDownQuantity);
            this.groupBoxInforItem.Controls.Add(this.label7);
            this.groupBoxInforItem.Controls.Add(this.label5);
            this.groupBoxInforItem.Controls.Add(this.comboBox1);
            this.groupBoxInforItem.Controls.Add(this.label4);
            this.groupBoxInforItem.Controls.Add(this.label3);
            this.groupBoxInforItem.Location = new System.Drawing.Point(14, 75);
            this.groupBoxInforItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxInforItem.Name = "groupBoxInforItem";
            this.groupBoxInforItem.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxInforItem.Size = new System.Drawing.Size(958, 102);
            this.groupBoxInforItem.TabIndex = 9;
            this.groupBoxInforItem.TabStop = false;
            this.groupBoxInforItem.Text = "Thông tin mặt hàng";
            // 
            // columnDelete
            // 
            this.columnDelete.HeaderText = "Loại bỏ";
            this.columnDelete.Name = "columnDelete";
            this.columnDelete.ReadOnly = true;
            // 
            // columnId
            // 
            this.columnId.HeaderText = "Mã mặt hàng";
            this.columnId.Name = "columnId";
            this.columnId.ReadOnly = true;
            this.columnId.Width = 150;
            // 
            // columnItemName
            // 
            this.columnItemName.HeaderText = "Tên mặt hàng";
            this.columnItemName.Name = "columnItemName";
            this.columnItemName.ReadOnly = true;
            this.columnItemName.Width = 250;
            // 
            // columnQuantity
            // 
            this.columnQuantity.HeaderText = "Số lương";
            this.columnQuantity.Name = "columnQuantity";
            this.columnQuantity.ReadOnly = true;
            this.columnQuantity.Width = 150;
            // 
            // columnMeasurement
            // 
            this.columnMeasurement.HeaderText = "Đơn vị ";
            this.columnMeasurement.Name = "columnMeasurement";
            this.columnMeasurement.ReadOnly = true;
            // 
            // columnPrice
            // 
            this.columnPrice.HeaderText = "Đơn giá";
            this.columnPrice.Name = "columnPrice";
            this.columnPrice.ReadOnly = true;
            // 
            // columnTotalMoney
            // 
            this.columnTotalMoney.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnTotalMoney.HeaderText = "Thành tiền";
            this.columnTotalMoney.Name = "columnTotalMoney";
            this.columnTotalMoney.ReadOnly = true;
            // 
            // FormOutputOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 625);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBoxInforAgent);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBoxListItems);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.groupBoxInforItem);
            this.Font = new System.Drawing.Font("Tahoma", 8.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormOutputOrder";
            this.Text = "Xuất hàng";
            this.groupBoxInforAgent.ResumeLayout(false);
            this.groupBoxInforAgent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            this.groupBoxListItems.ResumeLayout(false);
            this.groupBoxInforItem.ResumeLayout(false);
            this.groupBoxInforItem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBoxInforAgent;
        private System.Windows.Forms.Label labelTotalDebt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelKindOfAngent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxListAgentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelMeasurement;
        private System.Windows.Forms.DataGridView dataGridViewListItem;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.GroupBox groupBoxListItems;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxInforItem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn columnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMeasurement;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTotalMoney;
    }
}