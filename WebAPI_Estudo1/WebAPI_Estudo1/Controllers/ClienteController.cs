using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebAPI_Estudo1.Models;

namespace WebAPI_Estudo1.Controllers
{
    public class ClienteController : ApiController
    {
        private List<Cliente> clientes = new List<Cliente>()
        {
            new Cliente { Id=1, Nome="Rafael", Email="rafaelarduini@hotmail.com" },
            new Cliente { Id=2, Nome="Aline", Email="aline@hotmail.com" },
            new Cliente { Id=3, Nome="Marie", Email="marie@hotmail.com" },
            new Cliente { Id=4, Nome="Nina", Email="nina@hotmail.com" },
        };

        // GET: api/Cliente
        public IEnumerable<Cliente> Get()
        {
            return clientes.ToList();
        }

        // GET api/Cliente/5
        public IHttpActionResult Get(int id)
        {
            var cliente = clientes.Where(x => x.Id == id);
            if (cliente == null)
            return NotFound();

            return Ok(cliente);
        }
    }
}
