using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Notas_APE.Models;

namespace Notas_APE.Configuracion
{
    public class PromedioConfiguration : IEntityTypeConfiguration<Promedio>
    {
        public void Configure(EntityTypeBuilder<Promedio> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.CedulaEst)
                .HasColumnName("cedula_est")
                .IsRequired();

            builder.Property(p => p.ValorPromedio)
                .HasColumnName("promedio")
                .IsRequired();

            builder.HasOne(p => p.Estudiante)
                .WithMany()
                .HasForeignKey(p => p.CedulaEst)
                .HasConstraintName("FK_Promedios_Estudiantes")
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
