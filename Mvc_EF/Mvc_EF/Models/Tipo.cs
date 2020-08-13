using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Mvc_EF.Models
{
    [Table("Tipos")]
    public class Tipo
    {
        public int TipoId { get; set; }
        public string Nome { get; set; }
        public List<Cliente> Clientes { get; set; }
    }
}