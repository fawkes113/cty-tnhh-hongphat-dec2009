namespace CtyHongPhat
{
    partial class FormMain
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
            this.tabControlMain = new MdiTabControl.TabControl();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.menu1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doiMatKhauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemOutputOder = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemInputOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemListItems = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemListOrders = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDebt = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemMagateEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemPrintPaySheet = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Alignment = MdiTabControl.TabControl.TabAlignment.Top;
            this.tabControlMain.BackColor = System.Drawing.SystemColors.Window;
            this.tabControlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlMain.Location = new System.Drawing.Point(0, 24);
            this.tabControlMain.MenuRenderer = null;
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.Size = new System.Drawing.Size(718, 426);
            this.tabControlMain.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.tabControlMain.TabBorderEnhanceWeight = MdiTabControl.TabControl.Weight.Medium;
            this.tabControlMain.TabCloseButtonImage = null;
            this.tabControlMain.TabCloseButtonImageDisabled = null;
            this.tabControlMain.TabCloseButtonImageHot = null;
            this.tabControlMain.TabGlassGradient = true;
            this.tabControlMain.TabIndex = 0;
            this.tabControlMain.TabMaximumWidth = 300;
            this.tabControlMain.TabsDirection = MdiTabControl.TabControl.FlowDirection.LeftToRight;
            // 
            // menuStripMain
            // 
            this.menuStripMain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu1ToolStripMenuItem,
            this.ToolStripMenuItem1,
            this.ToolStripMenuItemDebt,
            this.ToolStripMenuItemMagateEmployee,
            this.báoCáoToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStripMain.Size = new System.Drawing.Size(718, 24);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // menu1ToolStripMenuItem
            // 
            this.menu1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doiMatKhauToolStripMenuItem});
            this.menu1ToolStripMenuItem.Name = "menu1ToolStripMenuItem";
            this.menu1ToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.menu1ToolStripMenuItem.Text = "Hệ thống";
            // 
            // doiMatKhauToolStripMenuItem
            // 
            this.doiMatKhauToolStripMenuItem.Name = "doiMatKhauToolStripMenuItem";
            this.doiMatKhauToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.doiMatKhauToolStripMenuItem.Text = "Doi mat khau";
            this.doiMatKhauToolStripMenuItem.Click += new System.EventHandler(this.doiMatKhauToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemOutputOder,
            this.ToolStripMenuItemInputOrder,
            this.ToolStripMenuItemListItems,
            this.ToolStripMenuItemListOrders});
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(103, 20);
            this.ToolStripMenuItem1.Text = "Xuất nhập hàng";
            // 
            // ToolStripMenuItemOutputOder
            // 
            this.ToolStripMenuItemOutputOder.Name = "ToolStripMenuItemOutputOder";
            this.ToolStripMenuItemOutputOder.Size = new System.Drawing.Size(183, 22);
            this.ToolStripMenuItemOutputOder.Text = "Xuất hàng";
            this.ToolStripMenuItemOutputOder.Click += new System.EventHandler(this.ToolStripMenuItemOutputOder_Click);
            // 
            // ToolStripMenuItemInputOrder
            // 
            this.ToolStripMenuItemInputOrder.Name = "ToolStripMenuItemInputOrder";
            this.ToolStripMenuItemInputOrder.Size = new System.Drawing.Size(183, 22);
            this.ToolStripMenuItemInputOrder.Text = "Nhập hàng";
            this.ToolStripMenuItemInputOrder.Click += new System.EventHandler(this.ToolStripMenuItemInputOrder_Click);
            // 
            // ToolStripMenuItemListItems
            // 
            this.ToolStripMenuItemListItems.Name = "ToolStripMenuItemListItems";
            this.ToolStripMenuItemListItems.Size = new System.Drawing.Size(183, 22);
            this.ToolStripMenuItemListItems.Text = "Danh sách mặt hàng";
            this.ToolStripMenuItemListItems.Click += new System.EventHandler(this.ToolStripMenuItemListItems_Click);
            // 
            // ToolStripMenuItemListOrders
            // 
            this.ToolStripMenuItemListOrders.Name = "ToolStripMenuItemListOrders";
            this.ToolStripMenuItemListOrders.Size = new System.Drawing.Size(183, 22);
            this.ToolStripMenuItemListOrders.Text = "Quản lý hóa đơn";
            this.ToolStripMenuItemListOrders.Click += new System.EventHandler(this.ToolStripMenuItemListOrders_Click);
            // 
            // ToolStripMenuItemDebt
            // 
            this.ToolStripMenuItemDebt.Name = "ToolStripMenuItemDebt";
            this.ToolStripMenuItemDebt.Size = new System.Drawing.Size(107, 20);
            this.ToolStripMenuItemDebt.Text = "Quản lý công nợ";
            this.ToolStripMenuItemDebt.Click += new System.EventHandler(this.ToolStripMenuItemDebt_Click);
            // 
            // ToolStripMenuItemMagateEmployee
            // 
            this.ToolStripMenuItemMagateEmployee.Name = "ToolStripMenuItemMagateEmployee";
            this.ToolStripMenuItemMagateEmployee.Size = new System.Drawing.Size(115, 20);
            this.ToolStripMenuItemMagateEmployee.Text = "Quản lý nhân viên";
            this.ToolStripMenuItemMagateEmployee.Click += new System.EventHandler(this.ToolStripMenuItemMagateEmployee_Click);
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemPrintPaySheet});
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.báoCáoToolStripMenuItem.Text = "Báo cáo";
            // 
            // ToolStripMenuItemPrintPaySheet
            // 
            this.ToolStripMenuItemPrintPaySheet.Name = "ToolStripMenuItemPrintPaySheet";
            this.ToolStripMenuItemPrintPaySheet.Size = new System.Drawing.Size(148, 22);
            this.ToolStripMenuItemPrintPaySheet.Text = "In bảng lương";
            this.ToolStripMenuItemPrintPaySheet.Click += new System.EventHandler(this.ToolStripMenuItemPrintPaySheet_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 450);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.menuStripMain);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MdiTabControl.TabControl tabControlMain;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem menu1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doiMatKhauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemOutputOder;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemInputOrder;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDebt;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemMagateEmployee;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemListItems;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemListOrders;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemPrintPaySheet;
    }
}