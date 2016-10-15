namespace UsedCarSales
{
    partial class AddVehicleForm
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
            this.makeTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usedCheckBox
            // 
            this.usedCheckBox.AutoSize = true;
            this.usedCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.usedCheckBox.Location = new System.Drawing.Point(181, 19);
            this.usedCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.usedCheckBox.Name = "usedCheckBox";
            this.usedCheckBox.Size = new System.Drawing.Size(51, 17);
            this.usedCheckBox.TabIndex = 8;
            this.usedCheckBox.Text = "Used";
            this.usedCheckBox.UseVisualStyleBackColor = true;
            // 
            // makeLabel
            // 
            this.makeLabel.AutoSize = true;
            this.makeLabel.Location = new System.Drawing.Point(11, 19);
            this.makeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(34, 13);
            this.makeLabel.TabIndex = 9;
            this.makeLabel.Text = "Make";
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(9, 49);
            this.modelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(36, 13);
            this.modelLabel.TabIndex = 10;
            this.modelLabel.Text = "Model";
            // 
            // makeTextBox
            // 
            this.makeTextBox.Location = new System.Drawing.Point(50, 19);
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.Size = new System.Drawing.Size(100, 20);
            this.makeTextBox.TabIndex = 11;
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(50, 49);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(100, 20);
            this.modelTextBox.TabIndex = 12;
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(50, 122);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 13;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(157, 122);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // AddVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 179);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(this.makeTextBox);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.makeLabel);
            this.Controls.Add(this.usedCheckBox);
            this.Name = "AddVehicleForm";
            this.Text = "AddVehicleForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox usedCheckBox;
        private System.Windows.Forms.Label makeLabel;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.TextBox makeTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button confirmButton;
    }
}