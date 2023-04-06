using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sentir_Creativo_Backend.Audiencias.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.Audiencias.EFCore.Repositories.Configurations;

public class PrefijoConfiguration:IEntityTypeConfiguration<Prefijo>
{
    public void Configure(EntityTypeBuilder<Prefijo> builder)
    {
        builder.ToTable("prefijos");
        
        builder.HasKey(p => p.Id).HasName("id");
        builder.Property(p => p.Nombre).HasMaxLength(50).IsRequired().HasColumnName("nombre");
        builder.Property(p => p.PublishedAt).HasColumnName("published_at");
        builder.Property(p => p.CreatedAt).HasColumnName("created_at");
        builder.Property(p => p.UpdatedAt).HasColumnName("updated_at");
        builder.Property(p => p.CreatedBy).HasColumnName("created_by");
        builder.Property(p => p.UpdatedBy).HasColumnName("updated_by");
        builder.Property(p => p.Activo).HasColumnName("activo");
        
        builder.HasMany(p => p.Audiencias)
            .WithOne(p => p.Prefijo)
            .HasForeignKey(p => p.PrefijoId);
    }
}