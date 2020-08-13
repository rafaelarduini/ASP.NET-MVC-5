using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Demo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //    ViewData["Nome"] = "Macoratti";
            //    ViewData["Email"] = "macoratti @yahoo.com";
            //    ViewData["Curso"] = "ASP .NET MVC";
            //    ViewData["DataInicio"] = new DateTime(2015, 07, 01);

            //ViewBag.Nome = "Macoratti";
            //ViewBag.Email = "macoratti @yahoo.com";
            //ViewBag.Curso = "ASP .NET MVC";
            //ViewBag.DataInicio = new DateTime(2015, 07, 01);

            ViewData["Paises"] = new List<string>()
            {
                "Brasil",
                "Peru",
                "China",
                "Canada"
            };

            return View();
        }

        public string Inicio()
        {
            return "Minha primeira aplicação ASP .NET MVC";
        }

        public string Saudacao(int id)
        {
            return "Codigo recebido da Url = " + id.ToString();
        }

    }
}