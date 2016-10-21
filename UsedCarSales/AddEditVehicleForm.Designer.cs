namespace UsedCarSales
{
    partial class AddEditVehicleForm
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
            this.usedCheckBox = new System.Windows.Forms.CheckBox();
            this.makeLabel = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.soldCheckBox = new System.Windows.Forms.CheckBox();
            this.makeDropDown = new System.Windows.Forms.ComboBox();
            this.modelDropDown = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // usedCheckBox
            // 
            this.usedCheckBox.AutoSize = true;
            this.usedCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.usedCheckBox.Location = new System.Drawing.Point(220, 22);
            this.usedCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usedCheckBox.Name = "usedCheckBox";
            this.usedCheckBox.Size = new System.Drawing.Size(63, 21);
            this.usedCheckBox.TabIndex = 8;
            this.usedCheckBox.Text = "Used";
            this.usedCheckBox.UseVisualStyleBackColor = true;
            // 
            // makeLabel
            // 
            this.makeLabel.AutoSize = true;
            this.makeLabel.Location = new System.Drawing.Point(15, 23);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(42, 17);
            this.makeLabel.TabIndex = 9;
            this.makeLabel.Text = "Make";
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(12, 60);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(46, 17);
            this.modelLabel.TabIndex = 10;
            this.modelLabel.Text = "Model";
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(30, 105);
            this.confirmButton.Margin = new System.Windows.Forms.Padding(4);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(100, 28);
            this.confirmButton.TabIndex = 13;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(172, 105);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 28);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // soldCheckBox
            // 
            this.soldCheckBox.AutoSize = true;
            this.soldCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.soldCheckBox.Location = new System.Drawing.Point(225, 48);
            this.soldCheckBox.Name = "soldCheckBox";
            this.soldCheckBox.Size = new System.Drawing.Size(58, 21);
            this.soldCheckBox.TabIndex = 16;
            this.soldCheckBox.Text = "Sold";
            this.soldCheckBox.UseVisualStyleBackColor = true;
            // 
            // makeDropDown
            // 
            this.makeDropDown.FormattingEnabled = true;
            this.makeDropDown.Location = new System.Drawing.Point(67, 23);
            this.makeDropDown.Name = "makeDropDown";
            this.makeDropDown.Size = new System.Drawing.Size(147, 24);
            this.makeDropDown.TabIndex = 17;
            // 
            // modelDropDown
            // 
            this.modelDropDown.FormattingEnabled = true;
            this.modelDropDown.Location = new System.Drawing.Point(67, 60);
            this.modelDropDown.Name = "modelDropDown";
            this.modelDropDown.Size = new System.Drawing.Size(147, 24);
            this.modelDropDown.TabIndex = 18;
            // 
            // AddEditVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 155);
            this.Controls.Add(this.modelDropDown);
            this.Controls.Add(this.makeDropDown);
            this.Controls.Add(this.soldCheckBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.makeLabel);
            this.Controls.Add(this.usedCheckBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddEditVehicleForm";
            this.Text = "AddVehicleForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox usedCheckBox;
        private System.Windows.Forms.Label makeLabel;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.CheckBox soldCheckBox;
        private System.Windows.Forms.ComboBox makeDropDown;
        private System.Windows.Forms.ComboBox modelDropDown;
    }
}