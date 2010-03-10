namespace CtyHongPhat
{
    partial class FormUpdateSellPriceForAgents
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxListItems = new System.Windows.Forms.GroupBox();
            this.dataGridViewItemList = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelItemId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.labelMeasurement = new System.Windows.Forms.Label();
            this.labelItemName = new System.Windows.Forms.Label();
            this.columnAgentKindId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnKindOfAgent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMeasurement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxListItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItemList)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxListItems
            // 
            this.groupBoxListItems.Controls.Add(this.dataGridViewItemList);
            this.groupBoxListItems.Font = new System.Drawing.Font("Tahoma", 8.75F);
            this.groupBoxListItems.Location = new System.Drawing.Point(12, 147);
            this.groupBoxListItems.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBoxListItems.Name = "groupBoxListItems";
            this.groupBoxListItems.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBoxListItems.Size = new System.Drawing.Size(542, 440);
            this.groupBoxListItems.TabIndex = 3;
            this.groupBoxListItems.TabStop = false;
            this.groupBoxListItems.Text = "Danh sách các mặt hàng";
            // 
            // dataGridViewItemList
            // 
            this.dataGridViewItemList.AllowUserToAddRows = false;
            this.dataGridViewItemList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridViewItemList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewItemList.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dataGridViewItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnAgentKindId,
            this.columnKindOfAgent,
            this.columnPrice,
            this.columnMeasurement});
            this.dataGridViewItemList.Location = new System.Drawing.Point(9, 23);
            this.dataGridViewItemList.MultiSelect = false;
            this.dataGridViewItemList.Name = "dataGridViewItemList";
            this.dataGridViewItemList.ReadOnly = true;
            this.dataGridViewItemList.RowHeadersVisible = false;
            this.dataGridViewItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewItemList.Size = new System.Drawing.Size(520, 408);
            this.dataGridViewItemList.TabIndex = 1;
            this.dataGridViewItemList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewItemList_CellMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numericUpDownPrice);
            this.groupBox1.Controls.Add(this.labelMeasurement);
            this.groupBox1.Controls.Add(this.labelItemName);
            this.groupBox1.Controls.Add(this.labelQuantity);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonUpdate);
            this.groupBox1.Controls.Add(this.labelItemId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Size = new System.Drawing.Size(542, 123);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin mặt hàng";
            // 
            // labelItemId
            // 
            this.labelItemId.AutoSize = true;
            this.labelItemId.Location = new System.Drawing.Point(335, 42);
            this.labelItemId.Name = "labelItemId";
            this.labelItemId.Size = new System.Drawing.Size(62, 16);
            this.labelItemId.TabIndex = 14;
            this.labelItemId.Text = "<itemId>";
            this.labelItemId.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mặt hàng :";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdate.Image = global::CtyHongPhat.Properties.Resources.modify;
            this.buttonUpdate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonUpdate.Location = new System.Drawing.Point(417, 24);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(90, 56);
            this.buttonUpdate.TabIndex = 3;
            this.buttonUpdate.Text = "Cập nhật";
            this.buttonUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(82, 59);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(77, 16);
            this.labelQuantity.TabIndex = 17;
            this.labelQuantity.Text = "<Số lượng>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Số lượng :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "VNĐ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Giá tiền :";
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownPrice.Location = new System.Drawing.Point(83, 90);
            this.numericUpDownPrice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownPrice.TabIndex = 2;
            this.numericUpDownPrice.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // labelMeasurement
            // 
            this.labelMeasurement.AutoSize = true;
            this.labelMeasurement.Location = new System.Drawing.Point(165, 59);
            this.labelMeasurement.Name = "labelMeasurement";
            this.labelMeasurement.Size = new System.Drawing.Size(87, 16);
            this.labelMeasurement.TabIndex = 17;
            this.labelMeasurement.Text = "<Đơn vị tính>";
            // 
            // labelItemName
            // 
            this.labelItemName.AutoSize = true;
            this.labelItemName.Location = new System.Drawing.Point(83, 24);
            this.labelItemName.Name = "labelItemName";
            this.labelItemName.Size = new System.Drawing.Size(106, 16);
            this.labelItemName.TabIndex = 17;
            this.labelItemName.Text = "<Tên mặt hàng>";
            // 
            // columnAgentKindId
            // 
            this.columnAgentKindId.HeaderText = "Mã loại đại lý";
            this.columnAgentKindId.Name = "columnAgentKindId";
            this.columnAgentKindId.ReadOnly = true;
            this.columnAgentKindId.Visible = false;
            // 
            // columnKindOfAgent
            // 
            this.columnKindOfAgent.HeaderText = "Loại đại lý";
            this.columnKindOfAgent.Name = "columnKindOfAgent";
            this.columnKindOfAgent.ReadOnly = true;
            this.columnKindOfAgent.Width = 200;
            // 
            // columnPrice
            // 
            this.columnPrice.HeaderText = "Giá";
            this.columnPrice.Name = "columnPrice";
            this.columnPrice.ReadOnly = true;
            this.columnPrice.Width = 150;
            // 
            // columnMeasurement
            // 
            this.columnMeasurement.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnMeasurement.HeaderText = "Đơn vị";
            this.columnMeasurement.Name = "columnMeasurement";
            this.columnMeasurement.ReadOnly = true;
            // 
            // FormUpdateSellPriceForAgents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 600);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxListItems);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUpdateSellPriceForAgents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cập nhật giá bán mặt hàng";
            this.Load += new System.EventHandler(this.FormUpdateSellPriceForAgents_Load);
            this.groupBoxListItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItemList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxListItems;
        private System.Windows.Forms.DataGridView dataGridViewItemList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelItemId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.Label labelMeasurement;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAgentKindId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnKindOfAgent;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMeasurement;
        private System.Windows.Forms.Label labelItemName;
    }
}