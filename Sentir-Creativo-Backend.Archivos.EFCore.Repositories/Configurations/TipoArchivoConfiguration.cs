using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sentir_Creativo_Backend.Archivos.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.Archivos.EFCore.Repositories.Configurations;

public class TipoArchivoConfiguration : IEntityTypeConfiguration<TipoArchivo>
{
    public void Configure(EntityTypeBuilder<TipoArchivo> builder)
    {
        builder.ToTable("tipo_archivos");
        
        builder.HasKey(p => p.Id).HasName("id");
        builder.Property(p => p.Nombre).HasMaxLength(255).IsRequired().HasColumnName("nombre");
        builder.Property(p => p.PublishedAt).HasColumnName("published_at");
        builder.Property(p => p.CreatedAt).HasColumnName("created_at");
        builder.Property(p => p.UpdatedAt).HasColumnName("updated_at");
        builder.Property(p => p.CreatedBy).HasColumnName("created_by");
        builder.Property(p => p.UpdatedBy).HasColumnName("updated_by");
        builder.Property(p => p.Activo).HasColumnName("activo");
    }
}