using System.Web.Mvc;
using Mvc_Helpers.Models;
using System.Collections.Generic;
using System;

namespace Mvc_Helpers.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var lista = new List<string> { "Brasil", "Argentina", "Mexico" };
            ViewBag.Lista = new SelectList(lista);

            var cliente = new Cliente()
            {
                Id = 100,
                Nome = "Macoratti",
                Idade = 45,
                Email = "macoratti@yahoo.com",
                EstadoCivil = "Casado",
                Status = true,
                Observacao = "Nada a declarar",
                Admissao = DateTime.Now.Date
            };
            return View(cliente);
        }

        // GET: Home
        public ActionResult Editar()
        {
            var cliente = new Cliente()
            {
                Id = 100,
                Nome = "Macoratti",
                Idade = 45,
                Email = "macoratti@yahoo.com",
                EstadoCivil = "Casado",
                Status = true,
                Observacao = "Nada a declarar",
                Admissao = DateTime.Now.Date
            };
            return View(cliente);
        }

        public ActionResult Deletar()
        {
            var lista = new List<string> { "Brasil", "Argentina", "Mexico" };
            ViewBag.Lista = new SelectList(lista);

            var cliente = new Cliente()
            {
                Id = 100,
                Nome = "Macoratti",
                Idade = 45,
                Email = "macoratti@yahoo.com",
                EstadoCivil = "Casado",
                Status = true,
                Observacao = "Nada a declarar",
                Admissao = DateTime.Now.Date
            };
            return View(cliente);
        }

        public ActionResult Alterar()
        {
            var lista = new List<string> { "Brasil", "Argentina", "Mexico" };
            ViewBag.Lista = new SelectList(lista);

            var cliente = new Cliente()
            {
                Id = 100,
                Nome = "Macoratti",
                Idade = 45,
                Email = "macoratti@yahoo.com",
                EstadoCivil = "Casado",
                Status = true,
                Observacao = "Nada a declarar",
                Admissao = DateTime.Now.Date
            };
            return View(cliente);
        }
        public ActionResult Criar()
        {
            var lista = new List<string> { "Brasil", "Argentina", "Mexico" };
            ViewBag.Lista = new SelectList(lista);

            var cliente = new Cliente()
            {
                Id = 100,
                Nome = "Macoratti",
                Idade = 45,
                Email = "macoratti@yahoo.com",
                EstadoCivil = "Casado",
                Status = true,
                Observacao = "Nada a declarar",
                Admissao = DateTime.Now.Date
            };
            return View(cliente);
        }
    }
}