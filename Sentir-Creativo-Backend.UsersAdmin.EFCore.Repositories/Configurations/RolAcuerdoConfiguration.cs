using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.EFCore.Repositories.Configurations;

public class RolAcuerdoConfiguration : IEntityTypeConfiguration<RolAcuerdo>
{
    public void Configure(EntityTypeBuilder<RolAcuerdo> builder)
    {
        builder.ToTable("roles_acuerdos");
                        
        builder.HasKey(p => p.Id).HasName("id");
        builder.Property(p => p.AcuerdoId).HasColumnName("acuerdo").IsRequired();
        builder.Property(p => p.RolId).HasColumnName("rol").IsRequired();
        
        builder.HasOne(u => u.Rol)
            .WithOne()
            .HasForeignKey<RolAcuerdo>("RolId");
        
        builder.HasOne(u => u.Acuerdo)
            .WithOne()
            .HasForeignKey<RolAcuerdo>("AcuerdoId");
    }
}