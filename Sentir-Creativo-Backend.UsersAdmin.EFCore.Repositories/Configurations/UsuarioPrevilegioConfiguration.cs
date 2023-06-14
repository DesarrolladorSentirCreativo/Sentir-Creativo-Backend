using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.EFCore.Repositories.Configurations;

public class UsuarioPrevilegioConfiguration : IEntityTypeConfiguration<UsuarioPrivilegio>
{
    public void Configure(EntityTypeBuilder<UsuarioPrivilegio> builder)
    {
        builder.ToTable("useradmins_privilegios");
        
        builder.HasKey(p => p.Id).HasName("id");
        builder.Property(p => p.UsuarioId).HasColumnName("usuario");
        builder.Property(p => p.PrivilegioId).HasColumnName("privilegio");

        builder.HasOne(u => u.Usuario)
            .WithOne()
            .HasForeignKey<UsuarioPrivilegio>("UsuarioId");
        
        builder.HasOne(u => u.Privilegio)
            .WithOne()
            .HasForeignKey<UsuarioPrivilegio>("PrivilegioId");
    }
}