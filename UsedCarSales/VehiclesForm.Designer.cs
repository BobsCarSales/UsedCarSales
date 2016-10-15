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
            this.modelDropDownBox = new System.Windows.Forms.ComboBox();
            this.usedCheckBox = new System.Windows.Forms.CheckBox();
            this.soldCheckBox = new System.Windows.Forms.CheckBox();
            this.searchVehicleButton = new System.Windows.Forms.Button();
            this.viewVehicleButton = new System.Windows.Forms.Button();
            this.editVehicleButton = new System.Windows.Forms.Button();
            this.removeVehicle = new System.Windows.Forms.Button();
            this.vehiclesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // addVehicleButton
            // 
            this.addVehicleButton.Location = new System.Drawing.Point(320, 55);
            this.addVehicleButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addVehicleButton.Name = "addVehicleButton";
            this.addVehicleButton.Size = new System.Drawing.Size(94, 41);
            this.addVehicleButton.TabIndex = 0;
            this.addVehicleButton.Text = "Add Vehicle";
            this.addVehicleButton.UseVisualStyleBackColor = true;
            this.addVehicleButton.Click += new System.EventHandler(this.addVehicleButton_Click);
            // 
            // makeLabel
            // 
            this.makeLabel.AutoSize = true;
            this.makeLabel.Location = new System.Drawing.Point(13, 11);
            this.makeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(34, 13);
            this.makeLabel.TabIndex = 1;
            this.makeLabel.Text = "Make";
            // 
            // Model
            // 
            this.Model.AutoSize = true;
            this.Model.Location = new System.Drawing.Point(13, 37);
            this.Model.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(36, 13);
            this.Model.TabIndex = 2;
            this.Model.Text = "Model";
            // 
            // makeDropDownBox
            // 
            this.makeDropDownBox.DisplayMember = "(none)";
            this.makeDropDownBox.FormattingEnabled = true;
            this.makeDropDownBox.Location = new System.Drawing.Point(68, 10);
            this.makeDropDownBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.makeDropDownBox.Name = "makeDropDownBox";
            this.makeDropDownBox.Size = new System.Drawing.Size(174, 21);
            this.makeDropDownBox.TabIndex = 5;
            // 
            // modelDropDownBox
            // 
            this.modelDropDownBox.FormattingEnabled = true;
            this.modelDropDownBox.Location = new System.Drawing.Point(68, 34);
            this.modelDropDownBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.modelDropDownBox.Name = "modelDropDownBox";
            this.modelDropDownBox.Size = new System.Drawing.Size(174, 21);
            this.modelDropDownBox.TabIndex = 6;
            // 
            // usedCheckBox
            // 
            this.usedCheckBox.AutoSize = true;
            this.usedCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.usedCheckBox.Location = new System.Drawing.Point(254, 10);
            this.usedCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usedCheckBox.Name = "usedCheckBox";
            this.usedCheckBox.Size = new System.Drawing.Size(51, 17);
            this.usedCheckBox.TabIndex = 7;
            this.usedCheckBox.Text = "Used";
            this.usedCheckBox.UseVisualStyleBackColor = true;
            // 
            // soldCheckBox
            // 
            this.soldCheckBox.AutoSize = true;
            this.soldCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.soldCheckBox.Location = new System.Drawing.Point(257, 36);
            this.soldCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.soldCheckBox.Name = "soldCheckBox";
            this.soldCheckBox.Size = new System.Drawing.Size(47, 17);
            this.soldCheckBox.TabIndex = 8;
            this.soldCheckBox.Text = "Sold";
            this.soldCheckBox.UseVisualStyleBackColor = true;
            // 
            // searchVehicleButton
            // 
            this.searchVehicleButton.Location = new System.Drawing.Point(320, 10);
            this.searchVehicleButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchVehicleButton.Name = "searchVehicleButton";
            this.searchVehicleButton.Size = new System.Drawing.Size(94, 41);
            this.searchVehicleButton.TabIndex = 9;
            this.searchVehicleButton.Text = "Search Vehicles";
            this.searchVehicleButton.UseVisualStyleBackColor = true;
            this.searchVehicleButton.Click += new System.EventHandler(this.searchVehicleButton_Click);
            // 
            // viewVehicleButton
            // 
            this.viewVehicleButton.Location = new System.Drawing.Point(320, 101);
            this.viewVehicleButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.viewVehicleButton.Name = "viewVehicleButton";
            this.viewVehicleButton.Size = new System.Drawing.Size(94, 41);
            this.viewVehicleButton.TabIndex = 10;
            this.viewVehicleButton.Text = "View Vehicle";
            this.viewVehicleButton.UseVisualStyleBackColor = true;
            // 
            // editVehicleButton
            // 
            this.editVehicleButton.Location = new System.Drawing.Point(320, 146);
            this.editVehicleButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.editVehicleButton.Name = "editVehicleButton";
            this.editVehicleButton.Size = new System.Drawing.Size(94, 41);
            this.editVehicleButton.TabIndex = 11;
            this.editVehicleButton.Text = "Edit Vehicle";
            this.editVehicleButton.UseVisualStyleBackColor = true;
            // 
            // removeVehicle
            // 
            this.removeVehicle.Location = new System.Drawing.Point(320, 192);
            this.removeVehicle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.removeVehicle.Name = "removeVehicle";
            this.removeVehicle.Size = new System.Drawing.Size(94, 41);
            this.removeVehicle.TabIndex = 12;
            this.removeVehicle.Text = "Remove Vehicle";
            this.removeVehicle.UseVisualStyleBackColor = true;
            // 
            // vehiclesListBox
            // 
            this.vehiclesListBox.FormattingEnabled = true;
            this.vehiclesListBox.Location = new System.Drawing.Point(15, 73);
            this.vehiclesListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.vehiclesListBox.Name = "vehiclesListBox";
            this.vehiclesListBox.Size = new System.Drawing.Size(287, 160);
            this.vehiclesListBox.TabIndex = 13;
            // 
            // VehiclesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 247);
            this.Controls.Add(this.vehiclesListBox);
            this.Controls.Add(this.removeVehicle);
            this.Controls.Add(this.editVehicleButton);
            this.Controls.Add(this.viewVehicleButton);
            this.Controls.Add(this.searchVehicleButton);
            this.Controls.Add(this.soldCheckBox);
            this.Controls.Add(this.usedCheckBox);
            this.Controls.Add(this.modelDropDownBox);
            this.Controls.Add(this.makeDropDownBox);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.makeLabel);
            this.Controls.Add(this.addVehicleButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.ComboBox modelDropDownBox;
        private System.Windows.Forms.CheckBox usedCheckBox;
        private System.Windows.Forms.CheckBox soldCheckBox;
        private System.Windows.Forms.Button searchVehicleButton;
        private System.Windows.Forms.Button viewVehicleButton;
        private System.Windows.Forms.Button editVehicleButton;
        private System.Windows.Forms.Button removeVehicle;
        private System.Windows.Forms.ListBox vehiclesListBox;
    }
}