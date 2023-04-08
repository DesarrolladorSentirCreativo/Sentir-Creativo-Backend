using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.POCOEntities;

namespace Sentir_Creativo_Backend.Audiencias.EFCore.Repositories.Configurations;

public class BitacoraAudienciaConfiguration : IEntityTypeConfiguration<AudienciaBitacora>
{
    public void Configure(EntityTypeBuilder<AudienciaBitacora> builder)
    {
        builder.ToTable("audiencias__bitacoras");
        
        builder.HasKey(p => p.Id).HasName("id");
        builder.Property(p => p.AudienciaId).HasColumnName("audiencia_id");
        builder.Property(p => p.BitacoraId).HasColumnName("bitacora_id");
            
        builder.HasOne(u => u.Audiencia)
            .WithOne()
            .HasForeignKey<AudienciaBitacora>("AudienciaId");
        
        builder.HasOne(u => u.Bitacora)
            .WithOne()
            .HasForeignKey<AudienciaBitacora>("BitacoraId");
        
    }
}