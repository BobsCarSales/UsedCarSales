﻿namespace UsedCarSales
{
    partial class HomeForm
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
            this.promotionsButton = new System.Windows.Forms.Button();
            this.vehiclesButton = new System.Windows.Forms.Button();
            this.customersButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // promotionsButton
            // 
            this.promotionsButton.Location = new System.Drawing.Point(35, 99);
            this.promotionsButton.Name = "promotionsButton";
            this.promotionsButton.Size = new System.Drawing.Size(125, 40);
            this.promotionsButton.TabIndex = 1;
            this.promotionsButton.Text = "Promotions";
            this.promotionsButton.UseVisualStyleBackColor = true;
            this.promotionsButton.Click += new System.EventHandler(this.promotionsButton_Click);
            // 
            // vehiclesButton
            // 
            this.vehiclesButton.Location = new System.Drawing.Point(35, 36);
            this.vehiclesButton.Name = "vehiclesButton";
            this.vehiclesButton.Size = new System.Drawing.Size(125, 40);
            this.vehiclesButton.TabIndex = 3;
            this.vehiclesButton.Text = "Vehicles";
            this.vehiclesButton.UseVisualStyleBackColor = true;
            this.vehiclesButton.Click += new System.EventHandler(this.vehiclesButton_Click);
            // 
            // customersButton
            // 
            this.customersButton.Location = new System.Drawing.Point(35, 159);
            this.customersButton.Name = "customersButton";
            this.customersButton.Size = new System.Drawing.Size(125, 41);
            this.customersButton.TabIndex = 4;
            this.customersButton.Text = "Customers";
            this.customersButton.UseVisualStyleBackColor = true;
            this.customersButton.Click += new System.EventHandler(this.customersButton_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 232);
            this.Controls.Add(this.customersButton);
            this.Controls.Add(this.vehiclesButton);
            this.Controls.Add(this.promotionsButton);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "HomeForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button promotionsButton;
        private System.Windows.Forms.Button vehiclesButton;
        private System.Windows.Forms.Button customersButton;
    }
}

