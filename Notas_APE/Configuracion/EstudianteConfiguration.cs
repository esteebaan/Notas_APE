using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Notas_APE.Models;

namespace Notas_APE.Configuracion
{
    public class EstudianteConfiguration : IEntityTypeConfiguration<Estudiante>
    {
        public void Configure(EntityTypeBuilder<Estudiante> builder)
        {
            builder.HasKey(e => e.Cedula);

            builder.Property(e => e.Nombre)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(e => e.Apellido)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(e => e.Correo)
                   .IsRequired();

            builder.Property(e => e.Genero)
                   .IsRequired();

            builder.HasMany(e => e.Notas)
                   .WithOne(n => n.Estudiante)
                   .HasForeignKey(n => n.CedulaEstudiante)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
