using Atividade_aula_28.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Atividade_aula_28.Controllers
{
    public class HomeController : Controller
    {
        List<Produto> lista = new List<Produto>
        {
            new Produto { Id=1, Nome="Cadeira", Estoque= 152 },
            new Produto { Id=2, Nome="Geladeira", Estoque= 352 },
            new Produto { Id=3, Nome="Mesa", Estoque= 12 },
            new Produto { Id=4, Nome="Chuveiro", Estoque= 452 },
            new Produto { Id=5, Nome="Microondas", Estoque= 52 }
        };

        // GET: Home
        public ActionResult Index()
        {
            return View(lista);
        }

        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
            ViewBag.Titulo = "Detalhes do Produto";
            if (id == 0)
                return View("NotFound");

            var model = (from produto in lista.Where(x => x.Id == id)
                         select produto).FirstOrDefault();

            if (model == null)
                return View("NotFound");

            return View(model);
        }

        // GET: Home/Create
        public ActionResult Create()
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

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

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
            ViewBag.Titulo = "Editar Dados do Produto";
            if (id == 0)
                return View("NotFound");

            var model = (from produto in lista.Where(x => x.Id == id)
                         select produto).FirstOrDefault();

            if (model == null)
                return View("NotFound");

            return View(model);
        }

        // POST: Home/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

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
            ViewBag.Titulo = "Deletar Produto";
            if (id == 0)
                return View("NotFound");

            var model = (from produto in lista.Where(x => x.Id == id)
                         select produto).FirstOrDefault();

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
