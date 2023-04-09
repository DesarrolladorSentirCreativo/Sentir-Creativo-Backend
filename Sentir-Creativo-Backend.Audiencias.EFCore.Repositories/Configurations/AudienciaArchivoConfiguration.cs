using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.POCOEntities;

namespace Sentir_Creativo_Backend.Audiencias.EFCore.Repositories.Configurations;

public class AudienciaArchivoConfiguration : IEntityTypeConfiguration<AudienciaArchivo>
{
    public void Configure(EntityTypeBuilder<AudienciaArchivo> builder)
    {
        builder.ToTable("audiencias__archivos");
        
        builder.HasKey(p => p.Id).HasName("id");
        builder.Property(p => p.AudienciaId).HasColumnName("audiencia_id");
        builder.Property(p => p.ArchivoId).HasColumnName("archivo_id");
            
        builder.HasOne(u => u.Audiencia)
            .WithOne()
            .HasForeignKey<AudienciaArchivo>("AudienciaId");
        
        builder.HasOne(u => u.Archivo)
            .WithOne()
            .HasForeignKey<AudienciaArchivo>("ArchivoId");
    }
}