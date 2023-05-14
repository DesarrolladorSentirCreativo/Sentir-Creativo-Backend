using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Sentir_Creativo_Backend.Audiencias.EFCore.Repositories.Configurations;

public class AudienciaConfiguration :IEntityTypeConfiguration<Entities.POCOEntities.Audiencia>
{
    public void Configure(EntityTypeBuilder<Entities.POCOEntities.Audiencia> builder)
    {
        builder.ToTable("audiencias");
        
        builder.HasKey(p => p.Id).HasName("id");
        builder.Property(p => p.Nombre).HasMaxLength(200).HasColumnName("nombre");
        builder.Property(p => p.Email).HasMaxLength(255).HasColumnName("email");
        builder.Property(p => p.Celular).HasColumnName("celular").HasColumnType("bigint");
        builder.Property(p => p.MotivacionId).HasColumnName("motivacion");
        builder.Property(p => p.OrganizacionId).HasColumnName("organizacion");
        builder.Property(p => p.Departamento).HasMaxLength(255).HasColumnName("departamento");
        builder.Property(p => p.Cargo).HasMaxLength(255).HasColumnName("cargo");
        builder.Property(p => p.CercaniaId).HasColumnName("cercania");
        builder.Property(p => p.AntiguedadId).HasColumnName("antiguedad");
        builder.Property(p => p.PublishedAt).HasColumnName("published_at");
        builder.Property(p => p.CreatedAt).HasColumnName("created_at");
        builder.Property(p => p.UpdatedAt).HasColumnName("updated_at");
        builder.Property(p => p.CreatedBy).HasColumnName("created_by");
        builder.Property(p => p.UpdatedBy).HasColumnName("updated_by");
        builder.Property(p => p.Apellido).HasMaxLength(200).HasColumnName("apellido");
        builder.Property(p => p.Profesion).HasMaxLength(255).HasColumnName("profesion");
        builder.Property(p => p.EstadoId!).HasColumnName("estado");
        builder.Property(p => p.OrigenId).HasColumnName("origen");
        builder.Property(p => p.PrefijoId).HasColumnName("prefijo");
        builder.Property(p => p.Email2).HasMaxLength(255).HasColumnName("email2");
        builder.Property(p => p.DocumentoIdentidad).HasMaxLength(255).HasColumnName("documentoIdentidad");
        builder.Property(p => p.Destacado).HasColumnName("destacado");
        builder.Property(p => p.Activo).HasColumnName("activo");
        
        builder.HasOne(u => u.Cercania)
            .WithOne()
            .HasForeignKey<Entities.POCOEntities.Audiencia>("CercaniaId");
        
        builder.HasOne(u => u.EstadoAudiencia)
            .WithOne()
            .HasForeignKey<Entities.POCOEntities.Audiencia>("EstadoId");
        
        builder.HasOne(u => u.Antiguedad)
            .WithOne()
            .HasForeignKey<Entities.POCOEntities.Audiencia>("AntiguedadId");
        
        builder.HasOne(u => u.Motivacion)
            .WithOne()
            .HasForeignKey<Entities.POCOEntities.Audiencia>("MotivacionId");
        
        builder.HasOne(u => u.Cercania)
            .WithOne()
            .HasForeignKey<Entities.POCOEntities.Audiencia>("CercaniaId");
        
        builder.HasOne(u => u.Origen)
            .WithOne()
            .HasForeignKey<Entities.POCOEntities.Audiencia>("OrigenId");
        
        builder.HasOne(u => u.Prefijo)
            .WithOne()
            .HasForeignKey<Entities.POCOEntities.Audiencia>("PrefijoId");

    }
}