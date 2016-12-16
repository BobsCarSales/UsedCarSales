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
    public partial class CustomersForm : Form
    {
        public List<Customer> customers = new List<Customer>();

        bool isSearch = false;

        public CustomersForm()
        {
            InitializeComponent();

            this.customersListBox.SelectedValueChanged += new System.EventHandler(changeButtonEnabledValues); //when a vehicle is selected or deselected, the edit vehicle button needs to be enabled or disabled

            viewCustomerButton.Enabled = false;
            editCustomerButton.Enabled = false;
        }

        //reload the list of customers
        public void ReloadCustomers()
        {
            //reset the list of promotions so old data doesn't hang out after we edit it
            customersListBox.DataSource = null;

            //load customers based on search criteria, or just load all of the vehicles
            if (isSearch)
            {
                searchCustomersButton_Click();
            }
            else
            {
                allCustomersButton_Click();
            }
        }

        //change edit and view buttons to disabled if a Customer is not selected
        private void changeButtonEnabledValues(object sender = null, System.EventArgs e = null)
        {
            Boolean enabled = (customersListBox.SelectedItem == null) ? false : true;

            editCustomerButton.Enabled = enabled;
            viewCustomerButton.Enabled = enabled;
        }

        private void allCustomersButton_Click(object sender = null, EventArgs e = null)
        {
            isSearch = false;
            updateCustomersListBox(CustomerDAO.GetAllCustomers());
        }

        private void searchCustomersButton_Click(object sender = null, EventArgs e = null)
        {
            isSearch = true;

            Customer customer = new Customer();

            customer.firstName = firstNameTextBox.Text.ToString();
            customer.lastName = lastNameTextBox.Text.ToString();

            updateCustomersListBox(CustomerDAO.SearchCustomers(customer));
        }

        private void viewCustomerButton_Click(object sender, EventArgs e)
        {
            if (customersListBox.SelectedItem != null)
            {
                ViewCustomerForm viewCustomerForm = new ViewCustomerForm((Customer)customersListBox.SelectedItem);
                viewCustomerForm.Show();
            }
        }

        private void editCustomerButton_Click(object sender, EventArgs e)
        {
            if (customersListBox.SelectedItem != null)
            {
                EditCustomerForm editCustomerForm = new EditCustomerForm((Customer)customersListBox.SelectedItem, this);
                editCustomerForm.Show();

                //reset the list of vehicles so old data doesn't hang out after we edit it
                customersListBox.DataSource = null;
            }
        }

        private void updateCustomersListBox(List<Customer> newCustomers)
        {
            customers = newCustomers;
            customersListBox.DataSource = customers;

            if (customers.Count < 1)
            {
                changeButtonEnabledValues();
            }
        }
    }
}
