using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sentir_Creativo_Backend.Proyectos.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.Proyectos.EFCore.Repositories.Configurations;

public class EstadoProyectoConfiguration : IEntityTypeConfiguration<EstadoProyecto>
{
    public void Configure(EntityTypeBuilder<EstadoProyecto> builder)
    {
        builder.ToTable("estado_proyectos");
                
        builder.HasKey(p => p.Id).HasName("id");
        builder.Property(p => p.Nombre).IsRequired().HasMaxLength(255).HasColumnName("nombre");
        builder.Property(p => p.Prioridad).HasColumnName("prioridad");
        builder.Property(p => p.Color).HasMaxLength(255).HasColumnName("color");
        builder.Property(p => p.Activo).IsRequired().HasColumnName("activo");
        builder.Property(p => p.PublishedAt).HasColumnName("published_at");
        builder.Property(p => p.CreatedAt).HasColumnName("created_at");
        builder.Property(p => p.UpdatedAt).HasColumnName("updated_at");
        builder.Property(p => p.CreatedBy).HasColumnName("created_by");
        builder.Property(p => p.UpdatedBy).HasColumnName("updated_by");
        builder.Property(p => p.Activo).HasColumnName("activo");
    }
}