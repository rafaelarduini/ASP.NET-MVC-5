﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_EF.Models;

namespace Mvc_EF.Controllers
{
    public class TipoClienteController : Controller
    {
        // GET: TipoCliente
        public ActionResult Index()
        {

            using (ClienteContext clienteContext = new ClienteContext())
            {
                List<Tipo> tiposCliente = clienteContext.tipos.ToList();
                return View(tiposCliente);
            }
        }
    }
}