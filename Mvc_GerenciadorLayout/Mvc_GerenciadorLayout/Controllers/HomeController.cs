using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_GerenciadorLayout.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Titulo = "Página Index (Home)";
            return View();
        }

        // GET: Home
        public ActionResult Sobre()
        {
            ViewBag.Titulo = "Página Sobre (Home)";
            return View();
        }
    }
}