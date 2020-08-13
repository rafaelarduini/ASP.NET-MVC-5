namespace EntidadesDAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Empregados")]
    public partial class Empregado
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmpregadoId { get; set; }

        public int DepartamentoId { get; set; }

        [Required]
        [StringLength(50)]
        public string Nome { get; set; }

        [Required]
        [StringLength(50)]
        public string Sobrenome { get; set; }

        [Required]
        [StringLength(100)]
        [EmailAddress(ErrorMessage = "Email inválido")]
        public string Email { get; set; }

        public virtual Departamento Departamento { get; set; }
    }
}
