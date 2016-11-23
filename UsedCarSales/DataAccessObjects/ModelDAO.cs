using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsedCarSales.DataAccessObjects
{
    public static class ModelDAO
    {
        //TODO: need to be checking for null values where corresponding columns are nOT NULL
        
        public static List<Model> GetModelsByMake(Make make)
        {
            return DatabaseContext.dbContext.Models.Where(m => m.Make.id == make.id).ToList();
        }

    }
}
