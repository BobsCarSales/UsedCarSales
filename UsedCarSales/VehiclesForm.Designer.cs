namespace UsedCarSales
{
    partial class VehiclesForm
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
            this.addVehicleButton = new System.Windows.Forms.Button();
            this.makeLabel = new System.Windows.Forms.Label();
            this.Model = new System.Windows.Forms.Label();
            this.makeDropDownBox = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.usedCheckBox = new System.Windows.Forms.CheckBox();
            this.soldCheckBox = new System.Windows.Forms.CheckBox();
            this.searchVehicleButton = new System.Windows.Forms.Button();
            this.viewVehicleButton = new System.Windows.Forms.Button();
            this.editVehicleButton = new System.Windows.Forms.Button();
            this.removeVehicle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addVehicleButton
            // 
            this.addVehicleButton.Location = new System.Drawing.Point(427, 68);
            this.addVehicleButton.Name = "addVehicleButton";
            this.addVehicleButton.Size = new System.Drawing.Size(125, 50);
            this.addVehicleButton.TabIndex = 0;
            this.addVehicleButton.Text = "Add Vehicle";
            this.addVehicleButton.UseVisualStyleBackColor = true;
            // 
            // makeLabel
            // 
            this.makeLabel.AutoSize = true;
            this.makeLabel.Location = new System.Drawing.Point(17, 13);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(42, 17);
            this.makeLabel.TabIndex = 1;
            this.makeLabel.Text = "Make";
            // 
            // Model
            // 
            this.Model.AutoSize = true;
            this.Model.Location = new System.Drawing.Point(17, 45);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(46, 17);
            this.Model.TabIndex = 2;
            this.Model.Text = "Model";
            // 
            // makeDropDownBox
            // 
            this.makeDropDownBox.FormattingEnabled = true;
            this.makeDropDownBox.Location = new System.Drawing.Point(90, 12);
            this.makeDropDownBox.Name = "makeDropDownBox";
            this.makeDropDownBox.Size = new System.Drawing.Size(230, 24);
            this.makeDropDownBox.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(90, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(230, 24);
            this.comboBox1.TabIndex = 6;
            // 
            // usedCheckBox
            // 
            this.usedCheckBox.AutoSize = true;
            this.usedCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.usedCheckBox.Location = new System.Drawing.Point(338, 12);
            this.usedCheckBox.Name = "usedCheckBox";
            this.usedCheckBox.Size = new System.Drawing.Size(63, 21);
            this.usedCheckBox.TabIndex = 7;
            this.usedCheckBox.Text = "Used";
            this.usedCheckBox.UseVisualStyleBackColor = true;
            // 
            // soldCheckBox
            // 
            this.soldCheckBox.AutoSize = true;
            this.soldCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.soldCheckBox.Location = new System.Drawing.Point(343, 44);
            this.soldCheckBox.Name = "soldCheckBox";
            this.soldCheckBox.Size = new System.Drawing.Size(58, 21);
            this.soldCheckBox.TabIndex = 8;
            this.soldCheckBox.Text = "Sold";
            this.soldCheckBox.UseVisualStyleBackColor = true;
            // 
            // searchVehicleButton
            // 
            this.searchVehicleButton.Location = new System.Drawing.Point(427, 12);
            this.searchVehicleButton.Name = "searchVehicleButton";
            this.searchVehicleButton.Size = new System.Drawing.Size(125, 50);
            this.searchVehicleButton.TabIndex = 9;
            this.searchVehicleButton.Text = "Search Vehicles";
            this.searchVehicleButton.UseVisualStyleBackColor = true;
            // 
            // viewVehicleButton
            // 
            this.viewVehicleButton.Location = new System.Drawing.Point(427, 124);
            this.viewVehicleButton.Name = "viewVehicleButton";
            this.viewVehicleButton.Size = new System.Drawing.Size(125, 50);
            this.viewVehicleButton.TabIndex = 10;
            this.viewVehicleButton.Text = "View Vehicle";
            this.viewVehicleButton.UseVisualStyleBackColor = true;
            // 
            // editVehicleButton
            // 
            this.editVehicleButton.Location = new System.Drawing.Point(427, 180);
            this.editVehicleButton.Name = "editVehicleButton";
            this.editVehicleButton.Size = new System.Drawing.Size(125, 50);
            this.editVehicleButton.TabIndex = 11;
            this.editVehicleButton.Text = "Edit Vehicle";
            this.editVehicleButton.UseVisualStyleBackColor = true;
            // 
            // removeVehicle
            // 
            this.removeVehicle.Location = new System.Drawing.Point(427, 236);
            this.removeVehicle.Name = "removeVehicle";
            this.removeVehicle.Size = new System.Drawing.Size(125, 50);
            this.removeVehicle.TabIndex = 12;
            this.removeVehicle.Text = "Remove Vehicle";
            this.removeVehicle.UseVisualStyleBackColor = true;
            // 
            // VehiclesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 304);
            this.Controls.Add(this.removeVehicle);
            this.Controls.Add(this.editVehicleButton);
            this.Controls.Add(this.viewVehicleButton);
            this.Controls.Add(this.searchVehicleButton);
            this.Controls.Add(this.soldCheckBox);
            this.Controls.Add(this.usedCheckBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.makeDropDownBox);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.makeLabel);
            this.Controls.Add(this.addVehicleButton);
            this.Name = "VehiclesForm";
            this.Text = "VehiclesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addVehicleButton;
        private System.Windows.Forms.Label makeLabel;
        private System.Windows.Forms.Label Model;
        private System.Windows.Forms.ComboBox makeDropDownBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox usedCheckBox;
        private System.Windows.Forms.CheckBox soldCheckBox;
        private System.Windows.Forms.Button searchVehicleButton;
        private System.Windows.Forms.Button viewVehicleButton;
        private System.Windows.Forms.Button editVehicleButton;
        private System.Windows.Forms.Button removeVehicle;
    }
}