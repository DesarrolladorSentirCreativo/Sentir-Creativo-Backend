using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.EFCore.Repositories.Configurations;

public class AccesoConfiguration : IEntityTypeConfiguration<Acceso>
{
    public void Configure(EntityTypeBuilder<Acceso> builder)
    {
        builder.ToTable("accesos");
                        
        builder.HasKey(p => p.Id).HasName("id");
        builder.Property(p => p.ColeccionId).HasColumnName("coleccion").IsRequired();
        builder.Property(p => p.Crear).HasColumnName("crear").IsRequired();
        builder.Property(p => p.Actualizar).HasColumnName("actualizar").IsRequired();
        builder.Property(p => p.Eliminar).HasColumnName("eliminar").IsRequired();
        builder.Property(p => p.Listar).HasColumnName("listar").IsRequired();
        builder.Property(p => p.Ver).HasColumnName("ver").IsRequired();
        builder.Property(p => p.CreatedAt).HasColumnName("created_at");
        builder.Property(p => p.UpdatedAt).HasColumnName("updated_at");
        builder.Property(p => p.CreatedBy).HasColumnName("created_by");
        builder.Property(p => p.UpdatedBy).HasColumnName("updated_by");
        builder.Property(p => p.Activo).HasColumnName("activo");
        
        builder.HasOne(u => u.Coleccion)
            .WithOne()
            .HasForeignKey<Acceso>("ColeccionId");
    }
}