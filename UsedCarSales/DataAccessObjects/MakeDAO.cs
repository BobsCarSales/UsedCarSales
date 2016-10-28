using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsedCarSales.DataAccessObjects
{
    class MakeDAO
    {
        public static List<Make> GetAllMakes()
        {
            return DatabaseContext.dbContext.Makes.ToList();
        }
    }
}
