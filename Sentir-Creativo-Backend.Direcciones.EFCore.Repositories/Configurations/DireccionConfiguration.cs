using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sentir_Creativo_Backend.Direcciones.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.Direcciones.EFCore.Repositories.Configurations;

public class DireccionConfiguration : IEntityTypeConfiguration<Direccion>
{
    public void Configure(EntityTypeBuilder<Direccion> builder)
    {
        builder.ToTable("direcciones");
                                
        builder.HasKey(p => p.Id).HasName("id");
        builder.Property(p => p.PaisId).HasColumnName("pais");
        builder.Property(p => p.RegionId).HasColumnName("region");
        builder.Property(p => p.CiudadId).HasColumnName("ciudad");
        builder.Property(p => p.Activo).HasColumnName("activo");
          
        builder.HasOne(u => u.Pais)
            .WithOne()
            .HasForeignKey<Direccion>("PaisId");
        
        builder.HasOne(u => u.Region)
            .WithOne()
            .HasForeignKey<Direccion>("RegionId");
        
        builder.HasOne(u => u.Ciudad)
            .WithOne()
            .HasForeignKey<Direccion>("CiudadId");
    }
}