using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sentir_Creativo_Backend.Areas.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.Areas.EFCore.Repositories.Configurations;

public class AreaConfiguration : IEntityTypeConfiguration<Area>
{
    public void Configure(EntityTypeBuilder<Area> builder)
    {
        builder.ToTable("areas");
        
        builder.HasKey(p => p.Id).HasName("id");
        builder.Property(p => p.Nombre).HasMaxLength(255).HasColumnName("nombre");
        builder.Property(p => p.Icono).HasMaxLength(255).HasColumnName("icono");
        builder.Property(p => p.Descripcion).HasMaxLength(255).HasColumnName("description");
        builder.Property(p => p.ColorPrimario).HasMaxLength(255).HasColumnName("colorPrimario");
        builder.Property(p => p.ColorSecundario).HasMaxLength(255).HasColumnName("colorSecundario");
        builder.Property(p=> p.Focus).HasMaxLength(255).HasColumnName("focus");
        builder.Property(p => p.Prioridad).HasColumnName("prioridad");
        builder.Property(p => p.Activo).IsRequired().HasColumnName("activo");
        builder.Property(p => p.PublishedAt).HasColumnName("published_at");
        builder.Property(p => p.CreatedAt).HasColumnName("created_at");
        builder.Property(p => p.UpdatedAt).HasColumnName("updated_at");
        builder.Property(p => p.CreatedBy).HasColumnName("created_by");
        builder.Property(p => p.UpdatedBy).HasColumnName("updated_by");
        builder.Property(p => p.Activo).HasColumnName("activo");
    }
}