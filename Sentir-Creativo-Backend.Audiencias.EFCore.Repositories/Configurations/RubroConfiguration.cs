using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sentir_Creativo_Backend.Audiencias.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.Audiencias.EFCore.Repositories.Configurations;

public class RubroConfiguration: IEntityTypeConfiguration<Rubro>
{
    public void Configure(EntityTypeBuilder<Rubro> builder)
    {
        builder.ToTable("rubros");
        
        builder.HasKey(p => p.Id).HasName("id");
        builder.Property(p => p.Nombre).HasMaxLength(255).HasColumnName("nombre");
        builder.Property(p => p.EmailGroup).HasMaxLength(255).HasColumnName("emailGroup");
        builder.Property(p => p.Icon).HasMaxLength(255).HasColumnName("icon");
        builder.Property(p => p.Color).HasMaxLength(255).HasColumnName("color");
        builder.Property(p => p.Image).HasMaxLength(255).HasColumnName("image");
        builder.Property(p => p.Prioridad).HasMaxLength(255).HasColumnName("prioridad");
        builder.Property(p => p.TipoRubroId).HasColumnName("tipo_rubro");
        builder.Property(p => p.PublishedAt).HasColumnName("published_at");
        builder.Property(p => p.CreatedAt).HasColumnName("created_at");
        builder.Property(p => p.UpdatedAt).HasColumnName("updated_at");
        builder.Property(p => p.CreatedBy).HasColumnName("created_by");
        builder.Property(p => p.UpdatedBy).HasColumnName("updated_by");
        
        builder.HasOne(u => u.TipoRubro)
            .WithOne()
            .HasForeignKey<Rubro>("TipoRubroId");
    }
}