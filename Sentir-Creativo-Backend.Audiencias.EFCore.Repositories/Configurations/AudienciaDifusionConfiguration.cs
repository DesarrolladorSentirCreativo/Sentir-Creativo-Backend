using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.POCOEntities;

namespace Sentir_Creativo_Backend.Audiencias.EFCore.Repositories.Configurations;

public class AudienciaDifusionConfiguration : IEntityTypeConfiguration<AudienciaDifusion>
{
    public void Configure(EntityTypeBuilder<AudienciaDifusion> builder)
    {
        builder.ToTable("audiencias_difusiones__difusions_audiencias");
        
        builder.HasKey(p => p.Id).HasName("id");
        builder.Property(p => p.AudienciaId).HasColumnName("audiencia_id");
        builder.Property(p => p.DifusionId).HasColumnName("difusion_id");
            
        builder.HasOne(u => u.Audiencia)
            .WithOne()
            .HasForeignKey<AudienciaDifusion>("AudienciaId");
        
        builder.HasOne(u => u.Difusion)
            .WithOne()
            .HasForeignKey<AudienciaDifusion>("DifusionId");
    }
}