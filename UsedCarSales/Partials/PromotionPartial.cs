﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsedCarSales
{
    public partial class Promotion
    {
        public override String ToString()
        {
            if(Make != null)
            {
                return (Make.id + ": " + discountAmount + "% off");
            } else
            {
                return "No Promotion";
            }
        }
    }
}
