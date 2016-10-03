using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsedCarSales
{
    class Vehicle
    {
        //question marks mean that the variable can be set to null
        public int id { get; set; }
        public bool? used { get; set; }
        public bool? sold { get; set; }
        public int? model { get; set; }

        

    }
}
