using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.EFCore.Repositories.Configurations;

public class UsuarioComentarioConfiguration : IEntityTypeConfiguration<UsuarioComentario>
{
    public void Configure(EntityTypeBuilder<UsuarioComentario> builder)
    {
        builder.ToTable("useradmins_comentarios");
        
        builder.HasKey(p => p.Id).HasName("id");
        builder.Property(p => p.UsuarioId).HasColumnName("usuario");
        builder.Property(p => p.ComentarioId).HasColumnName("comentario");

        builder.HasOne(u => u.Usuario)
            .WithOne()
            .HasForeignKey<UsuarioComentario>("UsuarioId");
        
        builder.HasOne(u => u.Comentario)
            .WithOne()
            .HasForeignKey<UsuarioComentario>("ComentarioId");
    }
}