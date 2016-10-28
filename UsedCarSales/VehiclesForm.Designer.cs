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
            this.removeVehicleButton = new System.Windows.Forms.Button();
            this.vehiclesListBox = new System.Windows.Forms.ListBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.allVehiclesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addVehicleButton
            // 
            this.addVehicleButton.Location = new System.Drawing.Point(428, 124);
            this.addVehicleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addVehicleButton.Name = "addVehicleButton";
            this.addVehicleButton.Size = new System.Drawing.Size(125, 50);
            this.addVehicleButton.TabIndex = 0;
            this.addVehicleButton.Text = "Add Vehicle";
            this.addVehicleButton.UseVisualStyleBackColor = true;
            this.addVehicleButton.Click += new System.EventHandler(this.addVehicleButton_Click);
            // 
            // makeLabel
            // 
            this.makeLabel.AutoSize = true;
            this.makeLabel.Location = new System.Drawing.Point(17, 14);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(42, 17);
            this.makeLabel.TabIndex = 1;
            this.makeLabel.Text = "Make";
            // 
            // Model
            // 
            this.Model.AutoSize = true;
            this.Model.Location = new System.Drawing.Point(17, 46);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(46, 17);
            this.Model.TabIndex = 2;
            this.Model.Text = "Model";
            // 
            // makeDropDownBox
            // 
            this.makeDropDownBox.DisplayMember = "(none)";
            this.makeDropDownBox.FormattingEnabled = true;
            this.makeDropDownBox.Location = new System.Drawing.Point(91, 12);
            this.makeDropDownBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.makeDropDownBox.Name = "makeDropDownBox";
            this.makeDropDownBox.Size = new System.Drawing.Size(231, 24);
            this.makeDropDownBox.TabIndex = 5;
            // 
            // modelDropDownBox
            // 
            this.modelDropDownBox.FormattingEnabled = true;
            this.modelDropDownBox.Location = new System.Drawing.Point(91, 42);
            this.modelDropDownBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modelDropDownBox.Name = "modelDropDownBox";
            this.modelDropDownBox.Size = new System.Drawing.Size(231, 24);
            this.modelDropDownBox.TabIndex = 6;
            // 
            // usedCheckBox
            // 
            this.usedCheckBox.AutoSize = true;
            this.usedCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.usedCheckBox.Location = new System.Drawing.Point(339, 12);
            this.usedCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.soldCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.soldCheckBox.Name = "soldCheckBox";
            this.soldCheckBox.Size = new System.Drawing.Size(58, 21);
            this.soldCheckBox.TabIndex = 8;
            this.soldCheckBox.Text = "Sold";
            this.soldCheckBox.UseVisualStyleBackColor = true;
            // 
            // searchVehicleButton
            // 
            this.searchVehicleButton.Location = new System.Drawing.Point(428, 70);
            this.searchVehicleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchVehicleButton.Name = "searchVehicleButton";
            this.searchVehicleButton.Size = new System.Drawing.Size(125, 50);
            this.searchVehicleButton.TabIndex = 9;
            this.searchVehicleButton.Text = "Search Vehicles";
            this.searchVehicleButton.UseVisualStyleBackColor = true;
            this.searchVehicleButton.Click += new System.EventHandler(this.searchVehicleButton_Click);
            // 
            // viewVehicleButton
            // 
            this.viewVehicleButton.Location = new System.Drawing.Point(428, 178);
            this.viewVehicleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewVehicleButton.Name = "viewVehicleButton";
            this.viewVehicleButton.Size = new System.Drawing.Size(125, 50);
            this.viewVehicleButton.TabIndex = 10;
            this.viewVehicleButton.Text = "View Vehicle";
            this.viewVehicleButton.UseVisualStyleBackColor = true;
            this.viewVehicleButton.Click += new System.EventHandler(this.viewVehicleButton_Click);
            // 
            // editVehicleButton
            // 
            this.editVehicleButton.Location = new System.Drawing.Point(428, 232);
            this.editVehicleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editVehicleButton.Name = "editVehicleButton";
            this.editVehicleButton.Size = new System.Drawing.Size(125, 50);
            this.editVehicleButton.TabIndex = 11;
            this.editVehicleButton.Text = "Edit Vehicle";
            this.editVehicleButton.UseVisualStyleBackColor = true;
            this.editVehicleButton.Click += new System.EventHandler(this.editVehicleButton_Click);
            // 
            // removeVehicleButton
            // 
            this.removeVehicleButton.Location = new System.Drawing.Point(428, 286);
            this.removeVehicleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeVehicleButton.Name = "removeVehicleButton";
            this.removeVehicleButton.Size = new System.Drawing.Size(125, 50);
            this.removeVehicleButton.TabIndex = 12;
            this.removeVehicleButton.Text = "Remove Vehicle";
            this.removeVehicleButton.UseVisualStyleBackColor = true;
            this.removeVehicleButton.Click += new System.EventHandler(this.removeVehicle_Click);
            // 
            // vehiclesListBox
            // 
            this.vehiclesListBox.FormattingEnabled = true;
            this.vehiclesListBox.ItemHeight = 16;
            this.vehiclesListBox.Location = new System.Drawing.Point(12, 108);
            this.vehiclesListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vehiclesListBox.Name = "vehiclesListBox";
            this.vehiclesListBox.Size = new System.Drawing.Size(381, 228);
            this.vehiclesListBox.TabIndex = 13;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(17, 76);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(38, 17);
            this.yearLabel.TabIndex = 14;
            this.yearLabel.Text = "Year";
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(91, 76);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(78, 22);
            this.yearTextBox.TabIndex = 15;
            // 
            // allVehiclesButton
            // 
            this.allVehiclesButton.Location = new System.Drawing.Point(428, 14);
            this.allVehiclesButton.Name = "allVehiclesButton";
            this.allVehiclesButton.Size = new System.Drawing.Size(125, 50);
            this.allVehiclesButton.TabIndex = 16;
            this.allVehiclesButton.Text = "All Vehicles";
            this.allVehiclesButton.UseVisualStyleBackColor = true;
            this.allVehiclesButton.Click += new System.EventHandler(this.allVehiclesButton_Click);
            // 
            // VehiclesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 347);
            this.Controls.Add(this.allVehiclesButton);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.vehiclesListBox);
            this.Controls.Add(this.removeVehicleButton);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button removeVehicleButton;
        private System.Windows.Forms.ListBox vehiclesListBox;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Button allVehiclesButton;
    }
}