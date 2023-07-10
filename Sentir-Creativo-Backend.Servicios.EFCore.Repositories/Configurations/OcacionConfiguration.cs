namespace Sentir_Creativo_Backend.Servicios.EFCore.Repositories.Configurations
{
    public class OcacionConfiguration : IEntityTypeConfiguration<Ocacion>
    {
        public void Configure(EntityTypeBuilder<Ocacion> builder)
        {
            builder.ToTable("ocasions");

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
}
