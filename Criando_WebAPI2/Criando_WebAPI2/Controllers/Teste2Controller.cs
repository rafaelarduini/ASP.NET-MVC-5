﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Criando_WebAPI2.Controllers
{
    public class Teste2Controller : ApiController
    {
        // GET: api/Teste2
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Teste2/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Teste2
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Teste2/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Teste2/5
        public void Delete(int id)
        {
        }
    }
}
