using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sentir_Creativo_Backend.Archivos.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.Archivos.EFCore.Repositories.Configurations;

public class ArchivoConfiguration : IEntityTypeConfiguration<Archivo>
{
    public void Configure(EntityTypeBuilder<Archivo> builder)
    {
        builder.ToTable("archivos");
        
        builder.HasKey(p => p.Id).HasName("id");
        builder.Property(p => p.Nombre).HasMaxLength(255).HasColumnName("nombre");
        builder.Property(p => p.Path).HasMaxLength(255).HasColumnName("path");
        builder.Property(p => p.Publico).HasColumnName("publico");
        builder.Property(p => p.Activo).IsRequired().HasColumnName("activo");
        builder.Property(p => p.TipoArchivoId).HasColumnName("tipo_archivo");
        builder.Property(p => p.PublishedAt).HasColumnName("published_at");
        builder.Property(p => p.CreatedAt).HasColumnName("created_at");
        builder.Property(p => p.UpdatedAt).HasColumnName("updated_at");
        builder.Property(p => p.CreatedBy).HasColumnName("created_by");
        builder.Property(p => p.UpdatedBy).HasColumnName("updated_by");
        builder.Property(p => p.Activo).HasColumnName("activo");
        
        builder.HasOne(u => u.TipoArchivo)
            .WithOne()
            .HasForeignKey<Archivo>("TipoArchivoId");
    }
}