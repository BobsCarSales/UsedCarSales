using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsedCarSales.DataAccessObjects
{
    class TransactionDAO
    {
        public static void SaveTransaction(Transaction transaction)
        {
            DatabaseContext.dbContext.Transactions.Add(transaction);
            DatabaseContext.dbContext.SaveChangesAsync();
        }
    }
}
