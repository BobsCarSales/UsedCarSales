namespace UsedCarSales
{
    partial class ViewVehicleForm
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
            this.modelValueLabel = new System.Windows.Forms.Label();
            this.makeValueLabel = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.soldValueLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.yearValueLabel = new System.Windows.Forms.Label();
            this.usedLabel = new System.Windows.Forms.Label();
            this.usedValueLabel = new System.Windows.Forms.Label();
            this.soldLabel = new System.Windows.Forms.Label();
            this.makeLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceValueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // modelValueLabel
            // 
            this.modelValueLabel.AutoSize = true;
            this.modelValueLabel.Location = new System.Drawing.Point(103, 63);
            this.modelValueLabel.Name = "modelValueLabel";
            this.modelValueLabel.Size = new System.Drawing.Size(86, 17);
            this.modelValueLabel.TabIndex = 3;
            this.modelValueLabel.Text = "Model Value";
            // 
            // makeValueLabel
            // 
            this.makeValueLabel.AutoSize = true;
            this.makeValueLabel.Location = new System.Drawing.Point(103, 31);
            this.makeValueLabel.Name = "makeValueLabel";
            this.makeValueLabel.Size = new System.Drawing.Size(82, 17);
            this.makeValueLabel.TabIndex = 1;
            this.makeValueLabel.Text = "Make Value";
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(40, 63);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(46, 17);
            this.modelLabel.TabIndex = 2;
            this.modelLabel.Text = "Model";
            // 
            // soldValueLabel
            // 
            this.soldValueLabel.AutoSize = true;
            this.soldValueLabel.Location = new System.Drawing.Point(103, 148);
            this.soldValueLabel.Name = "soldValueLabel";
            this.soldValueLabel.Size = new System.Drawing.Size(76, 17);
            this.soldValueLabel.TabIndex = 9;
            this.soldValueLabel.Text = "Sold Value";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(40, 92);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(38, 17);
            this.yearLabel.TabIndex = 4;
            this.yearLabel.Text = "Year";
            // 
            // yearValueLabel
            // 
            this.yearValueLabel.AutoSize = true;
            this.yearValueLabel.Location = new System.Drawing.Point(103, 92);
            this.yearValueLabel.Name = "yearValueLabel";
            this.yearValueLabel.Size = new System.Drawing.Size(78, 17);
            this.yearValueLabel.TabIndex = 5;
            this.yearValueLabel.Text = "Year Value";
            // 
            // usedLabel
            // 
            this.usedLabel.AutoSize = true;
            this.usedLabel.Location = new System.Drawing.Point(40, 121);
            this.usedLabel.Name = "usedLabel";
            this.usedLabel.Size = new System.Drawing.Size(41, 17);
            this.usedLabel.TabIndex = 6;
            this.usedLabel.Text = "Used";
            // 
            // usedValueLabel
            // 
            this.usedValueLabel.AutoSize = true;
            this.usedValueLabel.Location = new System.Drawing.Point(103, 121);
            this.usedValueLabel.Name = "usedValueLabel";
            this.usedValueLabel.Size = new System.Drawing.Size(81, 17);
            this.usedValueLabel.TabIndex = 7;
            this.usedValueLabel.Text = "Used Value";
            // 
            // soldLabel
            // 
            this.soldLabel.AutoSize = true;
            this.soldLabel.Location = new System.Drawing.Point(40, 148);
            this.soldLabel.Name = "soldLabel";
            this.soldLabel.Size = new System.Drawing.Size(36, 17);
            this.soldLabel.TabIndex = 8;
            this.soldLabel.Text = "Sold";
            // 
            // makeLabel
            // 
            this.makeLabel.AutoSize = true;
            this.makeLabel.Location = new System.Drawing.Point(40, 31);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(42, 17);
            this.makeLabel.TabIndex = 0;
            this.makeLabel.Text = "Make";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(40, 174);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(40, 17);
            this.priceLabel.TabIndex = 10;
            this.priceLabel.Text = "Price";
            // 
            // priceValueLabel
            // 
            this.priceValueLabel.AutoSize = true;
            this.priceValueLabel.Location = new System.Drawing.Point(103, 174);
            this.priceValueLabel.Name = "priceValueLabel";
            this.priceValueLabel.Size = new System.Drawing.Size(80, 17);
            this.priceValueLabel.TabIndex = 11;
            this.priceValueLabel.Text = "Price Value";
            // 
            // ViewVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 214);
            this.Controls.Add(this.priceValueLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.soldValueLabel);
            this.Controls.Add(this.soldLabel);
            this.Controls.Add(this.usedValueLabel);
            this.Controls.Add(this.usedLabel);
            this.Controls.Add(this.yearValueLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.modelValueLabel);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.makeValueLabel);
            this.Controls.Add(this.makeLabel);
            this.Name = "ViewVehicleForm";
            this.Text = "ViewVehicleForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label modelValueLabel;
        private System.Windows.Forms.Label makeValueLabel;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label soldValueLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label yearValueLabel;
        private System.Windows.Forms.Label usedLabel;
        private System.Windows.Forms.Label usedValueLabel;
        private System.Windows.Forms.Label soldLabel;
        private System.Windows.Forms.Label makeLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label priceValueLabel;
    }
}