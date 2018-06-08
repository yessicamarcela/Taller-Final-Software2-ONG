using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoFinalSoftwareONG.Entidades;

namespace TrabajoFinalSoftwareONG.Datos
{
    public class Context : DbContext
    {
        public Context()
            : base("name=TrabajoFinalSoftwareONG")
        {
            Database.SetInitializer(new Initializer());
        }

        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<TipoDocumento> TiposDocumento { get; set; }
        public DbSet<Medicamentos> MedicamentosTomados { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TipoDocumento>()
                .HasMany(p => p.Pacientes)
                .WithRequired(p => p.TipoDocumento)
                .HasForeignKey(p => p.IdTipoDocumento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Medicamentos>()
                .HasMany(p => p.Pacientes)
                .WithRequired(p => p.Medicamentos)
                .HasForeignKey(p => p.IdMedicamentos)
                .WillCascadeOnDelete(false);

        }
    }
}
