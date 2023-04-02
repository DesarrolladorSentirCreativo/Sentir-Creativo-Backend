using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sentir_Creativo_Backend.Audiencias.Domain.Entities;

namespace Sentir_Creativo_Backend.SharedKernel.Persistence.Configurations;

public class OrganizacionConfiguration : IEntityTypeConfiguration<Organizacion>
{
    public void Configure(EntityTypeBuilder<Organizacion> builder)
    {
        builder.ToTable("organizacions");
                
        builder.HasKey(p => p.Id).HasName("id");
        builder.Property(p => p.Nombre).HasMaxLength(255).HasColumnName("nombre");
        builder.Property(p => p.Website).HasMaxLength(255).HasColumnName("website");
        builder.Property(p => p.Facebook).HasMaxLength(255).HasColumnName("facebook");
        builder.Property(p => p.Twitter).HasMaxLength(255).HasColumnName("twitter");
        builder.Property(p => p.Instagram).HasMaxLength(255).HasColumnName("instagram");
        builder.Property(p => p.Historial).HasMaxLength(255).HasColumnName("historial");
        builder.Property(p => p.RubroId).HasColumnName("rubro"); 
        builder.Property(p => p.Email).HasMaxLength(255).HasColumnName("email");
        builder.Property(p => p.Telefono).HasMaxLength(30).HasColumnName("telefono");
        builder.Property(p => p.PublishedAt).HasColumnName("published_at"); 
        builder.Property(p => p.CreatedAt).HasColumnName("created_at");
        builder.Property(p => p.UpdatedAt).HasColumnName("updated_at");
        builder.Property(p => p.CreatedBy).HasColumnName("created_by");
        builder.Property(p => p.UpdatedBy).HasColumnName("updated_by");
        
        builder.HasMany(p => p.Audiencias)
            .WithOne(p => p.Organizacion)
            .HasForeignKey(p => p.OrganizacionId);
    }
}