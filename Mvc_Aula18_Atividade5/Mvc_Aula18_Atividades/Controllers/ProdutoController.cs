using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Mvc_Aula18_Atividades.Models;

namespace Mvc_Aula18_Atividades.Controllers
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
            ////validação do lado do servidor
            //if (string.IsNullOrEmpty(produto.Nome))
            //    ModelState.AddModelError("Nome", "O nome é obrigatório");

            //if (string.IsNullOrEmpty(produto.Descricao))
            //    ModelState.AddModelError("Descricao", "A descrição é obrigatório");

            //if (produto.Estoque == 0)
            //{
            //    ModelState.AddModelError("Estoque", "O valor do estoque é obrigatório");
            //}
            //else
            //{
            //    if (produto.Estoque > 10)
            //    {
            //        ModelState.AddModelError("Estoque", "O estoque não pode ser maior que 10");
            //    }
            //}

            //A validação falhou ?
            if (!ModelState.IsValid)
            {
                //sim , falhou
                return View(produto);
            }
            else
            {
                //esta tudo ok
                return View("Validacao", produto);
            }
        }
        public ActionResult Validacao(Produto produto)
        {
            return View(produto);
        }

        public ActionResult ValidaProdutoDuplicado(string produto)
        {
            //usaria um banco de dados ou serviço ou acessar uma fonte de informações
            var baseDeProdutos = new List<string>
            {
                "Impressora",
                "Computador",
                "Notebook"
            };

            // se o email não existir na lista então retorna true
            // caso contrario retorna false
            return Json(baseDeProdutos.All(e => e.ToString().ToLower() != produto), JsonRequestBehavior.AllowGet);

        }
    }
}