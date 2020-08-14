using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using WebApi2_Customers_EF.Models;

namespace WebApi2_Customers_EF.Controllers
{
    public class CustomerController : ApiController
    {
        static readonly ICustomerRepositorio rep = new CustomerRepositorio();


        public IEnumerable<Customer> GetAllCustomers()
        {
            return rep.GetAllCustomers();
        }

        // especifica o tipo de entidade retornada pela Action 
        // Para os tipos HttpResponseMessage or IHttpActionResult.
        // GET: api/Customers/5
        [ResponseType(typeof(Customer))]
        public IHttpActionResult GetCustomerById(int codigo)
        {
            Customer customer = rep.GetCustomerById(codigo);
            if (customer == null)
            {
                return NotFound();
            }

            return Ok(customer);
        }

        // POST: api/Customers
        [ResponseType(typeof(Customer))]
        public IHttpActionResult PostCustomer(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            rep.AddCustomer(customer);

            //Retorna uma URI para o novo recurso criado quando invocar o método POST 
            return CreatedAtRoute("DefaultApi", new { id = customer.CustomerID }, customer);

        }

        // PUT: api/Customers/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCustomer(int codigo, Customer customer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (codigo != customer.CustomerID)
            {
                return BadRequest();
            }

            try
            {
                rep.UpdateCustomer(customer);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!rep.CustomerExists(codigo))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return StatusCode(HttpStatusCode.NoContent);
        }

        // DELETE: api/Customers/5
        [ResponseType(typeof(void))]
        public IHttpActionResult DeleteCustomer(int codigo)
        {
            if (!rep.CustomerExists(codigo))
            {
                return NotFound();
            }

            bool resultado = rep.DeleteCustomer(codigo);
            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}
