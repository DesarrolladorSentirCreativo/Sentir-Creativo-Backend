using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.POCOEntities;

namespace Sentir_Creativo_Backend.Audiencias.EFCore.Repositories.Configurations;

public class AudienciaPublicoObjetivoConfiguration : IEntityTypeConfiguration<AudienciaPublicoObjetivo>
{
    public void Configure(EntityTypeBuilder<AudienciaPublicoObjetivo> builder)
    {
        builder.ToTable("audiencias__publico_objetivos");
        
        builder.HasKey(p => p.Id).HasName("id");
        builder.Property(p => p.AudienciaId).HasColumnName("audiencia_id");
        builder.Property(p => p.PublicoObjetivoId).HasColumnName("publico_objetivo_id");

        builder.HasOne(u => u.Audiencia)
            .WithOne()
            .HasForeignKey<AudienciaPublicoObjetivo>("AudienciaId");
        
        builder.HasOne(u => u.PublicoObjetivo)
            .WithOne()
            .HasForeignKey<AudienciaPublicoObjetivo>("PublicoObjetivoId");
    }
}