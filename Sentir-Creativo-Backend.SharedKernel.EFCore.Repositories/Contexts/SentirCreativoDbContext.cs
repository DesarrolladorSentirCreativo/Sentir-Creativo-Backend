using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Sentir_Creativo_Backend.Audiencias.EFCore.Repositories.Configurations;
using Sentir_Creativo_Backend.Bitacoras.EFCore.Repositories.Configurations;
using Sentir_Creativo_Backend.SharedKernel.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.SharedKernel.EFCore.Repositories.Contexts;

public class SentirCreativoDbContext : DbContext
{
    public SentirCreativoDbContext(DbContextOptions<SentirCreativoDbContext> options) : base(options)
    {
            
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        foreach (var entry in ChangeTracker.Entries<BaseEntity<int>>())
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.Entity.CreatedAt = DateTime.Now;
                    entry.Entity.UpdatedAt = DateTime.Now;
                    break;
                case EntityState.Modified:
                    entry.Entity.UpdatedAt = DateTime.Now;
                    break;
            }
        }

        return base.SaveChangesAsync(cancellationToken);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new BitacoraConfiguration());
        modelBuilder.ApplyConfiguration(new AntiguedadConfiguration());
        modelBuilder.ApplyConfiguration(new AudienciaConfiguration());
        modelBuilder.ApplyConfiguration(new CercaniaConfiguration());
        modelBuilder.ApplyConfiguration(new EstadoAudienciaConfiguration());
        modelBuilder.ApplyConfiguration(new MotivacionConfiguration());
        modelBuilder.ApplyConfiguration(new OrganizacionConfiguration());
        modelBuilder.ApplyConfiguration(new OrigenConfiguration());
        modelBuilder.ApplyConfiguration(new PrefijoConfiguration());
        modelBuilder.ApplyConfiguration(new RubroConfiguration());
        modelBuilder.ApplyConfiguration(new TipoRubroConfiguration());
    }
    
}