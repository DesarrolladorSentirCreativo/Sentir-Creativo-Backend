using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sentir_Creativo_Backend.Colecciones.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.Colecciones.EFCore.Repositories.Configurations;

public class ColeccionConfiguration : IEntityTypeConfiguration<Coleccion>
{
    public void Configure(EntityTypeBuilder<Coleccion> builder)
    {
        builder.ToTable("coleccions");
                
        builder.HasKey(p => p.Id).HasName("id");
        builder.Property(p => p.Nombre).IsRequired().HasMaxLength(255).HasColumnName("nombre");
        builder.Property(p => p.Descripcion).HasColumnName("descripcion");
        builder.Property(p => p.Activo).IsRequired().HasColumnName("activo");
        builder.Property(p => p.PublishedAt).HasColumnName("published_at");
        builder.Property(p => p.CreatedAt).HasColumnName("created_at");
        builder.Property(p => p.UpdatedAt).HasColumnName("updated_at");
        builder.Property(p => p.CreatedBy).HasColumnName("created_by");
        builder.Property(p => p.UpdatedBy).HasColumnName("updated_by");
        builder.Property(p => p.Activo).HasColumnName("activo");
    }
}