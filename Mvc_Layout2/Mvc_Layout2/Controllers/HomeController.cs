using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_Layout2.Models;

namespace Mvc_Layout2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewData["Titulo"] = "Pagina de index do site";

            var produto = new Produto
            {
                Nome = "Smartphone Samsung Galaxy S5",
                Preco = 1999.00M
            };

            return View(produto);
        }

        public ActionResult Sobre()
        {
            ViewBag.Titulo = "Pagina de sobre do site";
            return View();
        }
    }
}