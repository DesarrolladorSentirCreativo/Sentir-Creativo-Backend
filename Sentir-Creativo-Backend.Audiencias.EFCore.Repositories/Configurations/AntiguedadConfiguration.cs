using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sentir_Creativo_Backend.Audiencias.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.Audiencias.EFCore.Repositories.Configurations;

public class AntiguedadConfiguration : IEntityTypeConfiguration<Antiguedad>
{
    public void Configure(EntityTypeBuilder<Antiguedad> builder)
    {
        builder.ToTable("antiguedads");
        
        builder.HasKey(p => p.Id).HasName("id");
        builder.Property(p => p.Nombre).HasMaxLength(50).IsRequired().HasColumnName("nombre");
        builder.Property(p => p.PublishedAt).HasColumnName("published_at");
        builder.Property(p => p.CreatedAt).HasColumnName("created_at");
        builder.Property(p => p.UpdatedAt).HasColumnName("updated_at");
        builder.Property(p => p.CreatedBy).HasColumnName("created_by");
        builder.Property(p => p.UpdatedBy).HasColumnName("updated_by");
        
        builder.HasMany(p => p.Audiencias)
            .WithOne(p => p.Antiguedad)
            .HasForeignKey(p => p.AntiguedadId);
    }
}