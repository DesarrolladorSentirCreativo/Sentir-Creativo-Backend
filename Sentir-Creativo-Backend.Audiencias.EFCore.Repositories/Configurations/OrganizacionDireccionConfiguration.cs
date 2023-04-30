using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.POCOEntities;

namespace Sentir_Creativo_Backend.Audiencias.EFCore.Repositories.Configurations;

public class OrganizacionDireccionConfiguration : IEntityTypeConfiguration<OrganizacionDireccion>
{
    public void Configure(EntityTypeBuilder<OrganizacionDireccion> builder)
    {
        builder.ToTable("organizaciones_direcciones");
        
        builder.HasKey(p => p.Id).HasName("id");
        builder.Property(p => p.OrganizacionId).HasColumnName("organizacion");
        builder.Property(p => p.DireccionId).HasColumnName("direccion");
        builder.Property(p => p.Predeterminada).HasColumnName("predeterninada");

        builder.HasOne(u => u.Organizacion)
            .WithOne()
            .HasForeignKey<OrganizacionDireccion>("OrganizacionId");
        
        builder.HasOne(u => u.Direccion)
            .WithOne()
            .HasForeignKey<OrganizacionDireccion>("DireccionId");
    }
}