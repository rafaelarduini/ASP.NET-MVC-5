using System.ComponentModel.DataAnnotations;

namespace Mvc_ViewModel.ViewModel
{
    public class AlteraSenhaViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Senha de Acesso")]
        public string Senha { get; set; }

        public string Login { get; set; }

        [DataType(DataType.Password)]
        public string NovaSenha { get; set; }
        [DataType(DataType.Password)]
        public string ConfirmaSenha { get; set; }
    }
}