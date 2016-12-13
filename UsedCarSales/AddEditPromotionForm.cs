using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsedCarSales.DataAccessObjects;

namespace UsedCarSales
{
    public partial class AddEditPromotionForm : Form
    {
        public const int ADD_PROMOTION = 0;
        public const int EDIT_PROMOTION = 1;

        Promotion currentPromotion { get; set; }
        int mode;
        PromotionsForm promotionsForm;

        public AddEditPromotionForm(Promotion promotion, int mode, List<Make> makes, PromotionsForm promotionsForm)
        {
            InitializeComponent();

            this.currentPromotion = promotion;
            this.mode = mode;
            this.promotionsForm = promotionsForm;

            initializeForm(makes);
        }

        private void initializeForm(List<Make> makes)
        {
            makeDropDownBox.DisplayMember = "Id";
            makeDropDownBox.ValueMember = "Id";
            makeDropDownBox.DataSource = makes;
            if(currentPromotion != null)
            {
                if(currentPromotion.Make != null) { makeDropDownBox.SelectedItem = currentPromotion.Make; }
                discountAmountTextBox.Text = currentPromotion.discountAmount.ToString();
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (mode == ADD_PROMOTION)
            {
                Promotion promotion = new Promotion();
                promotion.Make = (Make)makeDropDownBox.SelectedItem;
                promotion.discountAmount = Int32.Parse(discountAmountTextBox.Text);

                if(promotion.Make != null && promotion.discountAmount != 0)
                {
                    PromotionDAO.AddPromotion(promotion);
                    promotionsForm.ReloadPromotions();
                    this.Close();
                } else
                {
                    //TODO: should show a different error message depending on what value is null
                    MessageBox.Show("Invalid input!", "Invalid Input", MessageBoxButtons.OK);
                }
            }
            else if (mode == EDIT_PROMOTION)
            {
                currentPromotion.Make = (Make)makeDropDownBox.SelectedItem;
                currentPromotion.discountAmount = Int32.Parse(discountAmountTextBox.Text);

                if (currentPromotion.Make != null && currentPromotion.discountAmount != 0)
                {
                    PromotionDAO.EditPromotion(currentPromotion);
                    promotionsForm.ReloadPromotions();
                    this.Close();
                }
                else
                {
                    //TODO: should show a different error message depending on what value is null
                    MessageBox.Show("Invalid input!", "Invalid Input", MessageBoxButtons.OK);
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
