using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.POCOEntities;

namespace Sentir_Creativo_Backend.Audiencias.EFCore.Repositories.Configurations;

public class AudienciaOrganizacionConfiguration : IEntityTypeConfiguration<AudienciaOrganizacion>
{
    public void Configure(EntityTypeBuilder<AudienciaOrganizacion> builder)
    {
        builder.ToTable("audiencias_organizaciones");
        
        builder.HasKey(p => p.Id).HasName("id");
        builder.Property(p => p.AudienciaId).HasColumnName("audiencia");
        builder.Property(p => p.OrganizacionId).HasColumnName("organizacion");

        builder.HasOne(u => u.Audiencia)
            .WithOne()
            .HasForeignKey<AudienciaOrganizacion>("AudienciaId");
        
        builder.HasOne(u => u.Organizacion)
            .WithOne()
            .HasForeignKey<AudienciaOrganizacion>("OrganizacionId");
    }
}