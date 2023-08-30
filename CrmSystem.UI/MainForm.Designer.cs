namespace CrmSystem.UI
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.EntitiesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductsAddMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomersAddMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SellersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SellersAddMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChecksMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SellsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModelMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductsListBox = new System.Windows.Forms.ListBox();
            this.CartListBox = new System.Windows.Forms.ListBox();
            this.FullPriceLabel = new System.Windows.Forms.Label();
            this.PayButton = new System.Windows.Forms.Button();
            this.LoginLinkedLabel = new System.Windows.Forms.LinkLabel();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EntitiesMenu,
            this.ModelMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(934, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // EntitiesMenu
            // 
            this.EntitiesMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProductsMenuItem,
            this.CustomersMenuItem,
            this.SellersMenuItem,
            this.ChecksMenuItem,
            this.SellsMenuItem});
            this.EntitiesMenu.Name = "EntitiesMenu";
            this.EntitiesMenu.Size = new System.Drawing.Size(57, 20);
            this.EntitiesMenu.Text = "Entities";
            // 
            // ProductsMenuItem
            // 
            this.ProductsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProductsAddMenuItem});
            this.ProductsMenuItem.Name = "ProductsMenuItem";
            this.ProductsMenuItem.Size = new System.Drawing.Size(126, 22);
            this.ProductsMenuItem.Text = "Products";
            this.ProductsMenuItem.Click += new System.EventHandler(this.ProductsMenuItem_Click);
            // 
            // ProductsAddMenuItem
            // 
            this.ProductsAddMenuItem.Name = "ProductsAddMenuItem";
            this.ProductsAddMenuItem.Size = new System.Drawing.Size(96, 22);
            this.ProductsAddMenuItem.Text = "Add";
            this.ProductsAddMenuItem.Click += new System.EventHandler(this.ProductsAddMenuItem_Click);
            // 
            // CustomersMenuItem
            // 
            this.CustomersMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CustomersAddMenuItem});
            this.CustomersMenuItem.Name = "CustomersMenuItem";
            this.CustomersMenuItem.Size = new System.Drawing.Size(126, 22);
            this.CustomersMenuItem.Text = "Customer";
            this.CustomersMenuItem.Click += new System.EventHandler(this.CustomersMenuItem_Click);
            // 
            // CustomersAddMenuItem
            // 
            this.CustomersAddMenuItem.Name = "CustomersAddMenuItem";
            this.CustomersAddMenuItem.Size = new System.Drawing.Size(96, 22);
            this.CustomersAddMenuItem.Text = "Add";
            this.CustomersAddMenuItem.Click += new System.EventHandler(this.CustomersAddMenuItem_Click);
            // 
            // SellersMenuItem
            // 
            this.SellersMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SellersAddMenuItem});
            this.SellersMenuItem.Name = "SellersMenuItem";
            this.SellersMenuItem.Size = new System.Drawing.Size(126, 22);
            this.SellersMenuItem.Text = "Sellers";
            this.SellersMenuItem.Click += new System.EventHandler(this.SellersMenuItem_Click);
            // 
            // SellersAddMenuItem
            // 
            this.SellersAddMenuItem.Name = "SellersAddMenuItem";
            this.SellersAddMenuItem.Size = new System.Drawing.Size(96, 22);
            this.SellersAddMenuItem.Text = "Add";
            this.SellersAddMenuItem.Click += new System.EventHandler(this.SellersAddMenuItem_Click);
            // 
            // ChecksMenuItem
            // 
            this.ChecksMenuItem.Name = "ChecksMenuItem";
            this.ChecksMenuItem.Size = new System.Drawing.Size(126, 22);
            this.ChecksMenuItem.Text = "Checks";
            this.ChecksMenuItem.Click += new System.EventHandler(this.ChecksMenuItem_Click);
            // 
            // SellsMenuItem
            // 
            this.SellsMenuItem.Name = "SellsMenuItem";
            this.SellsMenuItem.Size = new System.Drawing.Size(126, 22);
            this.SellsMenuItem.Text = "Sells";
            this.SellsMenuItem.Click += new System.EventHandler(this.SellsMenuItem_Click);
            // 
            // ModelMenu
            // 
            this.ModelMenu.Name = "ModelMenu";
            this.ModelMenu.Size = new System.Drawing.Size(53, 20);
            this.ModelMenu.Text = "Model";
            this.ModelMenu.Click += new System.EventHandler(this.ModelMenu_Click);
            // 
            // ProductsListBox
            // 
            this.ProductsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ProductsListBox.FormattingEnabled = true;
            this.ProductsListBox.Location = new System.Drawing.Point(12, 27);
            this.ProductsListBox.Name = "ProductsListBox";
            this.ProductsListBox.Size = new System.Drawing.Size(250, 550);
            this.ProductsListBox.TabIndex = 1;
            this.ProductsListBox.DoubleClick += new System.EventHandler(this.ProductsListBox_DoubleClick);
            // 
            // CartListBox
            // 
            this.CartListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CartListBox.FormattingEnabled = true;
            this.CartListBox.Location = new System.Drawing.Point(283, 27);
            this.CartListBox.Name = "CartListBox";
            this.CartListBox.Size = new System.Drawing.Size(250, 524);
            this.CartListBox.TabIndex = 3;
            this.CartListBox.DoubleClick += new System.EventHandler(this.CartListBox_DoubleClick);
            // 
            // FullPriceLabel
            // 
            this.FullPriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FullPriceLabel.AutoSize = true;
            this.FullPriceLabel.Location = new System.Drawing.Point(282, 562);
            this.FullPriceLabel.Name = "FullPriceLabel";
            this.FullPriceLabel.Size = new System.Drawing.Size(61, 13);
            this.FullPriceLabel.TabIndex = 4;
            this.FullPriceLabel.Text = "Full price: 0";
            // 
            // PayButton
            // 
            this.PayButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PayButton.Location = new System.Drawing.Point(283, 584);
            this.PayButton.Name = "PayButton";
            this.PayButton.Size = new System.Drawing.Size(250, 23);
            this.PayButton.TabIndex = 5;
            this.PayButton.Text = "Pay";
            this.PayButton.UseVisualStyleBackColor = true;
            this.PayButton.Click += new System.EventHandler(this.PayButton_Click);
            // 
            // LoginLinkedLabel
            // 
            this.LoginLinkedLabel.ActiveLinkColor = System.Drawing.Color.Fuchsia;
            this.LoginLinkedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginLinkedLabel.AutoSize = true;
            this.LoginLinkedLabel.Location = new System.Drawing.Point(886, 27);
            this.LoginLinkedLabel.Name = "LoginLinkedLabel";
            this.LoginLinkedLabel.Size = new System.Drawing.Size(36, 13);
            this.LoginLinkedLabel.TabIndex = 6;
            this.LoginLinkedLabel.TabStop = true;
            this.LoginLinkedLabel.Text = "Log in";
            this.LoginLinkedLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LoginLinkedLabel_LinkClicked);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UpdateButton.Location = new System.Drawing.Point(13, 584);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(249, 23);
            this.UpdateButton.TabIndex = 7;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.LoginLinkedLabel);
            this.Controls.Add(this.PayButton);
            this.Controls.Add(this.FullPriceLabel);
            this.Controls.Add(this.CartListBox);
            this.Controls.Add(this.ProductsListBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem EntitiesMenu;
        private System.Windows.Forms.ToolStripMenuItem ProductsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProductsAddMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CustomersMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CustomersAddMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SellersMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SellersAddMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ModelMenu;
        private System.Windows.Forms.ListBox ProductsListBox;
        private System.Windows.Forms.ListBox CartListBox;
        private System.Windows.Forms.Label FullPriceLabel;
        private System.Windows.Forms.Button PayButton;
        private System.Windows.Forms.LinkLabel LoginLinkedLabel;
        private System.Windows.Forms.ToolStripMenuItem ChecksMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SellsMenuItem;
        private System.Windows.Forms.Button UpdateButton;
    }
}