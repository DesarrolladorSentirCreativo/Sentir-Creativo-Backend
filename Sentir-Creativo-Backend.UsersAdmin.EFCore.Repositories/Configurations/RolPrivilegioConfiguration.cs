using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.EFCore.Repositories.Configurations;

public class RolPrivilegioConfiguration : IEntityTypeConfiguration<RolPrivilegio>
{
    public void Configure(EntityTypeBuilder<RolPrivilegio> builder)
    {
        builder.ToTable("roles_privilegios");
                        
        builder.HasKey(p => p.Id).HasName("id");
        builder.Property(p => p.PrivilegioId).HasColumnName("privilegio").IsRequired();
        builder.Property(p => p.RolId).HasColumnName("rol").IsRequired();
        
        builder.HasOne(u => u.Rol)
            .WithOne()
            .HasForeignKey<RolPrivilegio>("RolId");
        
        builder.HasOne(u => u.Privilegio)
            .WithOne()
            .HasForeignKey<RolPrivilegio>("PrivilegioId");
    }
}