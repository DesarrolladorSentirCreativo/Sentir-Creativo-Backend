using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.EFCore.Repositories.Configurations;

public class UsuarioAcuerdoConfiguration : IEntityTypeConfiguration<UsuarioAcuerdo>
{
    public void Configure(EntityTypeBuilder<UsuarioAcuerdo> builder)
    {
        builder.ToTable("useradmins_acuerdos");
        
        builder.HasKey(p => p.Id).HasName("id");
        builder.Property(p => p.UsuarioId).HasColumnName("usuario");
        builder.Property(p => p.AcuerdoId).HasColumnName("acuerdo");

        builder.HasOne(u => u.Usuario)
            .WithOne()
            .HasForeignKey<UsuarioAcuerdo>("UsuarioId");
        
        builder.HasOne(u => u.Acuerdo)
            .WithOne()
            .HasForeignKey<UsuarioAcuerdo>("AcuerdoId");
    }
}