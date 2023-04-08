using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sentir_Creativo_Backend.Bitacoras.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.Bitacoras.EFCore.Repositories.Configurations;

public class BitacoraConfiguration: IEntityTypeConfiguration<Bitacora>
{
    public void Configure(EntityTypeBuilder<Bitacora> builder)
    {
        builder.ToTable("bitacoras");
        
        builder.HasKey(p => p.Id).HasName("id");
        builder.Property(p => p.Entidad).HasColumnName("entidad").HasMaxLength(255);
        builder.Property(p => p.Accion).HasColumnName("accion").HasMaxLength(255);
        builder.Property(p => p.Autor).HasColumnName("autor");
        builder.Property(p => p.Contenido).HasColumnName("contenido");
        builder.Property(p => p.Via).HasColumnName("via").HasMaxLength(255);
        builder.Property(p => p.PublishedAt).HasColumnName("published_at");
        builder.Property(p => p.CreatedAt).HasColumnName("created_at");
        builder.Property(p => p.UpdatedAt).HasColumnName("updated_at");
        builder.Property(p => p.CreatedBy).HasColumnName("created_by");
        builder.Property(p => p.UpdatedBy).HasColumnName("updated_by");
        builder.Property(p => p.Fecha).HasColumnName("fecha");
    }
}
