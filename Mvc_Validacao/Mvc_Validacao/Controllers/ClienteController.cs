using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_Validacao.Models;

namespace Mvc_Validacao.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            var cliente = new Cliente();
            return View(cliente);
        }

        [HttpPost]
        public ActionResult Index(Cliente cliente)
        {
            ////validação do lado do servidor
            //if (string.IsNullOrEmpty(cliente.Nome))
            //    ModelState.AddModelError("Nome", "O nome é obrigratório");

            //if (cliente.Nome == cliente.Email)
            //    ModelState.AddModelError("", "O nome não pode ser igual ao email");

            //if (string.IsNullOrEmpty(cliente.Email))
            //    ModelState.AddModelError("Email", "O email é obrigratório");

            //if (string.IsNullOrEmpty(cliente.Telefone))
            //    ModelState.AddModelError("Telefone", "O telefone é obrigratório");

            //if (cliente.Idade == 0)
            //{
            //    ModelState.AddModelError("Idade", "A idade é obrigratória");
            //}
            //else
            //{
            //    if (cliente.Idade <= 21)
            //    {
            //        ModelState.AddModelError("Idade", "A idade informada tem que ser maior que 21 anos");
            //    }
            //}

            //AValidação falhou?
            if (!ModelState.IsValid)
            {
                //sim, falhou
                return View(cliente);
            }
            else
            {
                //está tudo ok
                return View("Validacao", cliente);
            }
        }
        public ActionResult Validacao(Cliente cliente)
        {
            return View(cliente);
        }

        public ActionResult ValidaEmailDisponivel(string email)
        {
            var baseDeEmails = new List<string>
            {
                "rafaelarduini@hotmail.com",
                "aline@hotmail.com",
                "marie@hotmail.com"
            };

            return Json(baseDeEmails.All(e => e.ToString().ToLower() != email), JsonRequestBehavior.AllowGet);
        }
    }
}