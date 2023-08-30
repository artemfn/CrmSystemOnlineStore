namespace CrmSystem.UI
{
    partial class ModelForm
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
            this.StartButton = new System.Windows.Forms.Button();
            this.CustomersProgressingSpeedNumeric = new System.Windows.Forms.NumericUpDown();
            this.CustomersProgressingSpeedLabel = new System.Windows.Forms.Label();
            this.CashDesksProgressingSpeedNumeric = new System.Windows.Forms.NumericUpDown();
            this.CashDesksProgressingSpeedLabel = new System.Windows.Forms.Label();
            this.StopButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersProgressingSpeedNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CashDesksProgressingSpeedNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StartButton.Location = new System.Drawing.Point(640, 326);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // CustomersProgressingSpeedNumeric
            // 
            this.CustomersProgressingSpeedNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomersProgressingSpeedNumeric.Location = new System.Drawing.Point(620, 64);
            this.CustomersProgressingSpeedNumeric.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.CustomersProgressingSpeedNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CustomersProgressingSpeedNumeric.Name = "CustomersProgressingSpeedNumeric";
            this.CustomersProgressingSpeedNumeric.Size = new System.Drawing.Size(173, 20);
            this.CustomersProgressingSpeedNumeric.TabIndex = 1;
            this.CustomersProgressingSpeedNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CustomersProgressingSpeedNumeric.ValueChanged += new System.EventHandler(this.CustomersProgressingSpeedNumeric_ValueChanged);
            // 
            // CustomersProgressingSpeedLabel
            // 
            this.CustomersProgressingSpeedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomersProgressingSpeedLabel.AutoSize = true;
            this.CustomersProgressingSpeedLabel.Location = new System.Drawing.Point(617, 48);
            this.CustomersProgressingSpeedLabel.Name = "CustomersProgressingSpeedLabel";
            this.CustomersProgressingSpeedLabel.Size = new System.Drawing.Size(167, 13);
            this.CustomersProgressingSpeedLabel.TabIndex = 2;
            this.CustomersProgressingSpeedLabel.Text = "Customers progressing speed (ms)";
            // 
            // CashDesksProgressingSpeedNumeric
            // 
            this.CashDesksProgressingSpeedNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CashDesksProgressingSpeedNumeric.Location = new System.Drawing.Point(620, 25);
            this.CashDesksProgressingSpeedNumeric.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.CashDesksProgressingSpeedNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CashDesksProgressingSpeedNumeric.Name = "CashDesksProgressingSpeedNumeric";
            this.CashDesksProgressingSpeedNumeric.Size = new System.Drawing.Size(173, 20);
            this.CashDesksProgressingSpeedNumeric.TabIndex = 1;
            this.CashDesksProgressingSpeedNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CashDesksProgressingSpeedNumeric.ValueChanged += new System.EventHandler(this.CashDesksProgressingSpeedNumeric_ValueChanged);
            // 
            // CashDesksProgressingSpeedLabel
            // 
            this.CashDesksProgressingSpeedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CashDesksProgressingSpeedLabel.AutoSize = true;
            this.CashDesksProgressingSpeedLabel.Location = new System.Drawing.Point(617, 9);
            this.CashDesksProgressingSpeedLabel.Name = "CashDesksProgressingSpeedLabel";
            this.CashDesksProgressingSpeedLabel.Size = new System.Drawing.Size(173, 13);
            this.CashDesksProgressingSpeedLabel.TabIndex = 2;
            this.CashDesksProgressingSpeedLabel.Text = "Cash desks progressing speed (ms)";
            // 
            // StopButton
            // 
            this.StopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StopButton.Location = new System.Drawing.Point(721, 326);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.TabIndex = 3;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // ModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 361);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.CashDesksProgressingSpeedLabel);
            this.Controls.Add(this.CashDesksProgressingSpeedNumeric);
            this.Controls.Add(this.CustomersProgressingSpeedLabel);
            this.Controls.Add(this.CustomersProgressingSpeedNumeric);
            this.Controls.Add(this.StartButton);
            this.Name = "ModelForm";
            this.Text = "ModelForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModelForm_FormClosing);
            this.Load += new System.EventHandler(this.ModelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomersProgressingSpeedNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CashDesksProgressingSpeedNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.NumericUpDown CustomersProgressingSpeedNumeric;
        private System.Windows.Forms.Label CustomersProgressingSpeedLabel;
        private System.Windows.Forms.NumericUpDown CashDesksProgressingSpeedNumeric;
        private System.Windows.Forms.Label CashDesksProgressingSpeedLabel;
        private System.Windows.Forms.Button StopButton;
    }
}