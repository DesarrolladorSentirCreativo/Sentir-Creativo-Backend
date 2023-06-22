using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.EFCore.Repositories.Configurations;

public class UsuarioRolConfiguration : IEntityTypeConfiguration<UsuarioRol>
{
    public void Configure(EntityTypeBuilder<UsuarioRol> builder)
    {
        builder.ToTable("useradmins_roles");
        
        builder.HasKey(p => p.Id).HasName("id");
        builder.Property(p => p.UsuarioId).HasColumnName("useradmin");
        builder.Property(p => p.RolId).HasColumnName("rol");

        builder.HasOne(u => u.Usuario)
            .WithOne()
            .HasForeignKey<UsuarioRol>("UsuarioId");
        
        builder.HasOne(u => u.Rol)
            .WithOne()
            .HasForeignKey<UsuarioRol>("RolId");
    }
}