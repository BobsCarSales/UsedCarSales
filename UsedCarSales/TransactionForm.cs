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

        public TransactionForm(Vehicle vehicle)
        {
            InitializeComponent();
            initializePromotions();

            this.currentVehicle = vehicle;

            //when promotion changes, final price should be re-evaluated
            this.promotionComboBox.SelectedValueChanged += new System.EventHandler(applyPromotion);
        }

        //will only be called once when the VehiclesFrom loads
        private void initializePromotions()
        {
            List<Promotion> allPromotions = PromotionDAO.GetAllPromotions();

            //TODO: this will need to be changed
            promotionComboBox.DataSource = allPromotions;
        }

        private void applyPromotion(object sender = null, EventArgs e = null)
        {
            Promotion selectedPromotion = (Promotion)promotionComboBox.SelectedItem;
            if(selectedPromotion != null)
            {

            }
        }

        //TODO: wish this wasn't here
        private void finalPriceLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
