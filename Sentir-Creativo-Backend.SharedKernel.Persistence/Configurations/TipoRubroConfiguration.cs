using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sentir_Creativo_Backend.Audiencias.Domain.Entities;

namespace Sentir_Creativo_Backend.SharedKernel.Persistence.Configurations;

public class TipoRubroConfiguration : IEntityTypeConfiguration<TipoRubro>
{
    public void Configure(EntityTypeBuilder<TipoRubro> builder)
    {
        builder.ToTable("tipo_rubros");
                
        builder.HasKey(p => p.Id).HasName("id");
        builder.Property(p => p.Nombre).HasMaxLength(255).HasColumnName("nombre");
        builder.Property(p => p.PublishedAt).HasColumnName("published_at");
        builder.Property(p => p.CreatedAt).HasColumnName("created_at");
        builder.Property(p => p.UpdatedAt).HasColumnName("updated_at");
        builder.Property(p => p.CreatedBy).HasColumnName("created_by");
        builder.Property(p => p.UpdatedBy).HasColumnName("updated_by");
        
        builder.HasMany(p => p.Rubros)
            .WithOne(p => p.TipoRubro)
            .HasForeignKey(p => p.TipoRubroId);
    }
}