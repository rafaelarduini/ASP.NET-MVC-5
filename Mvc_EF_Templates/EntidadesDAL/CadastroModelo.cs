namespace EntidadesDAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CadastroModelo : DbContext
    {
        public CadastroModelo()
            : base("name=CadastroModelo")
        {
        }

        public virtual DbSet<Departamento> Departamentos { get; set; }
        public virtual DbSet<Empregado> Empregados { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Departamento>()
                .HasMany(e => e.Empregados)
                .WithRequired(e => e.Departamento)
                .WillCascadeOnDelete(false);
        }
    }
}
