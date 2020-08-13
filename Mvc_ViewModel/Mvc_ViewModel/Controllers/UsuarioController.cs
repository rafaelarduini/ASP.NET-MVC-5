using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_ViewModel.Models;
using Mvc_ViewModel.ViewModel;

namespace Mvc_ViewModel.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }

        // GET: Usuario
        public ActionResult AlterarSenha()
        {
            //Apresentar formulário
            //Usuario usuario = new Usuario();
            AlteraSenhaViewModel usuario = new AlteraSenhaViewModel();
            return View(usuario);
        }

        [HttpPost]
        public ActionResult AlterarSenha(AlteraSenhaViewModel usuario)
        {
            //validar model
            //persistir dados
            return View();
        }
    }
}