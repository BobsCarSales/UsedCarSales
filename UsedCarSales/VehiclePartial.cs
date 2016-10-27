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
            return (year + " " + Model.Make.id + " " + Model.id);
        }
    }
}
