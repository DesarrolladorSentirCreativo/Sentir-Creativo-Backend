using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.EFCore.Repositories.Configurations;

public class PrivilegioAccesoConfiguration : IEntityTypeConfiguration<PrivilegioAcceso>
{
    public void Configure(EntityTypeBuilder<PrivilegioAcceso> builder)
    {
        builder.ToTable("privilegios_accesos");
                        
        builder.HasKey(p => p.Id).HasName("id");
        builder.Property(p => p.AccesoId).HasColumnName("acceso").IsRequired();
        builder.Property(p => p.PrivilegioId).HasColumnName("privilegio").IsRequired();
        
        builder.HasOne(u => u.Acceso)
            .WithOne()
            .HasForeignKey<PrivilegioAcceso>("AccesoId");
        
        builder.HasOne(u => u.Privilegio)
            .WithOne()
            .HasForeignKey<PrivilegioAcceso>("PrivilegioId");
    }
}