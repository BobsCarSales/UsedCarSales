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
    public partial class ViewVehicleForm : Form
    {
        public ViewVehicleForm(Vehicle vehicle)
        {
            InitializeComponent();
            initializeForm(vehicle);
        }

        private void initializeForm(Vehicle vehicle)
        {
            makeValueLabel.Text = vehicle.Model.Make;
            modelValueLabel.Text = vehicle.Model.Id;
            yearValueLabel.Text = vehicle.Year.ToString();
            usedValueLabel.Text = vehicle.Used.ToString();
            soldValueLabel.Text = vehicle.Sold.ToString();
        }
    }
}
