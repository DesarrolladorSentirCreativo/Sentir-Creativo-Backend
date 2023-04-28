using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sentir_Creativo_Backend.Direcciones.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.Direcciones.EFCore.Repositories.Configurations;

public class CiudadConfiguration : IEntityTypeConfiguration<Ciudad>
{
    public void Configure(EntityTypeBuilder<Ciudad> builder)
    {
         builder.ToTable("ciudads");
                                        
         builder.HasKey(p => p.Id).HasName("id");
         builder.Property(p => p.Nombre).IsRequired().HasMaxLength(255).HasColumnName("nombre");
         builder.Property(p => p.PaisId).HasColumnName("pais");
         builder.Property(p => p.RegionId).HasColumnName("region");
                  
         builder.HasOne(u => u.Pais)
             .WithOne()
             .HasForeignKey<Ciudad>("PaisId");
         
         builder.HasOne(u => u.Region)
             .WithOne()
             .HasForeignKey<Ciudad>("RegionId");
         
    }
}