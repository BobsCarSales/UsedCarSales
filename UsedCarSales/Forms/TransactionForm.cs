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

        //load all promotions by the make of the current vehicle
        private void initializePromotions()
        {
            List<Promotion> allPromotions = new List<Promotion>();
            allPromotions.Add(new Promotion());
            allPromotions.AddRange(PromotionDAO.GetPromotionsByMake(currentVehicle.Model.Make));
            promotionComboBox.DataSource = allPromotions;
        }
        
        //Apply a promotion to the overall price of the current vehicle
        private void applyPromotion(object sender = null, EventArgs e = null)
        {
            //if we have a selected promotion, calculate the price. Otherwise change the label to the total price of the vehicle
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

        //update the location of the price labels depending on how long the price is
        private void updatePriceLabelLocations()
        {
            fullPriceValueLabel.Location = new Point(defaultLabelPosition - (3 * fullPriceValueLabel.Text.ToString().Length - 1), //subtracting 1 for the decimal place
                                                    fullPriceValueLabel.Location.Y);
            adjustedPriceValueLabel.Location = new Point(defaultLabelPosition - (3 * adjustedPriceValueLabel.Text.ToString().Length - 1), //subtracting 1 for the decimal place
                                                    adjustedPriceValueLabel.Location.Y);
        }

        //close the form
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Create the customer and transaction objects to be added to the database
        private void makeSaleButton_Click(object sender, EventArgs e)
        {
            if (!errorOnForm())
            { 
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

        //add the transaction to the database, which will cascade save the vehicle and customer associated with it
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

        //if an error occurs on the form, show the error to the user and return true so that the program will not continue saving the transaction
        private bool errorOnForm()
        {
            bool error = false;

            String errorMessage = "";
            if (firstNameTextBox.Text.Equals(""))
            {
                errorMessage += "First name field is empty\n";
                error = true;
            }
            if (lastNameTextBox.Text.Equals(""))
            {
                errorMessage += "Last name field is empty\n";
                error = true;
            }
            if (addressTextBox.Text.Equals(""))
            {
                errorMessage += "Address field is empty\n";
                error = true;
            }
            if (stateTextBox.Text.Equals(""))
            {
                errorMessage += "State field is empty\n";
                error = true;
            }
            if (zipCodeTextBox.Text.Equals(""))
            {
                errorMessage += "Zipcode field is empty\n";
                error = true;
            }
            if (phoneTextBox.Text.Equals(""))
            {
                errorMessage += "Phone field is empty\n";
                error = true;
            }

            if(zipCodeTextBox.Text.ToString().Length != 5)
            {
                errorMessage += "Zip code is the wrong length\n";
                error = true;
            }

            try
            {
                decimal zip = decimal.Parse(zipCodeTextBox.Text.ToString());
            }
            catch
            {
                errorMessage += "Zip code contains invalid characters\n";
                error = true;
            }

            try
            {
                decimal phone = decimal.Parse(phoneTextBox.Text.ToString());
            }
            catch
            {
                errorMessage += "Phone number contains invalid characters\n";
                error = true;
            }

            if(errorMessage.Length > 0)
            {
                MessageBox.Show(errorMessage, "Error Validating Customer Information", MessageBoxButtons.OK);
            }

            return error;
        }

        //TODO: wish this wasn't here
        private void finalPriceLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
