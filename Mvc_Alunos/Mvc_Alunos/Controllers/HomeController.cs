using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_Alunos.Models;

namespace Mvc_Alunos.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var aluno = new Aluno
            {
                Nome = "Rafael",
                Email = "rafaelarduini@hotmail.com"
            };
            return View(aluno);
        }

        public ActionResult Sobre()
        {
            return View();
        }
    }
}