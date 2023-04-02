using Microsoft.EntityFrameworkCore;
using Sentir_Creativo_Backend.Audiencias.Domain.Entities;

namespace Sentir_Creativo_Backend.SharedKernel.Persistence.Contexts;

public class SentirCreativoDbContext : DbContext
{
    public SentirCreativoDbContext(DbContextOptions<SentirCreativoDbContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
    }
    
    public DbSet<Antiguedad>? Antiguedades { get; set; }
    public DbSet<Cercania>? Cercanias { get; set; }
    public DbSet<EstadoAudiencia>? EstadosAudiencias { get; set; }
    public DbSet<Motivacion>? Motivaciones { get; set; }
    public DbSet<Origen>? Origenes { get; set; }
    public DbSet<Prefijo>? Prefijos { get; set; }
}