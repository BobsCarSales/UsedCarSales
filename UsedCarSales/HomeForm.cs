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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void vehiclesButton_Click(object sender, EventArgs e)
        {
            VehiclesForm vehiclesForm = new VehiclesForm();
            vehiclesForm.Show();
        }

        private void promotionsButton_Click(object sender, EventArgs e)
        {

        }

        private void transactionsButton_Click(object sender, EventArgs e)
        {
            SellVehicleForm sellVehicleForm = new SellVehicleForm();
            sellVehicleForm.Show();
        }
    }
}
