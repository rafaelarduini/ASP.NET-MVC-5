using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Teste01.Models;

namespace Teste01.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Titulo = "Página Index do produto";

            var produto = new Produto
            {
                Nome = "camiseta",
                Descricao = "camiseta branca",
                Preco = 100.00M,
            };
            return View(produto);
        }
    }
}