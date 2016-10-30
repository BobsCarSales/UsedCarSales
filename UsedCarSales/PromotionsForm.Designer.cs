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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            this.promotionsListBox.Size = new System.Drawing.Size(249, 212);
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(62, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(199, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // allPromotionsButton
            // 
            this.allPromotionsButton.Location = new System.Drawing.Point(280, 13);
            this.allPromotionsButton.Name = "allPromotionsButton";
            this.allPromotionsButton.Size = new System.Drawing.Size(145, 42);
            this.allPromotionsButton.TabIndex = 3;
            this.allPromotionsButton.Text = "All Promotions";
            this.allPromotionsButton.UseVisualStyleBackColor = true;
            // 
            // searchPromotionsButton
            // 
            this.searchPromotionsButton.Location = new System.Drawing.Point(280, 62);
            this.searchPromotionsButton.Name = "searchPromotionsButton";
            this.searchPromotionsButton.Size = new System.Drawing.Size(145, 44);
            this.searchPromotionsButton.TabIndex = 4;
            this.searchPromotionsButton.Text = "Search Promotions";
            this.searchPromotionsButton.UseVisualStyleBackColor = true;
            // 
            // addPromotionsButton
            // 
            this.addPromotionsButton.Location = new System.Drawing.Point(280, 113);
            this.addPromotionsButton.Name = "addPromotionsButton";
            this.addPromotionsButton.Size = new System.Drawing.Size(145, 46);
            this.addPromotionsButton.TabIndex = 5;
            this.addPromotionsButton.Text = "Add Promotion";
            this.addPromotionsButton.UseVisualStyleBackColor = true;
            // 
            // editPromotionButton
            // 
            this.editPromotionButton.Location = new System.Drawing.Point(280, 166);
            this.editPromotionButton.Name = "editPromotionButton";
            this.editPromotionButton.Size = new System.Drawing.Size(145, 44);
            this.editPromotionButton.TabIndex = 6;
            this.editPromotionButton.Text = "Edit Promotion";
            this.editPromotionButton.UseVisualStyleBackColor = true;
            // 
            // removePromotionButton
            // 
            this.removePromotionButton.Location = new System.Drawing.Point(280, 217);
            this.removePromotionButton.Name = "removePromotionButton";
            this.removePromotionButton.Size = new System.Drawing.Size(145, 48);
            this.removePromotionButton.TabIndex = 7;
            this.removePromotionButton.Text = "Remove Promotion";
            this.removePromotionButton.UseVisualStyleBackColor = true;
            // 
            // PromotionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 274);
            this.Controls.Add(this.removePromotionButton);
            this.Controls.Add(this.editPromotionButton);
            this.Controls.Add(this.addPromotionsButton);
            this.Controls.Add(this.searchPromotionsButton);
            this.Controls.Add(this.allPromotionsButton);
            this.Controls.Add(this.comboBox1);
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button allPromotionsButton;
        private System.Windows.Forms.Button searchPromotionsButton;
        private System.Windows.Forms.Button addPromotionsButton;
        private System.Windows.Forms.Button editPromotionButton;
        private System.Windows.Forms.Button removePromotionButton;
    }
}