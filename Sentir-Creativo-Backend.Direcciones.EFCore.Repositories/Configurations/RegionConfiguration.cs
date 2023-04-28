using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sentir_Creativo_Backend.Direcciones.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.Direcciones.EFCore.Repositories.Configurations;

public class RegionConfiguration : IEntityTypeConfiguration<Region>
{
    public void Configure(EntityTypeBuilder<Region> builder)
    {
          builder.ToTable("regions");
                                
          builder.HasKey(p => p.Id).HasName("id");
          builder.Property(p => p.Nombre).IsRequired().HasMaxLength(255).HasColumnName("nombre");
          builder.Property(p => p.PaisId).HasColumnName("pais");
          
          builder.HasOne(u => u.Pais)
              .WithOne()
              .HasForeignKey<Region>("PaisId");
    }
}