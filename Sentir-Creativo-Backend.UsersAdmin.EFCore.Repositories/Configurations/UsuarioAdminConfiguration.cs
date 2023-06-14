using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.EFCore.Repositories.Configurations;

public class UsuarioAdminConfiguration : IEntityTypeConfiguration<UsuarioAdmin>
{
    public void Configure(EntityTypeBuilder<UsuarioAdmin> builder)
    {
        builder.ToTable("useradmins");
                        
        builder.HasKey(p => p.Id).HasName("id");
        builder.Property(p => p.Nombre).HasColumnName("nombre").IsRequired().HasMaxLength(80);
        builder.Property(p => p.Apellidos).HasColumnName("apellidos").IsRequired().HasMaxLength(80);
        builder.Property(p => p.PrevisionId).HasColumnName("prevision").IsRequired();
        builder.Property(p => p.ModoId).HasColumnName("modo").IsRequired();
        builder.Property(p => p.AfpId).HasColumnName("afp").IsRequired();
        builder.Property(p => p.CategoriaId).HasColumnName("categoria").IsRequired();
        builder.Property(p => p.CuentaBancariaId).HasColumnName("cuenta_bancaria").IsRequired();
        builder.Property(p => p.ValidaDocumento).HasColumnName("valida_documento").IsRequired();
        builder.Property(p => p.TipoDocumento).HasColumnName("tipo_documento").IsRequired().HasMaxLength(20);
        builder.Property(p => p.NumDocumento).HasColumnName("num_documento").IsRequired().HasMaxLength(30);
        builder.Property(p => p.FechaInicio).HasColumnName("fecha_inicio").IsRequired();
        builder.Property(p => p.FechaPago).HasColumnName("fecha_pago").IsRequired();
        builder.Property(p => p.FechaFin).HasColumnName("fecha_fin");
        builder.Property(p => p.SueldoBruto).HasColumnName("sueldo_bruto").IsRequired();
        builder.Property(p => p.EstadoId).HasColumnName("estado").IsRequired();
        builder.Property(p => p.Email).HasColumnName("email").IsRequired().HasMaxLength(256);
        builder.Property(p => p.Password).HasColumnName("password").IsRequired().HasMaxLength(256);
        builder.Property(p => p.Direccion).HasColumnName("direccion").HasMaxLength(1024);
        builder.Property(p => p.ComunaId).HasColumnName("comuna").IsRequired();
        builder.Property(p => p.RegionId).HasColumnName("region").IsRequired();
        builder.Property(p => p.PaisId).HasColumnName("pais").IsRequired();
        builder.Property(p => p.CreatedAt).HasColumnName("created_at");
        builder.Property(p => p.PublishedAt).HasColumnName("published_at");
        builder.Property(p => p.UpdatedAt).HasColumnName("updated_at");
        builder.Property(p => p.CreatedBy).HasColumnName("created_by");
        builder.Property(p => p.UpdatedBy).HasColumnName("updated_by");
        builder.Property(p => p.Activo).HasColumnName("activo");
        
        //relaciones
        builder.HasOne(u => u.Modo)
            .WithOne()
            .HasForeignKey<UsuarioAdmin>("ModoId");
        
        builder.HasOne(u => u.Categoria)
            .WithOne()
            .HasForeignKey<UsuarioAdmin>("CategoriaId");
        
        builder.HasOne(u => u.Prevision)
            .WithOne()
            .HasForeignKey<UsuarioAdmin>("PrevisionId");

        builder.HasOne(u => u.Afp)
            .WithOne()
            .HasForeignKey<UsuarioAdmin>("AfpId");

        builder.HasOne(u => u.CuentaBancaria)
            .WithOne()
            .HasForeignKey<UsuarioAdmin>("CuentaBancariaId");
        
        builder.HasOne(u => u.Estado)
            .WithOne()
            .HasForeignKey<UsuarioAdmin>("EstadoId");



        
    }
}