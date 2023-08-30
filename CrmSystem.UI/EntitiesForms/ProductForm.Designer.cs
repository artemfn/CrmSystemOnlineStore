namespace CrmSystem.UI.AddForms
{
    partial class ProductForm
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
            this.EnterNameLabel = new System.Windows.Forms.Label();
            this.EnterPriceLabel = new System.Windows.Forms.Label();
            this.EnterCountLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.PriceNumeric = new System.Windows.Forms.NumericUpDown();
            this.CountNumeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.PriceNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // EnterNameLabel
            // 
            this.EnterNameLabel.AutoSize = true;
            this.EnterNameLabel.Location = new System.Drawing.Point(13, 13);
            this.EnterNameLabel.Name = "EnterNameLabel";
            this.EnterNameLabel.Size = new System.Drawing.Size(61, 13);
            this.EnterNameLabel.TabIndex = 0;
            this.EnterNameLabel.Text = "Enter name";
            // 
            // EnterPriceLabel
            // 
            this.EnterPriceLabel.AutoSize = true;
            this.EnterPriceLabel.Location = new System.Drawing.Point(12, 43);
            this.EnterPriceLabel.Name = "EnterPriceLabel";
            this.EnterPriceLabel.Size = new System.Drawing.Size(58, 13);
            this.EnterPriceLabel.TabIndex = 1;
            this.EnterPriceLabel.Text = "Enter price";
            // 
            // EnterCountLabel
            // 
            this.EnterCountLabel.AutoSize = true;
            this.EnterCountLabel.Location = new System.Drawing.Point(12, 70);
            this.EnterCountLabel.Name = "EnterCountLabel";
            this.EnterCountLabel.Size = new System.Drawing.Size(62, 13);
            this.EnterCountLabel.TabIndex = 2;
            this.EnterCountLabel.Text = "Enter count";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Location = new System.Drawing.Point(81, 13);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(231, 20);
            this.NameTextBox.TabIndex = 3;
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkButton.Location = new System.Drawing.Point(237, 166);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 6;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // PriceNumeric
            // 
            this.PriceNumeric.DecimalPlaces = 2;
            this.PriceNumeric.Location = new System.Drawing.Point(81, 41);
            this.PriceNumeric.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.PriceNumeric.Name = "PriceNumeric";
            this.PriceNumeric.Size = new System.Drawing.Size(231, 20);
            this.PriceNumeric.TabIndex = 7;
            // 
            // CountNumeric
            // 
            this.CountNumeric.Location = new System.Drawing.Point(81, 70);
            this.CountNumeric.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.CountNumeric.Name = "CountNumeric";
            this.CountNumeric.Size = new System.Drawing.Size(231, 20);
            this.CountNumeric.TabIndex = 8;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 201);
            this.Controls.Add(this.CountNumeric);
            this.Controls.Add(this.PriceNumeric);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.EnterCountLabel);
            this.Controls.Add(this.EnterPriceLabel);
            this.Controls.Add(this.EnterNameLabel);
            this.Name = "ProductForm";
            this.Text = "ProductAddForm";
            ((System.ComponentModel.ISupportInitialize)(this.PriceNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EnterNameLabel;
        private System.Windows.Forms.Label EnterPriceLabel;
        private System.Windows.Forms.Label EnterCountLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.NumericUpDown PriceNumeric;
        private System.Windows.Forms.NumericUpDown CountNumeric;
    }
}