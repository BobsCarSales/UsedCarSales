using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsedCarSales.DataAccessObjects
{
    public static class ModelDAO
    {
        public static EntityContext dbContext = new EntityContext();

        public static List<Model> GetModelsByMake(Make make)
        {
            return dbContext.Models.Where(m => m.Make.id == make.id).ToList();
        }

    }
}
