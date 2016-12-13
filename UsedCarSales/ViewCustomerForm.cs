using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsedCarSales
{
    public partial class ViewCustomerForm : Form
    {
        public ViewCustomerForm(Customer customer)
        {
            InitializeComponent();
            initializeForm(customer);
        }

        private void initializeForm(Customer customer)
        {
            firstNameValueLabel.Text = customer.firstName;
            lastNameValueLabel.Text = customer.lastName;
            addressValueLabel.Text = customer.streetAddress;
            stateValueLabel.Text = customer.state;
            zipcodeValueLabel.Text = customer.zipcode;
            phoneValueLabel.Text = customer.phoneNumber;

            if(customer.Transactions != null)
            {
                transactionListBox.DataSource = customer.Transactions.ToList();
            }
        }
    }
}
