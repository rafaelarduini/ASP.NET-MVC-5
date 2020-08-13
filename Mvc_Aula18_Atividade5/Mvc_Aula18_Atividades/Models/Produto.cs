using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Mvc_Aula18_Atividades.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }

        [Required(ErrorMessage = "O nome deve ser informado.")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "O nome deve ter no mínimo 5 caracteres e no máximo 50")]
        [Remote("ValidaProdutoDuplicado", "Produto", ErrorMessage = "Este produto já existe no estoque")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A descrição deve ser informado.")]
        [StringLength(50, MinimumLength = 15, ErrorMessage = "A descrição deve ter no mínimo 15 caracteres e no máximo 50")]
        [Display(Name = "Informe a descrição do produto")]
        public string Descricao { get; set; }

        [Range(2, 10, ErrorMessage = "O estoque deve ser maior que 2 e menor que 10.")]
        public int Estoque { get; set; }
    }
}