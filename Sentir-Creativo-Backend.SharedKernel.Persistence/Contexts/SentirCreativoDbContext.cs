using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Sentir_Creativo_Backend.Audiencias.Domain.Entities;
using Sentir_Creativo_Backend.SharedKernel.Domain;

namespace Sentir_Creativo_Backend.SharedKernel.Persistence.Contexts;

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
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
    
    public DbSet<Antiguedad>? Antiguedades { get; set; }
    public DbSet<Cercania>? Cercanias { get; set; }
    public DbSet<EstadoAudiencia>? EstadosAudiencias { get; set; }
    public DbSet<Motivacion>? Motivaciones { get; set; }
    public DbSet<Origen>? Origenes { get; set; }
    public DbSet<Prefijo>? Prefijos { get; set; }
}