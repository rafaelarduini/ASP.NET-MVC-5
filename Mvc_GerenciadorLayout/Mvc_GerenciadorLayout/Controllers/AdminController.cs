using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_GerenciadorLayout.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            ViewBag.Titulo = "Administração do Site (Index)";
            return View();
        }

        // GET: Admin
        public ActionResult Incluir()
        {
            ViewBag.Titulo = "Incluir (Admin)";
            return View();
        }

        // GET: Admin
        public ActionResult Alterar()
        {
            ViewBag.Titulo = "Alterar (Admin)";
            return View();
        }

        // GET: Admin
        public ActionResult Excluir()
        {
            ViewBag.Titulo = "Excluir (Admin)";
            return View();
        }

    }
}