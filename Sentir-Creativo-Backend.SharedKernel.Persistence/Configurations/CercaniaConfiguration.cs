using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sentir_Creativo_Backend.Audiencias.Domain.Entities;

namespace Sentir_Creativo_Backend.SharedKernel.Persistence.Configurations;

public class CercaniaConfiguration : IEntityTypeConfiguration<Cercania>
{
    public void Configure(EntityTypeBuilder<Cercania> builder)
    {
        builder.ToTable("cercanias");
        
        builder.HasKey(p => p.Id).HasName("id");
        builder.Property(p => p.Nombre).HasMaxLength(80).IsRequired().HasColumnName("nombre");
        builder.Property(p => p.PublishedAt).HasColumnName("published_at");
        builder.Property(p => p.CreatedAt).HasColumnName("created_at");
        builder.Property(p => p.UpdatedAt).HasColumnName("updated_at");
        builder.Property(p => p.CreatedBy).HasColumnName("created_by");
        builder.Property(p => p.UpdatedBy).HasColumnName("updated_by");
        
        builder.HasMany(p => p.Audiencias)
            .WithOne(p => p.Cercania)
            .HasForeignKey(p => p.CercaniaId);
    }
}