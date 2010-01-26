namespace CtyHongPhat
{
    partial class FormInputOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxInforAgent = new System.Windows.Forms.GroupBox();
            this.labelTotalDebt = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelKindOfAngent = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxListAgentName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxListItems = new System.Windows.Forms.GroupBox();
            this.dataGridViewListItem = new System.Windows.Forms.DataGridView();
            this.columnDelete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.columnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMeasurement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTotalMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxInforItem = new System.Windows.Forms.GroupBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelMeasurement = new System.Windows.Forms.Label();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownPayAmount = new System.Windows.Forms.NumericUpDown();
            this.textBoxTotalAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDownBuyPrice = new System.Windows.Forms.NumericUpDown();
            this.groupBoxInforAgent.SuspendLayout();
            this.groupBoxListItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListItem)).BeginInit();
            this.groupBoxInforItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPayAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBuyPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxInforAgent
            // 
            this.groupBoxInforAgent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInforAgent.Controls.Add(this.label5);
            this.groupBoxInforAgent.Controls.Add(this.labelTotalDebt);
            this.groupBoxInforAgent.Controls.Add(this.label6);
            this.groupBoxInforAgent.Controls.Add(this.labelKindOfAngent);
            this.groupBoxInforAgent.Controls.Add(this.label2);
            this.groupBoxInforAgent.Controls.Add(this.comboBoxListAgentName);
            this.groupBoxInforAgent.Controls.Add(this.label1);
            this.groupBoxInforAgent.Location = new System.Drawing.Point(15, 14);
            this.groupBoxInforAgent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxInforAgent.Name = "groupBoxInforAgent";
            this.groupBoxInforAgent.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxInforAgent.Size = new System.Drawing.Size(1015, 52);
            this.groupBoxInforAgent.TabIndex = 0;
            this.groupBoxInforAgent.TabStop = false;
            this.groupBoxInforAgent.Text = "Thông tin công ty";
            // 
            // labelTotalDebt
            // 
            this.labelTotalDebt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotalDebt.AutoSize = true;
            this.labelTotalDebt.Location = new System.Drawing.Point(883, 21);
            this.labelTotalDebt.Name = "labelTotalDebt";
            this.labelTotalDebt.Size = new System.Drawing.Size(82, 14);
            this.labelTotalDebt.TabIndex = 5;
            this.labelTotalDebt.Text = "<Số tiền nợ>";
            this.labelTotalDebt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(819, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 14);
            this.label6.TabIndex = 4;
            this.label6.Text = "Còn nợ :";
            // 
            // labelKindOfAngent
            // 
            this.labelKindOfAngent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKindOfAngent.AutoSize = true;
            this.labelKindOfAngent.Location = new System.Drawing.Point(714, 21);
            this.labelKindOfAngent.Name = "labelKindOfAngent";
            this.labelKindOfAngent.Size = new System.Drawing.Size(81, 14);
            this.labelKindOfAngent.TabIndex = 3;
            this.labelKindOfAngent.Text = "<Loại đại lý >";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(634, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Loại đại lý :";
            // 
            // comboBoxListAgentName
            // 
            this.comboBoxListAgentName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxListAgentName.FormattingEnabled = true;
            this.comboBoxListAgentName.Location = new System.Drawing.Point(86, 18);
            this.comboBoxListAgentName.Name = "comboBoxListAgentName";
            this.comboBoxListAgentName.Size = new System.Drawing.Size(258, 22);
            this.comboBoxListAgentName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.75F);
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đối tác :";
            // 
            // groupBoxListItems
            // 
            this.groupBoxListItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxListItems.Controls.Add(this.dataGridViewListItem);
            this.groupBoxListItems.Location = new System.Drawing.Point(15, 200);
            this.groupBoxListItems.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxListItems.Name = "groupBoxListItems";
            this.groupBoxListItems.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxListItems.Size = new System.Drawing.Size(1015, 392);
            this.groupBoxListItems.TabIndex = 1;
            this.groupBoxListItems.TabStop = false;
            this.groupBoxListItems.Text = "Danh sách mặt hàng";
            // 
            // dataGridViewListItem
            // 
            this.dataGridViewListItem.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewListItem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
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
            this.dataGridViewListItem.Location = new System.Drawing.Point(7, 20);
            this.dataGridViewListItem.Name = "dataGridViewListItem";
            this.dataGridViewListItem.ReadOnly = true;
            this.dataGridViewListItem.RowHeadersVisible = false;
            this.dataGridViewListItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListItem.Size = new System.Drawing.Size(1002, 365);
            this.dataGridViewListItem.TabIndex = 0;
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
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(943, 634);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(87, 24);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Lưu hóa đơn";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mặt hàng :";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(86, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(257, 22);
            this.comboBox1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Giá :";
            // 
            // groupBoxInforItem
            // 
            this.groupBoxInforItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInforItem.Controls.Add(this.label9);
            this.groupBoxInforItem.Controls.Add(this.numericUpDownBuyPrice);
            this.groupBoxInforItem.Controls.Add(this.buttonAdd);
            this.groupBoxInforItem.Controls.Add(this.button3);
            this.groupBoxInforItem.Controls.Add(this.labelMeasurement);
            this.groupBoxInforItem.Controls.Add(this.numericUpDownQuantity);
            this.groupBoxInforItem.Controls.Add(this.label7);
            this.groupBoxInforItem.Controls.Add(this.comboBox1);
            this.groupBoxInforItem.Controls.Add(this.label4);
            this.groupBoxInforItem.Controls.Add(this.label3);
            this.groupBoxInforItem.Location = new System.Drawing.Point(15, 72);
            this.groupBoxInforItem.Name = "groupBoxInforItem";
            this.groupBoxInforItem.Size = new System.Drawing.Size(1015, 122);
            this.groupBoxInforItem.TabIndex = 3;
            this.groupBoxInforItem.TabStop = false;
            this.groupBoxInforItem.Text = "Thông tin mặt hàng";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(778, 71);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(187, 24);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Text = "Thêm  vào hóa đơn";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // labelMeasurement
            // 
            this.labelMeasurement.AutoSize = true;
            this.labelMeasurement.Location = new System.Drawing.Point(260, 73);
            this.labelMeasurement.Name = "labelMeasurement";
            this.labelMeasurement.Size = new System.Drawing.Size(63, 14);
            this.labelMeasurement.TabIndex = 10;
            this.labelMeasurement.Text = "<Đơn vị >";
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Location = new System.Drawing.Point(86, 71);
            this.numericUpDownQuantity.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(168, 22);
            this.numericUpDownQuantity.TabIndex = 9;
            this.numericUpDownQuantity.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 14);
            this.label7.TabIndex = 8;
            this.label7.Text = "Số lượng :";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(778, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(187, 24);
            this.button3.TabIndex = 4;
            this.button3.Text = "Loại các mặt hàng đã chọn";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // buttonPrint
            // 
            this.buttonPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPrint.Location = new System.Drawing.Point(944, 604);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(86, 23);
            this.buttonPrint.TabIndex = 5;
            this.buttonPrint.Text = "In phiếu";
            this.buttonPrint.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(288, 642);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 14);
            this.label13.TabIndex = 21;
            this.label13.Text = "VNĐ";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(288, 605);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 14);
            this.label12.TabIndex = 20;
            this.label12.Text = "VNĐ";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 642);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 14);
            this.label11.TabIndex = 19;
            this.label11.Text = "Số tiền trả :";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 605);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 14);
            this.label8.TabIndex = 18;
            this.label8.Text = "Tổng tiền phải trả :";
            // 
            // numericUpDownPayAmount
            // 
            this.numericUpDownPayAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDownPayAmount.Location = new System.Drawing.Point(132, 640);
            this.numericUpDownPayAmount.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.numericUpDownPayAmount.Name = "numericUpDownPayAmount";
            this.numericUpDownPayAmount.Size = new System.Drawing.Size(150, 22);
            this.numericUpDownPayAmount.TabIndex = 17;
            this.numericUpDownPayAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTotalAmount
            // 
            this.textBoxTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxTotalAmount.Location = new System.Drawing.Point(132, 602);
            this.textBoxTotalAmount.Name = "textBoxTotalAmount";
            this.textBoxTotalAmount.ReadOnly = true;
            this.textBoxTotalAmount.Size = new System.Drawing.Size(150, 22);
            this.textBoxTotalAmount.TabIndex = 16;
            this.textBoxTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(978, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 14);
            this.label5.TabIndex = 15;
            this.label5.Text = "VNĐ";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(544, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 14);
            this.label9.TabIndex = 23;
            this.label9.Text = "VNĐ";
            // 
            // numericUpDownBuyPrice
            // 
            this.numericUpDownBuyPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownBuyPrice.Location = new System.Drawing.Point(388, 73);
            this.numericUpDownBuyPrice.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.numericUpDownBuyPrice.Name = "numericUpDownBuyPrice";
            this.numericUpDownBuyPrice.Size = new System.Drawing.Size(150, 22);
            this.numericUpDownBuyPrice.TabIndex = 22;
            this.numericUpDownBuyPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormInputOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 668);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericUpDownPayAmount);
            this.Controls.Add(this.textBoxTotalAmount);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.groupBoxInforItem);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBoxListItems);
            this.Controls.Add(this.groupBoxInforAgent);
            this.Font = new System.Drawing.Font("Tahoma", 8.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormInputOrder";
            this.Text = "Nhập hàng";
            this.groupBoxInforAgent.ResumeLayout(false);
            this.groupBoxInforAgent.PerformLayout();
            this.groupBoxListItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListItem)).EndInit();
            this.groupBoxInforItem.ResumeLayout(false);
            this.groupBoxInforItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPayAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBuyPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInforAgent;
        private System.Windows.Forms.GroupBox groupBoxListItems;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ComboBox comboBoxListAgentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelKindOfAngent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTotalDebt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxInforItem;
        private System.Windows.Forms.Label labelMeasurement;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridViewListItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.DataGridViewCheckBoxColumn columnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMeasurement;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTotalMoney;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDownPayAmount;
        private System.Windows.Forms.TextBox textBoxTotalAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDownBuyPrice;
    }
}