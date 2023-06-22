using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.EFCore.Repositories.Configurations;

public class UsuarioArchivoConfiguration : IEntityTypeConfiguration<UsuarioArchivo>
{
    public void Configure(EntityTypeBuilder<UsuarioArchivo> builder)
    {
        builder.ToTable("useradmins_archivos");
        
        builder.HasKey(p => p.Id).HasName("id");
        builder.Property(p => p.UsuarioId).HasColumnName("useradmin");
        builder.Property(p => p.ArchivoId).HasColumnName("archivo");

        builder.HasOne(u => u.Usuario)
            .WithOne()
            .HasForeignKey<UsuarioArchivo>("UsuarioId");
        
        builder.HasOne(u => u.Archivo)
            .WithOne()
            .HasForeignKey<UsuarioArchivo>("ArchivoId");
    }
}