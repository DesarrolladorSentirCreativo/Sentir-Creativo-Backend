using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Senitr_Creativo_Backend.Comentarios.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.Comentarios.EFCore.Repositories.Configurations;

public class ComentarioConfiguration : IEntityTypeConfiguration<Comentario>
{
    public void Configure(EntityTypeBuilder<Comentario> builder)
    {
        builder.ToTable("comentarios");
        
        builder.HasKey(p => p.Id).HasName("id");
        builder.Property(p => p.Descripcion).HasColumnName("comentario");
        builder.Property(p => p.PublishedAt).HasColumnName("published_at");
        builder.Property(p => p.CreatedAt).HasColumnName("created_at");
        builder.Property(p => p.UpdatedAt).HasColumnName("updated_at");
        builder.Property(p => p.CreatedBy).HasColumnName("created_by");
        builder.Property(p => p.UpdatedBy).HasColumnName("updated_by");
        
        builder.HasOne(u => u.User)
            .WithOne()
            .HasForeignKey<Comentario>("CreatedBy");
    }
}