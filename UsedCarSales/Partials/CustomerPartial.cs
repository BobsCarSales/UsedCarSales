using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsedCarSales
{
    public partial class Customer
    {
        public override string ToString()
        {
            return this.lastName + ", " + this.firstName;
        }
    }
}
