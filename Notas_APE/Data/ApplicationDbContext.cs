using Microsoft.EntityFrameworkCore;
using Notas_APE.Models;
using Notas_APE.Configuracion;

namespace Notas_APE.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Nota> Notas { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Promedio> Promedios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new EstudianteConfiguration());
            modelBuilder.ApplyConfiguration(new PromedioConfiguration());
        }
    }
}
