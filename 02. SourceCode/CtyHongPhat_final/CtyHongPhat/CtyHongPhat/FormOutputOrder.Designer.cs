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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxInforAgent = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.labelTotalDebt = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelKindOfAngent = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxListAgents = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelMeasurement = new System.Windows.Forms.Label();
            this.dataGridViewListItems = new System.Windows.Forms.DataGridView();
            this.columnDelete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.columnItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMeasurement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTotalMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxListItems = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxListItems = new System.Windows.Forms.GroupBox();
            this.labelSellPrice = new System.Windows.Forms.Label();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxInforItem = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelRemainItemMeasurement = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxTotalAmount = new System.Windows.Forms.TextBox();
            this.numericUpDownPayAmount = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonRemoveChoicedItems = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBoxInforAgent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            this.groupBoxListItems.SuspendLayout();
            this.groupBoxInforItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPayAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxInforAgent
            // 
            this.groupBoxInforAgent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInforAgent.Controls.Add(this.label14);
            this.groupBoxInforAgent.Controls.Add(this.labelTotalDebt);
            this.groupBoxInforAgent.Controls.Add(this.label6);
            this.groupBoxInforAgent.Controls.Add(this.labelKindOfAngent);
            this.groupBoxInforAgent.Controls.Add(this.label2);
            this.groupBoxInforAgent.Controls.Add(this.comboBoxListAgents);
            this.groupBoxInforAgent.Controls.Add(this.label1);
            this.groupBoxInforAgent.Location = new System.Drawing.Point(14, 4);
            this.groupBoxInforAgent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxInforAgent.Name = "groupBoxInforAgent";
            this.groupBoxInforAgent.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxInforAgent.Size = new System.Drawing.Size(1036, 64);
            this.groupBoxInforAgent.TabIndex = 6;
            this.groupBoxInforAgent.TabStop = false;
            this.groupBoxInforAgent.Text = "Thông tin công ty";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(982, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 14);
            this.label14.TabIndex = 15;
            this.label14.Text = "VNĐ";
            // 
            // labelTotalDebt
            // 
            this.labelTotalDebt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotalDebt.AutoSize = true;
            this.labelTotalDebt.Location = new System.Drawing.Point(894, 26);
            this.labelTotalDebt.Name = "labelTotalDebt";
            this.labelTotalDebt.Size = new System.Drawing.Size(82, 14);
            this.labelTotalDebt.TabIndex = 11;
            this.labelTotalDebt.Text = "<Số tiền nợ>";
            this.labelTotalDebt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(834, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 14);
            this.label6.TabIndex = 10;
            this.label6.Text = "Còn nợ :";
            // 
            // labelKindOfAngent
            // 
            this.labelKindOfAngent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKindOfAngent.AutoSize = true;
            this.labelKindOfAngent.Location = new System.Drawing.Point(699, 26);
            this.labelKindOfAngent.Name = "labelKindOfAngent";
            this.labelKindOfAngent.Size = new System.Drawing.Size(81, 14);
            this.labelKindOfAngent.TabIndex = 9;
            this.labelKindOfAngent.Text = "<Loại đại lý >";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(626, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 14);
            this.label2.TabIndex = 8;
            this.label2.Text = "Loại đại lý :";
            // 
            // comboBoxListAgents
            // 
            this.comboBoxListAgents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxListAgents.FormattingEnabled = true;
            this.comboBoxListAgents.Location = new System.Drawing.Point(82, 23);
            this.comboBoxListAgents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxListAgents.Name = "comboBoxListAgents";
            this.comboBoxListAgents.Size = new System.Drawing.Size(459, 22);
            this.comboBoxListAgents.TabIndex = 1;
            this.comboBoxListAgents.SelectedIndexChanged += new System.EventHandler(this.comboBoxListAgents_SelectedIndexChanged);
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
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(79, 63);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(125, 14);
            this.labelQuantity.TabIndex = 16;
            this.labelQuantity.Text = "<Số lương tồn kho >";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 14);
            this.label9.TabIndex = 15;
            this.label9.Text = "Tồn kho :";
            // 
            // labelMeasurement
            // 
            this.labelMeasurement.AutoSize = true;
            this.labelMeasurement.Location = new System.Drawing.Point(289, 98);
            this.labelMeasurement.Name = "labelMeasurement";
            this.labelMeasurement.Size = new System.Drawing.Size(63, 14);
            this.labelMeasurement.TabIndex = 18;
            this.labelMeasurement.Text = "<Đơn vị >";
            // 
            // dataGridViewListItems
            // 
            this.dataGridViewListItems.AllowUserToAddRows = false;
            this.dataGridViewListItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewListItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnDelete,
            this.columnItemId,
            this.columnItemName,
            this.columnQuantity,
            this.columnMeasurement,
            this.columnPrice,
            this.columnTotalMoney});
            this.dataGridViewListItems.Location = new System.Drawing.Point(8, 24);
            this.dataGridViewListItems.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewListItems.Name = "dataGridViewListItems";
            this.dataGridViewListItems.RowHeadersVisible = false;
            this.dataGridViewListItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListItems.Size = new System.Drawing.Size(1016, 336);
            this.dataGridViewListItems.TabIndex = 19;
            this.dataGridViewListItems.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridViewListItems_RowsRemoved);
            // 
            // columnDelete
            // 
            this.columnDelete.HeaderText = "Loại bỏ";
            this.columnDelete.Name = "columnDelete";
            this.columnDelete.ThreeState = true;
            // 
            // columnItemId
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.columnItemId.DefaultCellStyle = dataGridViewCellStyle1;
            this.columnItemId.HeaderText = "Mã mặt hàng";
            this.columnItemId.Name = "columnItemId";
            this.columnItemId.ReadOnly = true;
            this.columnItemId.Width = 110;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.columnQuantity.DefaultCellStyle = dataGridViewCellStyle2;
            this.columnQuantity.HeaderText = "Số lương";
            this.columnQuantity.Name = "columnQuantity";
            this.columnQuantity.ReadOnly = true;
            this.columnQuantity.Width = 150;
            // 
            // columnMeasurement
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.columnMeasurement.DefaultCellStyle = dataGridViewCellStyle3;
            this.columnMeasurement.HeaderText = "Đơn vị ";
            this.columnMeasurement.Name = "columnMeasurement";
            this.columnMeasurement.ReadOnly = true;
            // 
            // columnPrice
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.columnPrice.DefaultCellStyle = dataGridViewCellStyle4;
            this.columnPrice.HeaderText = "Đơn giá";
            this.columnPrice.Name = "columnPrice";
            this.columnPrice.ReadOnly = true;
            // 
            // columnTotalMoney
            // 
            this.columnTotalMoney.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.columnTotalMoney.DefaultCellStyle = dataGridViewCellStyle5;
            this.columnTotalMoney.HeaderText = "Thành tiền";
            this.columnTotalMoney.Name = "columnTotalMoney";
            this.columnTotalMoney.ReadOnly = true;
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Location = new System.Drawing.Point(82, 96);
            this.numericUpDownQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownQuantity.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(201, 22);
            this.numericUpDownQuantity.TabIndex = 3;
            this.numericUpDownQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 14);
            this.label7.TabIndex = 17;
            this.label7.Text = "Số lượng :";
            // 
            // comboBoxListItems
            // 
            this.comboBoxListItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxListItems.FormattingEnabled = true;
            this.comboBoxListItems.Location = new System.Drawing.Point(82, 21);
            this.comboBoxListItems.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxListItems.Name = "comboBoxListItems";
            this.comboBoxListItems.Size = new System.Drawing.Size(329, 22);
            this.comboBoxListItems.TabIndex = 2;
            this.comboBoxListItems.SelectedIndexChanged += new System.EventHandler(this.comboBoxListItems_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(449, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 14);
            this.label4.TabIndex = 13;
            this.label4.Text = "Giá :";
            // 
            // groupBoxListItems
            // 
            this.groupBoxListItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxListItems.Controls.Add(this.dataGridViewListItems);
            this.groupBoxListItems.Location = new System.Drawing.Point(14, 222);
            this.groupBoxListItems.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxListItems.Name = "groupBoxListItems";
            this.groupBoxListItems.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxListItems.Size = new System.Drawing.Size(1036, 374);
            this.groupBoxListItems.TabIndex = 7;
            this.groupBoxListItems.TabStop = false;
            this.groupBoxListItems.Text = "Danh sách mặt hàng";
            // 
            // labelSellPrice
            // 
            this.labelSellPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSellPrice.AutoSize = true;
            this.labelSellPrice.Location = new System.Drawing.Point(486, 24);
            this.labelSellPrice.Name = "labelSellPrice";
            this.labelSellPrice.Size = new System.Drawing.Size(122, 14);
            this.labelSellPrice.TabIndex = 14;
            this.labelSellPrice.Text = "<Đơn giá mặt hàng>";
            this.labelSellPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonPrint
            // 
            this.buttonPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrint.Image = global::CtyHongPhat.Properties.Resources.Printer;
            this.buttonPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonPrint.Location = new System.Drawing.Point(921, 601);
            this.buttonPrint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(90, 56);
            this.buttonPrint.TabIndex = 7;
            this.buttonPrint.Text = "In phiếu";
            this.buttonPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
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
            this.groupBoxInforItem.Controls.Add(this.label5);
            this.groupBoxInforItem.Controls.Add(this.labelRemainItemMeasurement);
            this.groupBoxInforItem.Controls.Add(this.buttonAdd);
            this.groupBoxInforItem.Controls.Add(this.labelQuantity);
            this.groupBoxInforItem.Controls.Add(this.label9);
            this.groupBoxInforItem.Controls.Add(this.labelMeasurement);
            this.groupBoxInforItem.Controls.Add(this.numericUpDownQuantity);
            this.groupBoxInforItem.Controls.Add(this.label7);
            this.groupBoxInforItem.Controls.Add(this.labelSellPrice);
            this.groupBoxInforItem.Controls.Add(this.comboBoxListItems);
            this.groupBoxInforItem.Controls.Add(this.label4);
            this.groupBoxInforItem.Controls.Add(this.label3);
            this.groupBoxInforItem.Location = new System.Drawing.Point(14, 75);
            this.groupBoxInforItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxInforItem.Name = "groupBoxInforItem";
            this.groupBoxInforItem.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxInforItem.Size = new System.Drawing.Size(906, 139);
            this.groupBoxInforItem.TabIndex = 9;
            this.groupBoxInforItem.TabStop = false;
            this.groupBoxInforItem.Text = "Thông tin mặt hàng";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(614, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 14);
            this.label5.TabIndex = 20;
            this.label5.Text = "VNĐ";
            // 
            // labelRemainItemMeasurement
            // 
            this.labelRemainItemMeasurement.AutoSize = true;
            this.labelRemainItemMeasurement.Location = new System.Drawing.Point(289, 63);
            this.labelRemainItemMeasurement.Name = "labelRemainItemMeasurement";
            this.labelRemainItemMeasurement.Size = new System.Drawing.Size(63, 14);
            this.labelRemainItemMeasurement.TabIndex = 19;
            this.labelRemainItemMeasurement.Text = "<Đơn vị >";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Image = global::CtyHongPhat.Properties.Resources.Good_32x32;
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAdd.Location = new System.Drawing.Point(451, 60);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(90, 71);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Thêm  vào hóa đơn";
            this.buttonAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxTotalAmount
            // 
            this.textBoxTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxTotalAmount.Location = new System.Drawing.Point(135, 603);
            this.textBoxTotalAmount.Name = "textBoxTotalAmount";
            this.textBoxTotalAmount.ReadOnly = true;
            this.textBoxTotalAmount.Size = new System.Drawing.Size(150, 22);
            this.textBoxTotalAmount.TabIndex = 10;
            this.textBoxTotalAmount.Text = "0";
            this.textBoxTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericUpDownPayAmount
            // 
            this.numericUpDownPayAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDownPayAmount.Location = new System.Drawing.Point(135, 641);
            this.numericUpDownPayAmount.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.numericUpDownPayAmount.Name = "numericUpDownPayAmount";
            this.numericUpDownPayAmount.Size = new System.Drawing.Size(150, 22);
            this.numericUpDownPayAmount.TabIndex = 11;
            this.numericUpDownPayAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 606);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 14);
            this.label8.TabIndex = 12;
            this.label8.Text = "Tổng tiền phải trả :";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 643);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 14);
            this.label11.TabIndex = 13;
            this.label11.Text = "Số tiền trả :";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(291, 606);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 14);
            this.label12.TabIndex = 14;
            this.label12.Text = "VNĐ";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(291, 643);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 14);
            this.label13.TabIndex = 15;
            this.label13.Text = "VNĐ";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefresh.Image = global::CtyHongPhat.Properties.Resources.refresh;
            this.buttonRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonRefresh.Location = new System.Drawing.Point(939, 152);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(90, 56);
            this.buttonRefresh.TabIndex = 16;
            this.buttonRefresh.Text = "Làm mới";
            this.buttonRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonRemoveChoicedItems
            // 
            this.buttonRemoveChoicedItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemoveChoicedItems.Image = global::CtyHongPhat.Properties.Resources.delete;
            this.buttonRemoveChoicedItems.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonRemoveChoicedItems.Location = new System.Drawing.Point(939, 85);
            this.buttonRemoveChoicedItems.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonRemoveChoicedItems.Name = "buttonRemoveChoicedItems";
            this.buttonRemoveChoicedItems.Size = new System.Drawing.Size(90, 56);
            this.buttonRemoveChoicedItems.TabIndex = 5;
            this.buttonRemoveChoicedItems.Text = "Loại các mặt hàng đã chọn";
            this.buttonRemoveChoicedItems.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonRemoveChoicedItems.UseVisualStyleBackColor = true;
            this.buttonRemoveChoicedItems.Click += new System.EventHandler(this.buttonRemoveChoicedItems_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Image = global::CtyHongPhat.Properties.Resources._new;
            this.buttonSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSave.Location = new System.Drawing.Point(787, 601);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(90, 56);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Lưu hóa đơn";
            this.buttonSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // FormOutputOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 685);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.buttonRemoveChoicedItems);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericUpDownPayAmount);
            this.Controls.Add(this.textBoxTotalAmount);
            this.Controls.Add(this.groupBoxInforAgent);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBoxListItems);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.groupBoxInforItem);
            this.Font = new System.Drawing.Font("Tahoma", 8.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormOutputOrder";
            this.Text = "Xuất hàng";
            this.Load += new System.EventHandler(this.FormOutputOrder_Load);
            this.groupBoxInforAgent.ResumeLayout(false);
            this.groupBoxInforAgent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            this.groupBoxListItems.ResumeLayout(false);
            this.groupBoxInforItem.ResumeLayout(false);
            this.groupBoxInforItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPayAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRemoveChoicedItems;
        private System.Windows.Forms.GroupBox groupBoxInforAgent;
        private System.Windows.Forms.Label labelTotalDebt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelKindOfAngent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxListAgents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelMeasurement;
        private System.Windows.Forms.DataGridView dataGridViewListItems;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxListItems;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.GroupBox groupBoxListItems;
        private System.Windows.Forms.Label labelSellPrice;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxInforItem;
        private System.Windows.Forms.TextBox textBoxTotalAmount;
        private System.Windows.Forms.NumericUpDown numericUpDownPayAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labelRemainItemMeasurement;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn columnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMeasurement;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTotalMoney;
    }
}