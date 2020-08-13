﻿using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Mvc_Validacao.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "O nome deve ser informado.")]
        [StringLength(50,MinimumLength =5,ErrorMessage ="O nome deve ter no mínimo 5 caracteres e no máximo 50")]
        [Display(Name ="Informe o nome do cliente")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O email deve ser informado.")]
        [EmailAddress(ErrorMessage ="Informe um email válido.")]
        [Remote("ValidaEmailDisponivel","Cliente",ErrorMessage ="Este e-mail já existe na base de emails.")]
        public string Email { get; set; }

        [StringLength(10, MinimumLength = 6, ErrorMessage = "O nome deve ter no mínimo 5 caracteres e no máximo 50")]
        public string Telefone { get; set; }

        [Range(21,65, ErrorMessage ="A idade deve der maior que 21 e menor que 65.")]
        public int Idade { get; set; }
    }
}