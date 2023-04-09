using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sentir_Creativo_Backend.CuponDescuentos.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.CuponDescuentos.EFCore.Repositories.Configurations;

public class CuponDescuentoConfiguration : IEntityTypeConfiguration<CuponDescuento>
{
    public void Configure(EntityTypeBuilder<CuponDescuento> builder)
    {
        builder.ToTable("cupon_descuentos");
        
        builder.HasKey(p => p.Id).HasName("id");
        builder.Property(p => p.Codigo).HasMaxLength(20).HasColumnName("Codigo");
        builder.Property(p => p.Descripcion).HasColumnName("descripcion");
        builder.Property(p => p.FechaInicio).HasColumnName("fechaInicio");
        builder.Property(p => p.FechaFin).HasColumnName("fechaFin");
        builder.Property(p => p.PublishedAt).HasColumnName("published_at");
        builder.Property(p => p.CreatedAt).HasColumnName("created_at");
        builder.Property(p => p.UpdatedAt).HasColumnName("updated_at");
        builder.Property(p => p.CreatedBy).HasColumnName("created_by");
        builder.Property(p => p.UpdatedBy).HasColumnName("updated_by");
        builder.Property(p => p.Activo).HasColumnName("activo");
    }
}