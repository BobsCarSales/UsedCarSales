using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsedCarSales
{
    public partial class Transaction
    {
        public override String ToString()
        {
            return this.date.ToShortDateString() + " - $" + this.totalCost + " - " + this.Vehicle.ToString();
        }
    }
}
