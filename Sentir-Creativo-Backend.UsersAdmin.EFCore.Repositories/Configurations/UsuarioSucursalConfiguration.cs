using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.EFCore.Repositories.Configurations;

public class UsuarioSucursalConfiguration : IEntityTypeConfiguration<UsuarioSucursal>
{
    public void Configure(EntityTypeBuilder<UsuarioSucursal> builder)
    {
        builder.ToTable("useradmins_sucursales");
        
        builder.HasKey(p => p.Id).HasName("id");
        builder.Property(p => p.UsuarioId).HasColumnName("useradmin");
        builder.Property(p => p.SucursalId).HasColumnName("sucursal");

        builder.HasOne(u => u.Usuario)
            .WithOne()
            .HasForeignKey<UsuarioSucursal>("UsuarioId");
        
        builder.HasOne(u => u.Sucursal)
            .WithOne()
            .HasForeignKey<UsuarioSucursal>("SucursalId");
    }
}