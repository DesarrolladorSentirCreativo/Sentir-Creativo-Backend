using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.EFCore.Repositories.Configurations;

public class CuentaBancariaConfiguration : IEntityTypeConfiguration<CuentaBancaria>
{
    public void Configure(EntityTypeBuilder<CuentaBancaria> builder)
    {
        builder.ToTable("cuentas_bancarias");
                        
        builder.HasKey(p => p.Id).HasName("id");
        builder.Property(p => p.Banco).HasColumnName("banco").IsRequired().HasMaxLength(80);
        builder.Property(p => p.TipoCuenta).HasColumnName("tipo_cuenta").HasMaxLength(20);
        builder.Property(p => p.NumCuenta).HasColumnName("num_cuenta").HasMaxLength(60);
        builder.Property(p => p.CreatedAt).HasColumnName("created_at");
        builder.Property(p => p.PublishedAt).HasColumnName("published_at");
        builder.Property(p => p.UpdatedAt).HasColumnName("updated_at");
        builder.Property(p => p.CreatedBy).HasColumnName("created_by");
        builder.Property(p => p.UpdatedBy).HasColumnName("updated_by");
        builder.Property(p => p.Activo).HasColumnName("activo");
    }
}