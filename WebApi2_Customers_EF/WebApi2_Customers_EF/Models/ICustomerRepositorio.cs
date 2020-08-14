using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi2_Customers_EF.Models
{
    public interface ICustomerRepositorio
    {
        IEnumerable<Customer> GetAllCustomers();
        Customer GetCustomerById(int customerID);
        Customer AddCustomer(Customer customer);
        bool UpdateCustomer(Customer customer);
        bool DeleteCustomer(int CustomerID);
        bool CustomerExists(int CustomerID);

    }
}
