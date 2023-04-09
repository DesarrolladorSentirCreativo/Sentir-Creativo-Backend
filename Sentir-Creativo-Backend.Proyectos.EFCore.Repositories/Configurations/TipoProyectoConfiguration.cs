using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sentir_Creativo_Backend.Proyectos.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.Proyectos.EFCore.Repositories.Configurations;

public class TipoProyectoConfiguration : IEntityTypeConfiguration<TipoProyecto>
{
    public void Configure(EntityTypeBuilder<TipoProyecto> builder)
    {
         builder.ToTable("tipo_proyectos");
                
         builder.HasKey(p => p.Id).HasName("id");
         builder.Property(p => p.Nombre).HasMaxLength(255).HasColumnName("nombre");
         builder.Property(p => p.Icon).HasMaxLength(255).HasColumnName("icon");
         builder.Property(p => p.AreaId).HasColumnName("area");
         builder.Property(p => p.Activo).IsRequired().HasColumnName("activo");
         builder.Property(p => p.PublishedAt).HasColumnName("published_at");
         builder.Property(p => p.CreatedAt).HasColumnName("created_at");
         builder.Property(p => p.UpdatedAt).HasColumnName("updated_at");
         builder.Property(p => p.CreatedBy).HasColumnName("created_by");
         builder.Property(p => p.UpdatedBy).HasColumnName("updated_by");
         builder.Property(p => p.Activo).HasColumnName("activo");
         
          
         builder.HasOne(u => u.Area)
             .WithOne()
             .HasForeignKey<TipoProyecto>("AreaId");
    }
}