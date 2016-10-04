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
        public int Id { get; set; }
        public bool? Used { get; set; }
        public bool? Sold { get; set; }
        public int? Model { get; set; }

        

    }
}
