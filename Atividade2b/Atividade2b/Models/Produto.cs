using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Atividade2b.Models
{
    public class Produto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome deve ser informado")]
        [StringLength(50,MinimumLength =5,ErrorMessage = "Tamanho mínimo 5 e máximo 50")]
        [Display(Name = "Informe o nome do produto")]
        [Remote("ValidaProdutoDuplicado","Produto",ErrorMessage ="Esse produto já existe")]
        public string Nome { get; set; }

        [Required(ErrorMessage ="A descrição deve ser informada")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Tamanho mínimo 5 e máximo 50")]
        [Display(Name = "Informe a descrição do produto")]
        public string Descricao { get; set; }

        [Range(2,10,ErrorMessage ="O estoque deve ser entre 2 e 10")]
        public int Estoque { get; set; }
    }
}