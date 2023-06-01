using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.EFCore.Repositories.Configurations;

public class PrivilegioConfiguration : IEntityTypeConfiguration<Privilegio>
{
    public void Configure(EntityTypeBuilder<Privilegio> builder)
    {
        builder.ToTable("privilegios");
                        
        builder.HasKey(p => p.Id).HasName("id");
        builder.Property(p => p.Nombre).HasColumnName("nombre").IsRequired().HasMaxLength(50);
        builder.Property(p => p.CategoriaId).HasColumnName("categoria").IsRequired();
        builder.Property(p => p.Descripcion).HasColumnName("descripcion").HasMaxLength(1024);
        builder.Property(p => p.CreatedAt).HasColumnName("created_at");
        builder.Property(p => p.UpdatedAt).HasColumnName("updated_at");
        builder.Property(p => p.CreatedBy).HasColumnName("created_by");
        builder.Property(p => p.UpdatedBy).HasColumnName("updated_by");
        builder.Property(p => p.Activo).HasColumnName("activo");
        
        builder.HasOne(u => u.Categoria)
            .WithOne()
            .HasForeignKey<Privilegio>("CategoriaId");
    }
}