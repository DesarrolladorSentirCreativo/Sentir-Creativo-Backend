using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sentir_Creativo_Backend.Difusiones.Entities.POCOEntities;

namespace Sentir_Cretivo_Backend.Difusiones.EFCore.Repositories.Configuraciones;

public class PlataformaConfiguration : IEntityTypeConfiguration<Plataforma>
{
    public void Configure(EntityTypeBuilder<Plataforma> builder)
    {
        builder.ToTable("plataformas");
        
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