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
            makeValueLabel.Text = vehicle.Model.Make.id;
            modelValueLabel.Text = vehicle.Model.id;
            yearValueLabel.Text = vehicle.year.ToString();
            usedValueLabel.Text = vehicle.used.ToString();
            soldValueLabel.Text = vehicle.sold.ToString();
        }
    }
}
