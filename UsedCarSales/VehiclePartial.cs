using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsedCarSales
{
    public partial class Vehicle
    {
        public override String ToString()
        {
            string ret = (year + " " + Model.Make.id + " " + Model.id + " - $" + price);
            
            if(this.sold == true)
            {
                ret += (" (Sold)");
            }

            return ret;
        }
    }
}
