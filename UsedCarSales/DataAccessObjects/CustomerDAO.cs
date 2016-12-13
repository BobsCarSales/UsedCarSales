using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsedCarSales.DataAccessObjects
{
    class CustomerDAO
    {
        public static List<Customer> GetAllCustomers()
        {
            return DatabaseContext.dbContext.Customers.ToList();
        }

        public static List<Customer> SearchCustomers(Customer customer)
        {
            List<Customer> customers = new List<Customer>();

            customers = DatabaseContext.dbContext.Customers.Where(c => (c.firstName.Equals(customer.firstName))
                                                                    || (c.lastName.Equals(customer.lastName))).ToList();

            return customers;
        }

        public static void EditCustomer(Customer customer)
        {
            DatabaseContext.dbContext.Entry(customer).State = System.Data.Entity.EntityState.Modified;
            DatabaseContext.dbContext.SaveChangesAsync();
        }
    }
}
