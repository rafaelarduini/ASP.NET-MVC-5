using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Atividade2b.Models;

namespace Atividade2b.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        public ActionResult Index()
        {
            var produto = new Produto();
            return View(produto);
        }

        [HttpPost]
        public ActionResult Index(Produto produto)
        {
            //if (string.IsNullOrEmpty(produto.Nome))
            //    ModelState.AddModelError("Nome", "O nome é obrigatório.");
            //if (string.IsNullOrEmpty(produto.Descricao))
            //    ModelState.AddModelError("Descricao", "A descrição é obrigatória.");
            //if (produto.Estoque == 0)
            //{
            //    ModelState.AddModelError("Estoque", "O valor de estoque é obrigatório.");
            //}
            //else
            //{
            //    if (produto.Estoque > 10)
            //    {
            //        ModelState.AddModelError("Estoque", "O estoque não pode ser maior que 10");
            //    }
            //}
            if (!ModelState.IsValid)
            {
                return View(produto);
            }
            else
            {
                return View("Validacao", produto);
            }
        }

        public ActionResult Validacao(Produto produto)
        {
            return View(produto);
        }

        public ActionResult ValidaProdutoDuplicado(string nome)
        {
            nome = nome.ToLower();
            var baseDeProdutos = new List<string>
            {
                "Computador",
                "Impressora",
                "Notebook"
            };

            return Json(baseDeProdutos.All(n => n.ToString().ToLower() != nome), JsonRequestBehavior.AllowGet);
        }

    }
}