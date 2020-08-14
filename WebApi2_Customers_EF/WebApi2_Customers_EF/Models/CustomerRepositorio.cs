using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace WebApi2_Customers_EF.Models
{
    public class CustomerRepositorio : ICustomerRepositorio
    {
        NorthwindEntities entities = new NorthwindEntities();
        public IEnumerable<Customer> GetAllCustomers()
        {
            return entities.Customers.ToList();
        }

        public Customer GetCustomerById(int customerID)
        {
            return entities.Customers.Where(c => c.CustomerID == customerID).FirstOrDefault();
        }

        public Customer AddCustomer(Customer customer)
        {
            try
            {
                entities.Customers.Add(customer);
                entities.SaveChanges();
                return customer;
            }
            catch(DbUpdateException)
            {
                throw;
            }
        }

        public bool DeleteCustomer(int customerID)
        {
            try
            {
                Customer cust = entities.Customers.Where(c => c.CustomerID == customerID).FirstOrDefault();
                entities.Customers.Remove(cust);
                entities.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateCustomer(Customer customer)
        {
            try
            {
                Customer cust = entities.Customers.Where(c => c.CustomerID == customer.CustomerID).FirstOrDefault();
                cust.City = customer.City;
                cust.ContactName = customer.ContactName;
                cust.Country = customer.Country;

                entities.Entry(customer).State = EntityState.Modified;

                entities.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool CustomerExists(int customerID)
        {
            return entities.Customers.Count(e => e.CustomerID == customerID) > 0;
        }
    }
}