using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsedCarSales.DataAccessObjects
{
    class MakeDAO
    {
        //TODO: need to be checking for null values where corresponding columns are nOT NULL

        public static List<Make> GetAllMakes()
        {
            return DatabaseContext.dbContext.Makes.ToList();
        }
    }
}
