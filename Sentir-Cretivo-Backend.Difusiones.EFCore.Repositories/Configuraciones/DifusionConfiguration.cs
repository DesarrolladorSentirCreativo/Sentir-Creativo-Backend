using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sentir_Creativo_Backend.Difusiones.Entities.POCOEntities;

namespace Sentir_Cretivo_Backend.Difusiones.EFCore.Repositories.Configuraciones;

public class DifusionConfiguration : IEntityTypeConfiguration<Difusion>
{
    public void Configure(EntityTypeBuilder<Difusion> builder)
    {
        builder.ToTable("difusions");
        
        builder.HasKey(p => p.Id).HasName("id");
        builder.Property(p => p.Nombre).HasMaxLength(255).HasColumnName("nombre");
        builder.Property(p=> p.Descripcion).HasColumnName("descripcion");
        builder.Property(p => p.PlataformaId).HasColumnName("plataforma");
        builder.Property(p => p.CuponDescuentoId).HasColumnName("cuponDescuento");
        builder.Property(p => p.ColeccionId).HasColumnName("coleccion");
        builder.Property(p => p.Slogan).HasColumnName("Slogan");
        builder.Property(p => p.Asunto).HasColumnName("Asunto");
        builder.Property(p => p.PreHeader).HasColumnName("PreHeader");
        builder.Property(p => p.PlantillaId).HasColumnName("plantilla");
        builder.Property(p => p.Activo).HasColumnName("activo");
        builder.Property(p => p.PublishedAt).HasColumnName("published_at");
        builder.Property(p => p.CreatedAt).HasColumnName("created_at");
        builder.Property(p => p.UpdatedAt).HasColumnName("updated_at");
        builder.Property(p => p.CreatedBy).HasColumnName("created_by");
        builder.Property(p => p.UpdatedBy).HasColumnName("updated_by");
            
        builder.HasOne(u => u.Plantilla)
            .WithOne()
            .HasForeignKey<Difusion>("PlantillaId");
        
        builder.HasOne(u => u.Coleccion)
            .WithOne()
            .HasForeignKey<Difusion>("ColeccionId");
        
        builder.HasOne(u => u.Plataforma)
            .WithOne()
            .HasForeignKey<Difusion>("PlataformaId");
        
        builder.HasOne(u => u.CuponDescuento)
            .WithOne()
            .HasForeignKey<Difusion>("CuponDescuentoId");
    }
}