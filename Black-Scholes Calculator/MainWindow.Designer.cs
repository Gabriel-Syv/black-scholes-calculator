namespace Black_Scholes_Calculator
{
    partial class MainWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.valuationDateField = new System.Windows.Forms.DateTimePicker();
            this.expiryDateField = new System.Windows.Forms.DateTimePicker();
            this.strikeField = new System.Windows.Forms.TextBox();
            this.priceField = new System.Windows.Forms.TextBox();
            this.volatilityField = new System.Windows.Forms.TextBox();
            this.rateField = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.assetPriceField = new System.Windows.Forms.TextBox();
            this.volatilityButton = new System.Windows.Forms.Button();
            this.priceButton = new System.Windows.Forms.Button();
            this.expirationDateChecked = new System.Windows.Forms.RadioButton();
            this.timeChecked = new System.Windows.Forms.RadioButton();
            this.timeField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Strike (K):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Risk-Free Rate:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Volatility:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Valuation Date:";
            // 
            // valuationDateField
            // 
            this.valuationDateField.Location = new System.Drawing.Point(15, 25);
            this.valuationDateField.Name = "valuationDateField";
            this.valuationDateField.Size = new System.Drawing.Size(137, 20);
            this.valuationDateField.TabIndex = 1;
            // 
            // expiryDateField
            // 
            this.expiryDateField.Location = new System.Drawing.Point(15, 133);
            this.expiryDateField.Name = "expiryDateField";
            this.expiryDateField.Size = new System.Drawing.Size(137, 20);
            this.expiryDateField.TabIndex = 9;
            // 
            // strikeField
            // 
            this.strikeField.Location = new System.Drawing.Point(158, 25);
            this.strikeField.Name = "strikeField";
            this.strikeField.Size = new System.Drawing.Size(100, 20);
            this.strikeField.TabIndex = 2;
            // 
            // priceField
            // 
            this.priceField.Location = new System.Drawing.Point(264, 65);
            this.priceField.Name = "priceField";
            this.priceField.Size = new System.Drawing.Size(100, 20);
            this.priceField.TabIndex = 6;
            // 
            // volatilityField
            // 
            this.volatilityField.Location = new System.Drawing.Point(15, 65);
            this.volatilityField.Name = "volatilityField";
            this.volatilityField.Size = new System.Drawing.Size(100, 20);
            this.volatilityField.TabIndex = 4;
            // 
            // rateField
            // 
            this.rateField.Location = new System.Drawing.Point(121, 65);
            this.rateField.Name = "rateField";
            this.rateField.Size = new System.Drawing.Size(100, 20);
            this.rateField.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(261, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Asset price (S):";
            // 
            // assetPriceField
            // 
            this.assetPriceField.Location = new System.Drawing.Point(264, 25);
            this.assetPriceField.Name = "assetPriceField";
            this.assetPriceField.Size = new System.Drawing.Size(100, 20);
            this.assetPriceField.TabIndex = 3;
            // 
            // volatilityButton
            // 
            this.volatilityButton.Location = new System.Drawing.Point(289, 101);
            this.volatilityButton.Name = "volatilityButton";
            this.volatilityButton.Size = new System.Drawing.Size(75, 23);
            this.volatilityButton.TabIndex = 10;
            this.volatilityButton.Text = "&Volatility";
            this.volatilityButton.UseVisualStyleBackColor = true;
            this.volatilityButton.Click += new System.EventHandler(this.volatilityButton_Click);
            // 
            // priceButton
            // 
            this.priceButton.Location = new System.Drawing.Point(289, 130);
            this.priceButton.Name = "priceButton";
            this.priceButton.Size = new System.Drawing.Size(75, 23);
            this.priceButton.TabIndex = 11;
            this.priceButton.Text = "&Option price";
            this.priceButton.UseVisualStyleBackColor = true;
            this.priceButton.Click += new System.EventHandler(this.priceButton_Click);
            // 
            // expirationDateChecked
            // 
            this.expirationDateChecked.AutoSize = true;
            this.expirationDateChecked.Location = new System.Drawing.Point(15, 110);
            this.expirationDateChecked.Name = "expirationDateChecked";
            this.expirationDateChecked.Size = new System.Drawing.Size(82, 17);
            this.expirationDateChecked.TabIndex = 7;
            this.expirationDateChecked.TabStop = true;
            this.expirationDateChecked.Text = "Expiry Date:";
            this.expirationDateChecked.UseVisualStyleBackColor = true;
            // 
            // timeChecked
            // 
            this.timeChecked.AutoSize = true;
            this.timeChecked.Checked = true;
            this.timeChecked.Location = new System.Drawing.Point(158, 110);
            this.timeChecked.Name = "timeChecked";
            this.timeChecked.Size = new System.Drawing.Size(93, 17);
            this.timeChecked.TabIndex = 8;
            this.timeChecked.TabStop = true;
            this.timeChecked.Text = "Time to expiry:";
            this.timeChecked.UseVisualStyleBackColor = true;
            // 
            // timeField
            // 
            this.timeField.Location = new System.Drawing.Point(158, 133);
            this.timeField.Name = "timeField";
            this.timeField.Size = new System.Drawing.Size(100, 20);
            this.timeField.TabIndex = 9;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 167);
            this.Controls.Add(this.timeField);
            this.Controls.Add(this.timeChecked);
            this.Controls.Add(this.expirationDateChecked);
            this.Controls.Add(this.priceButton);
            this.Controls.Add(this.volatilityButton);
            this.Controls.Add(this.assetPriceField);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rateField);
            this.Controls.Add(this.volatilityField);
            this.Controls.Add(this.priceField);
            this.Controls.Add(this.strikeField);
            this.Controls.Add(this.expiryDateField);
            this.Controls.Add(this.valuationDateField);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Black-Scholes Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker valuationDateField;
        private System.Windows.Forms.DateTimePicker expiryDateField;
        private System.Windows.Forms.TextBox strikeField;
        private System.Windows.Forms.TextBox priceField;
        private System.Windows.Forms.TextBox volatilityField;
        private System.Windows.Forms.TextBox rateField;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox assetPriceField;
        private System.Windows.Forms.Button volatilityButton;
        private System.Windows.Forms.Button priceButton;
        private System.Windows.Forms.RadioButton expirationDateChecked;
        private System.Windows.Forms.RadioButton timeChecked;
        private System.Windows.Forms.TextBox timeField;
    }
}

