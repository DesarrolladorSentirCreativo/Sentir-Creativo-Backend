namespace Sentir_Creativo_Backend.Servicios.EFCore.Repositories.Configurations;

public class FormatoConfiguration : IEntityTypeConfiguration<Formato>
{
    public void Configure(EntityTypeBuilder<Formato> builder)
    {
        builder.ToTable("formatoes");
        
        builder.HasKey(p => p.Id).HasName("id");
        builder.Property(p => p.Nombre).IsRequired().HasMaxLength(255).HasColumnName("nombre");
        builder.Property(p => p.PublishedAt).HasColumnName("published_at");
        builder.Property(p => p.CreatedAt).HasColumnName("created_at");
        builder.Property(p => p.UpdatedAt).HasColumnName("updated_at");
        builder.Property(p => p.CreatedBy).HasColumnName("created_by");
        builder.Property(p => p.UpdatedBy).HasColumnName("updated_by");
        builder.Property(p => p.Activo).HasColumnName("activo");
    }
}