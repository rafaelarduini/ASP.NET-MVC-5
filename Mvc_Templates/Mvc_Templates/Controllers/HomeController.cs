using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_Templates.Models;

namespace Mvc_Templates.Controllers
{
    public class HomeController : Controller
    {
        List<Time> lista = new List<Time>
        {
            new Time { Id=1, Nome="Santos", Ano=1929 },
            new Time { Id=2, Nome="Vasco", Ano=1935 },
            new Time { Id=3, Nome="Sport", Ano=1946 },
            new Time { Id=4, Nome="Cruzeiro", Ano=1934 },
            new Time { Id=5, Nome="Palmeiras", Ano=1928 }
        };

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: Home
        public ActionResult List()
        {
            ViewBag.Titulo = "Listar Times";
            return View(lista);
        }

        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
            ViewBag.Titulo = "Detalhe do Time";
            if (id == 0)
                return View("NotFound");

            var model = (from time in lista.Where(x => x.Id == id)
                         select time).FirstOrDefault();

            if (model == null)
                return View("NotFound");

            return View(model);
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            ViewBag.Titulo = "Criar Time";
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create(Time t)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View();
                //mecanismo para persisitir dados
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.Titulo = "Editar Dados do Time";
            if (id == 0)
                return View("NotFound");

            var model = (from time in lista.Where(x => x.Id == id)
                         select time).FirstOrDefault();

            if (model == null)
                return View("NotFound");

            return View(model);
        }

        // POST: Home/Edit/5
        [HttpPost]
        public ActionResult Edit(Time t)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            ViewBag.Titulo = "Deletar Time";
            if (id == 0)
                return View("NotFound");

            var model = (from time in lista.Where(x => x.Id == id)
                         select time).FirstOrDefault();

            if (model == null)
                return View("NotFound");

            return View(model);
        }

        // POST: Home/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
