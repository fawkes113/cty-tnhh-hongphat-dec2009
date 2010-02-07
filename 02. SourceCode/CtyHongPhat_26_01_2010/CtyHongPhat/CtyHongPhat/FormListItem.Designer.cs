namespace CtyHongPhat
{
    partial class FormListItem
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelItemId = new System.Windows.Forms.Label();
            this.textBoxMeasurement = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.comboBoxInfoKindOfAgent = new System.Windows.Forms.ComboBox();
            this.textBoxItemName = new System.Windows.Forms.TextBox();
            this.groupBoxListItems = new System.Windows.Forms.GroupBox();
            this.dataGridViewItemList = new System.Windows.Forms.DataGridView();
            this.columnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAgentKindId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnKindOfAgent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMeasurement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.comboBoxSearchKindOfAgent = new System.Windows.Forms.ComboBox();
            this.comboBoxAgentName = new System.Windows.Forms.ComboBox();
            this.comboBoxItemName = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            this.groupBoxListItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItemList)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.labelItemId);
            this.groupBox1.Controls.Add(this.textBoxMeasurement);
            this.groupBox1.Controls.Add(this.labelQuantity);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonDelete);
            this.groupBox1.Controls.Add(this.buttonInsert);
            this.groupBox1.Controls.Add(this.buttonUpdate);
            this.groupBox1.Controls.Add(this.numericUpDownPrice);
            this.groupBox1.Controls.Add(this.comboBoxInfoKindOfAgent);
            this.groupBox1.Controls.Add(this.textBoxItemName);
            this.groupBox1.Location = new System.Drawing.Point(15, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Size = new System.Drawing.Size(1082, 103);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin mặt hàng";
            // 
            // labelItemId
            // 
            this.labelItemId.AutoSize = true;
            this.labelItemId.Location = new System.Drawing.Point(369, 26);
            this.labelItemId.Name = "labelItemId";
            this.labelItemId.Size = new System.Drawing.Size(62, 16);
            this.labelItemId.TabIndex = 14;
            this.labelItemId.Text = "<itemId>";
            this.labelItemId.Visible = false;
            // 
            // textBoxMeasurement
            // 
            this.textBoxMeasurement.Location = new System.Drawing.Point(201, 63);
            this.textBoxMeasurement.Name = "textBoxMeasurement";
            this.textBoxMeasurement.Size = new System.Drawing.Size(147, 23);
            this.textBoxMeasurement.TabIndex = 1;
            this.textBoxMeasurement.Text = "<Đơn vị tính>";
            this.textBoxMeasurement.Leave += new System.EventHandler(this.textBoxMeasurement_Leave);
            this.textBoxMeasurement.Enter += new System.EventHandler(this.textBoxMeasurement_Enter);
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(84, 66);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(77, 16);
            this.labelQuantity.TabIndex = 13;
            this.labelQuantity.Text = "<Số lượng>";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(643, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "VNĐ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(441, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Giá tiền :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Loại đại lý :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Số lượng :";
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
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Image = global::CtyHongPhat.Properties.Resources.delete;
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonDelete.Location = new System.Drawing.Point(970, 23);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(94, 56);
            this.buttonDelete.TabIndex = 12;
            this.buttonDelete.Text = "Xóa";
            this.buttonDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInsert.Image = global::CtyHongPhat.Properties.Resources.select;
            this.buttonInsert.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonInsert.Location = new System.Drawing.Point(743, 23);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(97, 56);
            this.buttonInsert.TabIndex = 10;
            this.buttonInsert.Text = "Thêm mới";
            this.buttonInsert.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdate.Image = global::CtyHongPhat.Properties.Resources.modify;
            this.buttonUpdate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonUpdate.Location = new System.Drawing.Point(865, 23);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(90, 56);
            this.buttonUpdate.TabIndex = 11;
            this.buttonUpdate.Text = "Cập nhật";
            this.buttonUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownPrice.Location = new System.Drawing.Point(517, 61);
            this.numericUpDownPrice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownPrice.TabIndex = 3;
            this.numericUpDownPrice.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // comboBoxInfoKindOfAgent
            // 
            this.comboBoxInfoKindOfAgent.FormattingEnabled = true;
            this.comboBoxInfoKindOfAgent.Location = new System.Drawing.Point(517, 23);
            this.comboBoxInfoKindOfAgent.Name = "comboBoxInfoKindOfAgent";
            this.comboBoxInfoKindOfAgent.Size = new System.Drawing.Size(220, 24);
            this.comboBoxInfoKindOfAgent.TabIndex = 2;
            // 
            // textBoxItemName
            // 
            this.textBoxItemName.Location = new System.Drawing.Point(82, 23);
            this.textBoxItemName.Name = "textBoxItemName";
            this.textBoxItemName.Size = new System.Drawing.Size(266, 23);
            this.textBoxItemName.TabIndex = 0;
            // 
            // groupBoxListItems
            // 
            this.groupBoxListItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxListItems.Controls.Add(this.dataGridViewItemList);
            this.groupBoxListItems.Font = new System.Drawing.Font("Tahoma", 8.75F);
            this.groupBoxListItems.Location = new System.Drawing.Point(15, 129);
            this.groupBoxListItems.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBoxListItems.Name = "groupBoxListItems";
            this.groupBoxListItems.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBoxListItems.Size = new System.Drawing.Size(1082, 473);
            this.groupBoxListItems.TabIndex = 1;
            this.groupBoxListItems.TabStop = false;
            this.groupBoxListItems.Text = "Danh sách các mặt hàng";
            // 
            // dataGridViewItemList
            // 
            this.dataGridViewItemList.AllowUserToAddRows = false;
            this.dataGridViewItemList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridViewItemList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewItemList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnId,
            this.columnItemName,
            this.columnAgentKindId,
            this.columnKindOfAgent,
            this.columnPrice,
            this.columnQuantity,
            this.columnMeasurement});
            this.dataGridViewItemList.Location = new System.Drawing.Point(6, 23);
            this.dataGridViewItemList.Name = "dataGridViewItemList";
            this.dataGridViewItemList.ReadOnly = true;
            this.dataGridViewItemList.RowHeadersVisible = false;
            this.dataGridViewItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewItemList.Size = new System.Drawing.Size(1070, 442);
            this.dataGridViewItemList.TabIndex = 15;
            this.dataGridViewItemList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewItemList_CellMouseClick);
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
            // columnQuantity
            // 
            this.columnQuantity.HeaderText = "Tồn kho";
            this.columnQuantity.Name = "columnQuantity";
            this.columnQuantity.ReadOnly = true;
            this.columnQuantity.Width = 150;
            // 
            // columnMeasurement
            // 
            this.columnMeasurement.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnMeasurement.HeaderText = "Đơn vị";
            this.columnMeasurement.Name = "columnMeasurement";
            this.columnMeasurement.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.buttonSearch);
            this.groupBox3.Controls.Add(this.comboBoxSearchKindOfAgent);
            this.groupBox3.Controls.Add(this.comboBoxAgentName);
            this.groupBox3.Controls.Add(this.comboBoxItemName);
            this.groupBox3.Location = new System.Drawing.Point(12, 612);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox3.Size = new System.Drawing.Size(1082, 71);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin tìm kiếm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(404, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Tên đại lý :";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(694, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Loại đại lý :";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Mặt hàng :";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.Image = global::CtyHongPhat.Properties.Resources.search;
            this.buttonSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSearch.Location = new System.Drawing.Point(992, 16);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 47);
            this.buttonSearch.TabIndex = 25;
            this.buttonSearch.Text = "Tìm kiếm";
            this.buttonSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // comboBoxSearchKindOfAgent
            // 
            this.comboBoxSearchKindOfAgent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSearchKindOfAgent.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxSearchKindOfAgent.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxSearchKindOfAgent.FormattingEnabled = true;
            this.comboBoxSearchKindOfAgent.Location = new System.Drawing.Point(774, 28);
            this.comboBoxSearchKindOfAgent.Name = "comboBoxSearchKindOfAgent";
            this.comboBoxSearchKindOfAgent.Size = new System.Drawing.Size(184, 24);
            this.comboBoxSearchKindOfAgent.TabIndex = 22;
            this.comboBoxSearchKindOfAgent.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearchKindOfAgent_SelectedIndexChanged);
            this.comboBoxSearchKindOfAgent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxSearchKindOfAgent_KeyDown);
            // 
            // comboBoxAgentName
            // 
            this.comboBoxAgentName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxAgentName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxAgentName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxAgentName.FormattingEnabled = true;
            this.comboBoxAgentName.Location = new System.Drawing.Point(483, 28);
            this.comboBoxAgentName.Name = "comboBoxAgentName";
            this.comboBoxAgentName.Size = new System.Drawing.Size(172, 24);
            this.comboBoxAgentName.TabIndex = 21;
            this.comboBoxAgentName.SelectedIndexChanged += new System.EventHandler(this.comboBoxAgentName_SelectedIndexChanged);
            this.comboBoxAgentName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxAgentName_KeyDown);
            // 
            // comboBoxItemName
            // 
            this.comboBoxItemName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxItemName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxItemName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxItemName.FormattingEnabled = true;
            this.comboBoxItemName.Location = new System.Drawing.Point(82, 28);
            this.comboBoxItemName.Name = "comboBoxItemName";
            this.comboBoxItemName.Size = new System.Drawing.Size(254, 24);
            this.comboBoxItemName.TabIndex = 20;
            this.comboBoxItemName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxItemName_KeyDown);
            // 
            // FormListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 693);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBoxListItems);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FormListItem";
            this.Text = "Danh sách mặt hàng";
            this.Load += new System.EventHandler(this.FormListItem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            this.groupBoxListItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItemList)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxListItems;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxItemName;
        private System.Windows.Forms.ComboBox comboBoxInfoKindOfAgent;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.ComboBox comboBoxSearchKindOfAgent;
        private System.Windows.Forms.ComboBox comboBoxAgentName;
        private System.Windows.Forms.ComboBox comboBoxItemName;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridView dataGridViewItemList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxMeasurement;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAgentKindId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnKindOfAgent;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMeasurement;

    }
}