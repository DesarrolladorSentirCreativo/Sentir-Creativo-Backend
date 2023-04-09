using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.POCOEntities;

namespace Sentir_Creativo_Backend.Audiencias.EFCore.Repositories.Configurations;

public class AudienciaCuponDescuentoConfiguration : IEntityTypeConfiguration<AudienciaCuponDescuento>
{
    public void Configure(EntityTypeBuilder<AudienciaCuponDescuento> builder)
    {
        builder.ToTable("audiencias__cupon_descuento");
        
        builder.HasKey(p => p.Id).HasName("id");
        builder.Property(p => p.AudienciaId).HasColumnName("audiencia_id");
        builder.Property(p => p.CuponDescuentoId).HasColumnName("cupon-descuento_id");
        builder.Property(p => p.Activo).HasColumnName("activo");
            
        builder.HasOne(u => u.Audiencia)
            .WithOne()
            .HasForeignKey<AudienciaCuponDescuento>("AudienciaId");

        builder.HasOne(u => u.CuponDescuento)
            .WithOne()
            .HasForeignKey<AudienciaCuponDescuento>("CuponDescuentoId");
    }
}