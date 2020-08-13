using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mcv_Produtos.Models;

namespace Mcv_Produtos.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        public ActionResult Produtos()
        {
            Produto produto = new Produto()
            {
                Id = 100,
                Nome = "copo",
                Descricao = "copo de vidro",
            };
            return View(produto);
        }
    }
}