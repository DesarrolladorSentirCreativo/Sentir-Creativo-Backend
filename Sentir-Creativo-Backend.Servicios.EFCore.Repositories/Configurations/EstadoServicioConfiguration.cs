using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sentir_Creativo_Backend.Servicios.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.Servicios.EFCore.Repositories.Configurations;

public class EstadoServicioConfiguration : IEntityTypeConfiguration<EstadoServicio>
{
    public void Configure(EntityTypeBuilder<EstadoServicio> builder)
    {
        builder.ToTable("estado_servicios");
        
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