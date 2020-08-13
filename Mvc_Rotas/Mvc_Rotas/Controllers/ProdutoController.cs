﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_Rotas.Models;

namespace Mvc_Rotas.Controllers
{
    public class ProdutoController : Controller
    {
        private List<Produto> todosProdutos;
        public ProdutoController()
        {
            todosProdutos = new Produto().TodosProdutos().OrderBy(x => x.Preco).ToList();
        }

        // GET: Produto
        public ActionResult Index()
        {
            ViewBag.Produtos = "Todos os produtos";
            return View(todosProdutos);
        }

        // GET: Produto
        public ActionResult Detalhes(int produtoId)
        {
            return View(todosProdutos.FirstOrDefault(x => x.ProdutoId == produtoId));
        }

        // GET: Produto
        public ActionResult Categorias (string categoria)
        {
            var _categoria = todosProdutos.Where(x => x.Categoria == categoria).ToList();
            ViewBag.Categoria = categoria;
            return View(_categoria);
        }

        public ActionResult Cadastrar()
        {
            return View();
        }
    }
}