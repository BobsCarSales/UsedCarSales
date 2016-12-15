namespace UsedCarSales
{
    partial class PromotionsForm
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
            this.promotionsListBox = new System.Windows.Forms.ListBox();
            this.makeLabel = new System.Windows.Forms.Label();
            this.makeDropDownBox = new System.Windows.Forms.ComboBox();
            this.allPromotionsButton = new System.Windows.Forms.Button();
            this.searchPromotionsButton = new System.Windows.Forms.Button();
            this.addPromotionsButton = new System.Windows.Forms.Button();
            this.editPromotionButton = new System.Windows.Forms.Button();
            this.removePromotionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // promotionsListBox
            // 
            this.promotionsListBox.FormattingEnabled = true;
            this.promotionsListBox.ItemHeight = 16;
            this.promotionsListBox.Location = new System.Drawing.Point(12, 47);
            this.promotionsListBox.Name = "promotionsListBox";
            this.promotionsListBox.Size = new System.Drawing.Size(249, 196);
            this.promotionsListBox.TabIndex = 0;
            // 
            // makeLabel
            // 
            this.makeLabel.AutoSize = true;
            this.makeLabel.Location = new System.Drawing.Point(13, 13);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(42, 17);
            this.makeLabel.TabIndex = 1;
            this.makeLabel.Text = "Make";
            // 
            // makeDropDownBox
            // 
            this.makeDropDownBox.FormattingEnabled = true;
            this.makeDropDownBox.Location = new System.Drawing.Point(62, 13);
            this.makeDropDownBox.Name = "makeDropDownBox";
            this.makeDropDownBox.Size = new System.Drawing.Size(199, 24);
            this.makeDropDownBox.TabIndex = 2;
            // 
            // allPromotionsButton
            // 
            this.allPromotionsButton.Location = new System.Drawing.Point(280, 12);
            this.allPromotionsButton.Name = "allPromotionsButton";
            this.allPromotionsButton.Size = new System.Drawing.Size(145, 40);
            this.allPromotionsButton.TabIndex = 3;
            this.allPromotionsButton.Text = "All Promotions";
            this.allPromotionsButton.UseVisualStyleBackColor = true;
            this.allPromotionsButton.Click += new System.EventHandler(this.allPromotionsButton_Click);
            // 
            // searchPromotionsButton
            // 
            this.searchPromotionsButton.Location = new System.Drawing.Point(280, 58);
            this.searchPromotionsButton.Name = "searchPromotionsButton";
            this.searchPromotionsButton.Size = new System.Drawing.Size(145, 40);
            this.searchPromotionsButton.TabIndex = 4;
            this.searchPromotionsButton.Text = "Search Promotions";
            this.searchPromotionsButton.UseVisualStyleBackColor = true;
            this.searchPromotionsButton.Click += new System.EventHandler(this.searchPromotionsButton_Click);
            // 
            // addPromotionsButton
            // 
            this.addPromotionsButton.Location = new System.Drawing.Point(280, 104);
            this.addPromotionsButton.Name = "addPromotionsButton";
            this.addPromotionsButton.Size = new System.Drawing.Size(145, 40);
            this.addPromotionsButton.TabIndex = 5;
            this.addPromotionsButton.Text = "Add Promotion";
            this.addPromotionsButton.UseVisualStyleBackColor = true;
            this.addPromotionsButton.Click += new System.EventHandler(this.addPromotionsButton_Click);
            // 
            // editPromotionButton
            // 
            this.editPromotionButton.Location = new System.Drawing.Point(280, 150);
            this.editPromotionButton.Name = "editPromotionButton";
            this.editPromotionButton.Size = new System.Drawing.Size(145, 40);
            this.editPromotionButton.TabIndex = 6;
            this.editPromotionButton.Text = "Edit Promotion";
            this.editPromotionButton.UseVisualStyleBackColor = true;
            this.editPromotionButton.Click += new System.EventHandler(this.editPromotionButton_Click);
            // 
            // removePromotionButton
            // 
            this.removePromotionButton.Location = new System.Drawing.Point(280, 196);
            this.removePromotionButton.Name = "removePromotionButton";
            this.removePromotionButton.Size = new System.Drawing.Size(145, 40);
            this.removePromotionButton.TabIndex = 7;
            this.removePromotionButton.Text = "Remove Promotion";
            this.removePromotionButton.UseVisualStyleBackColor = true;
            this.removePromotionButton.Click += new System.EventHandler(this.removePromotionButton_Click);
            // 
            // PromotionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 255);
            this.Controls.Add(this.removePromotionButton);
            this.Controls.Add(this.editPromotionButton);
            this.Controls.Add(this.addPromotionsButton);
            this.Controls.Add(this.searchPromotionsButton);
            this.Controls.Add(this.allPromotionsButton);
            this.Controls.Add(this.makeDropDownBox);
            this.Controls.Add(this.makeLabel);
            this.Controls.Add(this.promotionsListBox);
            this.Name = "PromotionsForm";
            this.Text = "PromotionsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox promotionsListBox;
        private System.Windows.Forms.Label makeLabel;
        private System.Windows.Forms.ComboBox makeDropDownBox;
        private System.Windows.Forms.Button allPromotionsButton;
        private System.Windows.Forms.Button searchPromotionsButton;
        private System.Windows.Forms.Button addPromotionsButton;
        private System.Windows.Forms.Button editPromotionButton;
        private System.Windows.Forms.Button removePromotionButton;
    }
}