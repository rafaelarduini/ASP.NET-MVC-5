using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc_Helpers.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }
        public string EstadoCivil { get; set; }
        public bool Status { get; set; }
        public DateTime Admissao { get; set; }
        public string Observacao { get; set; }
    }
}