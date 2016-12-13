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
    public partial class EditCustomerForm : Form
    {
        CustomersForm customersForm;
        Customer customer;

        public EditCustomerForm(Customer customer, CustomersForm customersForm)
        {
            InitializeComponent();

            this.customersForm = customersForm;
            this.customer = customer;

            if (customer.firstName != null) firstNameTextBox.Text = customer.firstName;
            if (customer.lastName != null) lastNameTextBox.Text = customer.lastName;
            if (customer.streetAddress != null) addressTextBox.Text = customer.streetAddress;
            if (customer.state != null) stateTextBox.Text = customer.state;
            if (customer.zipcode != null) zipcodeTextBox.Text = customer.zipcode;
            if (customer.phoneNumber != null) phoneNumTextBox.Text = customer.phoneNumber;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            customer.firstName = firstNameTextBox.Text.ToString();
            customer.lastName = lastNameTextBox.Text.ToString();
            customer.streetAddress = addressTextBox.Text.ToString();
            customer.state = stateTextBox.Text.ToString();
            customer.zipcode = zipcodeTextBox.Text.ToString();
            customer.phoneNumber = phoneNumTextBox.Text.ToString();

            if(customer.firstName != null
                   && customer.lastName != null
                   && customer.streetAddress != null
                   && customer.state != null
                   && customer.zipcode != null
                   && customer.phoneNumber != null)
            {
                try
                {
                    //not using the int values, just making sure the user entered numbers
                    decimal zip = decimal.Parse(customer.zipcode);
                    decimal phone = decimal.Parse(customer.phoneNumber);

                    CustomerDAO.EditCustomer(customer);
                    customersForm.ReloadCustomers();
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Invalid Input", "Invalid Input", MessageBoxButtons.OK);
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditCustomerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
