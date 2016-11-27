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
    public partial class TransactionForm : Form
    {
        Vehicle currentVehicle;
        int defaultLabelPosition;

        public TransactionForm(Vehicle vehicle)
        {
            InitializeComponent();

            this.currentVehicle = vehicle;
            initializePromotions();

            //when promotion changes, final price should be re-evaluated
            this.promotionComboBox.SelectedValueChanged += new System.EventHandler(applyPromotion);

            //save the default x position and num of digits of the price labels. we'll be moving them back and forth
            defaultLabelPosition = fullPriceValueLabel.Location.X;

            fullPriceValueLabel.Text = "$" + currentVehicle.price.ToString();
            applyPromotion();
        }

        //TODO: A PROMOTION SHOULD NOT BE SELECTED WHEN THE FORM LOADS
        private void initializePromotions()
        {
            //TODO: ONLY LOAD PROMOTIONS IF THEIR MAKE MATCHES THE CURRENT VEHICLE MAKE
            List<Promotion> allPromotions = PromotionDAO.GetPromotionsByMake(currentVehicle.Model.Make);
            promotionComboBox.DataSource = allPromotions;
        }

        private void applyPromotion(object sender = null, EventArgs e = null)
        {
            Promotion selectedPromotion = (Promotion)promotionComboBox.SelectedItem;
            if(selectedPromotion != null)
            {
                Decimal discountPercentage = (Decimal) selectedPromotion.discountAmount / 100;
                Decimal finalPrice = currentVehicle.price - (currentVehicle.price * discountPercentage);
                
                adjustedPriceValueLabel.Text = "$" + Decimal.Round(finalPrice, 2);

            } else
            {
                adjustedPriceValueLabel.Text = "$" + currentVehicle.price.ToString();
            }

            updatePriceLabelLocations();
        }

        private void updatePriceLabelLocations()
        {
            fullPriceValueLabel.Location = new Point(defaultLabelPosition - (3 * fullPriceValueLabel.Text.ToString().Length - 1), //subtracting 1 for the decimal place
                                                    fullPriceValueLabel.Location.Y);
            adjustedPriceValueLabel.Location = new Point(defaultLabelPosition - (3 * adjustedPriceValueLabel.Text.ToString().Length - 1), //subtracting 1 for the decimal place
                                                    adjustedPriceValueLabel.Location.Y);
        }

        //TODO: wish this wasn't here
        private void finalPriceLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
