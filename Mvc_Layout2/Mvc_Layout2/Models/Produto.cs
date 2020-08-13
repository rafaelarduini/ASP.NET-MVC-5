using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc_Layout2.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        //Exibir nome e preco
        public string Nome { get; set; }
        public decimal Preco { get; set; }
    }
}