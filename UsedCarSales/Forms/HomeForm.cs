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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        //load the vehicles form
        private void vehiclesButton_Click(object sender, EventArgs e)
        {
            VehiclesForm vehiclesForm = new VehiclesForm();
            vehiclesForm.Show();
        }

        //load the promotions form
        private void promotionsButton_Click(object sender, EventArgs e)
        {
            PromotionsForm promotionForm = new PromotionsForm();
            promotionForm.Show();
        }

        //load the customers form
        private void customersButton_Click(object sender, EventArgs e)
        {
            CustomersForm customersForm = new CustomersForm();
            customersForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
