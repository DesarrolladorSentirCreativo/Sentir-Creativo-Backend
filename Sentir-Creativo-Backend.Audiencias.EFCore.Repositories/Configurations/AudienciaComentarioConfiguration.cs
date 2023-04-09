using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.POCOEntities;

namespace Sentir_Creativo_Backend.Audiencias.EFCore.Repositories.Configurations;

public class AudienciaComentarioConfiguration : IEntityTypeConfiguration<AudienciaComentario>
{
    public void Configure(EntityTypeBuilder<AudienciaComentario> builder)
    {
        builder.ToTable("audiencias__comentarios");
        
        builder.HasKey(p => p.Id).HasName("id");
        builder.Property(p => p.AudienciaId).HasColumnName("audiencia_id");
        builder.Property(p => p.ComentarioId).HasColumnName("comentario_id");
        builder.Property(p => p.Activo).HasColumnName("activo");
            
        builder.HasOne(u => u.Audiencia)
            .WithOne()
            .HasForeignKey<AudienciaComentario>("AudienciaId");
        
        builder.HasOne(u => u.Comentario)
            .WithOne()
            .HasForeignKey<AudienciaComentario>("ComentarioId");
    }
}