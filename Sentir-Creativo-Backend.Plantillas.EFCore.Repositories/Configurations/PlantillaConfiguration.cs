using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sentir_Creativo_Backend.Plantillas.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.Plantillas.EFCore.Repositories.Configurations;

public class PlantillaConfiguration : IEntityTypeConfiguration<Plantilla>
{
    public void Configure(EntityTypeBuilder<Plantilla> builder)
    {
        builder.ToTable("plantillas");
                
        builder.HasKey(p => p.Id).HasName("id");
        builder.Property(p => p.Nombre).IsRequired().HasMaxLength(255).HasColumnName("nombre");
        builder.Property(p => p.Activo).IsRequired().HasColumnName("activo");
        builder.Property(p => p.PublishedAt).HasColumnName("published_at");
        builder.Property(p => p.CreatedAt).HasColumnName("created_at");
        builder.Property(p => p.UpdatedAt).HasColumnName("updated_at");
        builder.Property(p => p.CreatedBy).HasColumnName("created_by");
        builder.Property(p => p.UpdatedBy).HasColumnName("updated_by");
        builder.Property(p => p.Activo).HasColumnName("activo");
    }
}