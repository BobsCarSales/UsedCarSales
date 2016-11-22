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
    public partial class TransactionForm : Form
    {
        Vehicle currentVehicle;

        public TransactionForm(Vehicle vehicle)
        {
            InitializeComponent();
            this.currentVehicle = vehicle;
        }
    }
}
