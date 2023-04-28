using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sentir_Creativo_Backend.Direcciones.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.Direcciones.EFCore.Repositories.Configurations;

public class PaisConfiguration : IEntityTypeConfiguration<Pais>
{
    public void Configure(EntityTypeBuilder<Pais> builder)
    {
         builder.ToTable("pais");
                        
         builder.HasKey(p => p.Id).HasName("id");
         builder.Property(p => p.Nombre).IsRequired().HasMaxLength(255).HasColumnName("nombre");
    }
}