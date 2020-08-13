using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;

namespace Mvc_BO.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            AlunoBLL _aluno = new AlunoBLL();

            List<Aluno> alunos = _aluno.getAlunos().ToList();

            return View(alunos);
        }

        // GET: Home
        public ActionResult ListaAlunos()
        {
            AlunoBLL _aluno = new AlunoBLL();

            List<Aluno> alunos = _aluno.getAlunos().ToList();

            return View(alunos);
        }


        //Get
        [ActionName("Create")]
        public ActionResult Create_Get()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Create")]
        public ActionResult Create_Post(Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                AlunoBLL alunobll = new AlunoBLL();
                alunobll.IncluirAluno(aluno);
                return RedirectToAction("Index");
            }
            return View();
        }

        //get
        public ActionResult Edit(int id)
        {
            AlunoBLL alunobll = new AlunoBLL();
            Aluno aluno = alunobll.getAlunos().Single(x => x.Id == id);
            return View(aluno);
        }

        [HttpPost]
        [ActionName("Edit")]
        public ActionResult Edit_Post([Bind(Exclude = "Nome")]Aluno aluno)
        {
            AlunoBLL alunobll = new AlunoBLL();
            aluno.Nome = alunobll.getAlunos().Single(x => x.Id == aluno.Id).Nome;
            //Aluno aluno = alunobll.getAlunos().Single(x => x.Id == id);
            //UpdateModel(aluno, null, null, excludeProperties: new[] { "Nome" });

            if (ModelState.IsValid)
            {
                alunobll.AtualizarAluno(aluno);
                return RedirectToAction("Index");
            }                       
            return View(aluno);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            AlunoBLL alunobll = new AlunoBLL();
            alunobll.DeletarAluno(id);
            return RedirectToAction("Index");
        }

        //[HttpPost]
        //public ActionResult Delete(Aluno aluno)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        AlunoBLL alunobll = new AlunoBLL();
        //        alunobll.DeletarAluno(aluno.Id);
        //        return RedirectToAction("Index");
        //    }
        //    return View(aluno);
        //}

        public ActionResult Details(int id)
        {
            AlunoBLL alunobll = new AlunoBLL();
            Aluno aluno = alunobll.getAlunos().Single(x => x.Id == id);
            return View(aluno);
        }

        public ActionResult Procurar(string procurarPor, string criterio)
        {
            AlunoBLL alunobll = new AlunoBLL();
            if(procurarPor == "Email")
            {
                Aluno aluno = alunobll.getAlunos().SingleOrDefault(x => x.Email == criterio || criterio == null);
                return View(aluno);
            }
            else
            {
                Aluno aluno = alunobll.getAlunos().SingleOrDefault(x => x.Nome == criterio || criterio == null);
                return View(aluno);
            }
        }
    }
}