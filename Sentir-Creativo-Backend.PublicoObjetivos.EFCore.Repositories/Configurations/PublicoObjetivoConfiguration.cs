using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sentir_Creativo_Backend.PublicoObjetivos.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.PublicoObjetivos.EFCore.Repositories.Configurations;

public class PublicoObjetivoConfiguration : IEntityTypeConfiguration<PublicoObjetivo>
{
    public void Configure(EntityTypeBuilder<PublicoObjetivo> builder)
    {
        builder.ToTable("cupon_descuentos");
        
        builder.HasKey(p => p.Id).HasName("id");
        builder.Property(p => p.Nombre).HasMaxLength(255).HasColumnName("nombre");
        builder.Property(p => p.PublishedAt).HasColumnName("published_at");
        builder.Property(p => p.CreatedAt).HasColumnName("created_at");
        builder.Property(p => p.UpdatedAt).HasColumnName("updated_at");
        builder.Property(p => p.CreatedBy).HasColumnName("created_by");
        builder.Property(p => p.UpdatedBy).HasColumnName("updated_by");
        builder.Property(p => p.Activo).HasColumnName("activo");
    }
}