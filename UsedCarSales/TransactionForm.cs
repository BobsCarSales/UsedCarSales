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
        VehiclesForm parentForm;
        Vehicle currentVehicle;
        int defaultLabelPosition;

        public TransactionForm(Vehicle vehicle, VehiclesForm parentForm)
        {
            InitializeComponent();

            this.parentForm = parentForm;
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
            List<Promotion> allPromotions = new List<Promotion>();
            allPromotions.Add(new Promotion());
            allPromotions.AddRange(PromotionDAO.GetPromotionsByMake(currentVehicle.Model.Make));
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void makeSaleButton_Click(object sender, EventArgs e)
        {
            if (firstNameTextBox.Text.Equals("")
                || lastNameTextBox.Text.Equals("")
                || addressTextBox.Text.Equals("")
                || stateTextBox.Text.Equals("")
                || zipCodeTextBox.Text.Equals("")
                || phoneTextBox.Text.Equals(""))
            {
                //show error message
                errorOnForm();
            } else { 
                Customer customer = new Customer();
                customer.firstName = firstNameTextBox.Text;
                customer.lastName = lastNameTextBox.Text;
                customer.streetAddress = addressTextBox.Text;
                customer.state = stateTextBox.Text;
                customer.zipcode = zipCodeTextBox.Text;
                customer.phoneNumber = phoneTextBox.Text;

                Transaction transaction = new Transaction();
                transaction.Customer = customer;
                transaction.Vehicle = currentVehicle;
                //TODO: need code for setting vehicle to sold and any other work that goes along with that
                transaction.date = DateTime.Now;

                //get rid of the $ character from the beginning of the string
                String totalCostString = adjustedPriceValueLabel.Text;
                totalCostString = totalCostString.Substring(1);

                //TODO: catch errors from this
                Decimal totalCost = Decimal.Parse(totalCostString);
                transaction.totalCost = Decimal.Round(totalCost, 2);

                confirmSale(transaction);
            }
        }

        private void confirmSale(Transaction transaction)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to make this sale?\n" + currentVehicle + "\nFinal Price: $" + transaction.totalCost, "Confirm Sale", MessageBoxButtons.YesNo);

            if(confirmResult == DialogResult.Yes)
            {
                currentVehicle.sold = true;
                TransactionDAO.SaveTransaction(transaction);

                //update the list of vehicles in the parent form so that it shows that this car has been sold
                parentForm.ReloadVehicles();

                Console.WriteLine("Transaction Completed");
                this.Close();
            }
        }

        private void errorOnForm()
        {
            String errorMessage = "";
            if (firstNameTextBox.Text.Equals(""))
            {
                errorMessage += "First name field is empty\n";
            }
            if (lastNameTextBox.Text.Equals(""))
            {
                errorMessage += "Last name field is empty\n";
            }
            if (addressTextBox.Text.Equals(""))
            {
                errorMessage += "Address field is empty\n";
            }
            if (stateTextBox.Text.Equals(""))
            {
                errorMessage += "State field is empty\n";
            }
            if (zipCodeTextBox.Text.Equals(""))
            {
                errorMessage += "Zipcode field is empty\n";
            }
            if (phoneTextBox.Text.Equals(""))
            {
                errorMessage += "Phone field is empty\n";
            }

            var confirmResult = MessageBox.Show(errorMessage, "Error Validating Customer Information", MessageBoxButtons.OK);
        }
    }
}
