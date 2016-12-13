namespace UsedCarSales
{
    partial class AddEditPromotionForm
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
            this.discountAmountLabel = new System.Windows.Forms.Label();
            this.makeLabel = new System.Windows.Forms.Label();
            this.makeDropDownBox = new System.Windows.Forms.ComboBox();
            this.discountAmountTextBox = new System.Windows.Forms.TextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.percentageSymbolLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // discountAmountLabel
            // 
            this.discountAmountLabel.AutoSize = true;
            this.discountAmountLabel.Location = new System.Drawing.Point(10, 50);
            this.discountAmountLabel.Name = "discountAmountLabel";
            this.discountAmountLabel.Size = new System.Drawing.Size(115, 17);
            this.discountAmountLabel.TabIndex = 0;
            this.discountAmountLabel.Text = "Discount Amount";
            // 
            // makeLabel
            // 
            this.makeLabel.AutoSize = true;
            this.makeLabel.Location = new System.Drawing.Point(10, 12);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(42, 17);
            this.makeLabel.TabIndex = 1;
            this.makeLabel.Text = "Make";
            // 
            // makeDropDownBox
            // 
            this.makeDropDownBox.FormattingEnabled = true;
            this.makeDropDownBox.Location = new System.Drawing.Point(59, 12);
            this.makeDropDownBox.Name = "makeDropDownBox";
            this.makeDropDownBox.Size = new System.Drawing.Size(211, 24);
            this.makeDropDownBox.TabIndex = 2;
            // 
            // discountAmountTextBox
            // 
            this.discountAmountTextBox.Location = new System.Drawing.Point(132, 50);
            this.discountAmountTextBox.Name = "discountAmountTextBox";
            this.discountAmountTextBox.Size = new System.Drawing.Size(109, 22);
            this.discountAmountTextBox.TabIndex = 3;
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(12, 80);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(113, 30);
            this.confirmButton.TabIndex = 4;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(156, 80);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(114, 30);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // percentageSymbolLabel
            // 
            this.percentageSymbolLabel.AutoSize = true;
            this.percentageSymbolLabel.Location = new System.Drawing.Point(247, 53);
            this.percentageSymbolLabel.Name = "percentageSymbolLabel";
            this.percentageSymbolLabel.Size = new System.Drawing.Size(20, 17);
            this.percentageSymbolLabel.TabIndex = 6;
            this.percentageSymbolLabel.Text = "%";
            this.percentageSymbolLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // AddEditPromotionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 127);
            this.Controls.Add(this.percentageSymbolLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.discountAmountTextBox);
            this.Controls.Add(this.makeDropDownBox);
            this.Controls.Add(this.makeLabel);
            this.Controls.Add(this.discountAmountLabel);
            this.Name = "AddEditPromotionForm";
            this.Text = "AddEditPromotionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label discountAmountLabel;
        private System.Windows.Forms.Label makeLabel;
        private System.Windows.Forms.ComboBox makeDropDownBox;
        private System.Windows.Forms.TextBox discountAmountTextBox;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label percentageSymbolLabel;
    }
}