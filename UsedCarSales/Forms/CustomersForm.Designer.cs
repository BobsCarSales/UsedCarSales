namespace UsedCarSales
{
    partial class CustomersForm
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
            this.customersListBox = new System.Windows.Forms.ListBox();
            this.allCustomersButton = new System.Windows.Forms.Button();
            this.searchCustomersButton = new System.Windows.Forms.Button();
            this.viewCustomerButton = new System.Windows.Forms.Button();
            this.editCustomerButton = new System.Windows.Forms.Button();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // customersListBox
            // 
            this.customersListBox.FormattingEnabled = true;
            this.customersListBox.ItemHeight = 16;
            this.customersListBox.Location = new System.Drawing.Point(12, 86);
            this.customersListBox.Name = "customersListBox";
            this.customersListBox.Size = new System.Drawing.Size(263, 228);
            this.customersListBox.TabIndex = 0;
            // 
            // allCustomersButton
            // 
            this.allCustomersButton.Location = new System.Drawing.Point(288, 55);
            this.allCustomersButton.Name = "allCustomersButton";
            this.allCustomersButton.Size = new System.Drawing.Size(170, 40);
            this.allCustomersButton.TabIndex = 1;
            this.allCustomersButton.Text = "All Customers";
            this.allCustomersButton.UseVisualStyleBackColor = true;
            this.allCustomersButton.Click += new System.EventHandler(this.allCustomersButton_Click);
            // 
            // searchCustomersButton
            // 
            this.searchCustomersButton.Location = new System.Drawing.Point(288, 12);
            this.searchCustomersButton.Name = "searchCustomersButton";
            this.searchCustomersButton.Size = new System.Drawing.Size(170, 37);
            this.searchCustomersButton.TabIndex = 2;
            this.searchCustomersButton.Text = "Search Customers";
            this.searchCustomersButton.UseVisualStyleBackColor = true;
            this.searchCustomersButton.Click += new System.EventHandler(this.searchCustomersButton_Click);
            // 
            // viewCustomerButton
            // 
            this.viewCustomerButton.Location = new System.Drawing.Point(288, 102);
            this.viewCustomerButton.Name = "viewCustomerButton";
            this.viewCustomerButton.Size = new System.Drawing.Size(170, 39);
            this.viewCustomerButton.TabIndex = 3;
            this.viewCustomerButton.Text = "View Customer";
            this.viewCustomerButton.UseVisualStyleBackColor = true;
            this.viewCustomerButton.Click += new System.EventHandler(this.viewCustomerButton_Click);
            // 
            // editCustomerButton
            // 
            this.editCustomerButton.Location = new System.Drawing.Point(288, 147);
            this.editCustomerButton.Name = "editCustomerButton";
            this.editCustomerButton.Size = new System.Drawing.Size(170, 40);
            this.editCustomerButton.TabIndex = 4;
            this.editCustomerButton.Text = "Edit Customer";
            this.editCustomerButton.UseVisualStyleBackColor = true;
            this.editCustomerButton.Click += new System.EventHandler(this.editCustomerButton_Click);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(13, 12);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(84, 17);
            this.firstNameLabel.TabIndex = 5;
            this.firstNameLabel.Text = "First Name: ";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(12, 45);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(84, 17);
            this.lastNameLabel.TabIndex = 6;
            this.lastNameLabel.Text = "Last Name: ";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(104, 13);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(171, 22);
            this.firstNameTextBox.TabIndex = 7;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(103, 45);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(172, 22);
            this.lastNameTextBox.TabIndex = 8;
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 330);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.editCustomerButton);
            this.Controls.Add(this.viewCustomerButton);
            this.Controls.Add(this.searchCustomersButton);
            this.Controls.Add(this.allCustomersButton);
            this.Controls.Add(this.customersListBox);
            this.Name = "CustomersForm";
            this.Text = "CustomersForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox customersListBox;
        private System.Windows.Forms.Button allCustomersButton;
        private System.Windows.Forms.Button searchCustomersButton;
        private System.Windows.Forms.Button viewCustomerButton;
        private System.Windows.Forms.Button editCustomerButton;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
    }
}