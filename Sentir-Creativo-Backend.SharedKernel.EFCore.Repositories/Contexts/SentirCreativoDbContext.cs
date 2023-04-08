using Microsoft.EntityFrameworkCore;
using Sentir_Creativo_Backend.Audiencias.EFCore.Repositories.Configurations;
using Sentir_Creativo_Backend.Audiencias.Entities.POCOEntities;
using Sentir_Creativo_Backend.Bitacoras.EFCore.Repositories.Configurations;
using Sentir_Creativo_Backend.Bitacoras.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.SharedKernel.EFCore.Repositories.Contexts;

public class SentirCreativoDbContext : DbContext
{
    public SentirCreativoDbContext(DbContextOptions<SentirCreativoDbContext> options) : base(options)
    {
            
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
    
    DbSet<Bitacora> Bitacoras { get; set; }
    DbSet<Antiguedad> Antiguedades { get; set; }
    DbSet<Audiencias.Entities.POCOEntities.Audiencia> Audiencias { get; set; }
    DbSet<Cercania> Cercanias { get; set; }
    DbSet<EstadoAudiencia> EstadosAudiencias { get; set; }
    DbSet<Motivacion> Motivaciones { get; set; }
    DbSet<Organizacion> Organizaciones { get; set; }
    DbSet<Origen> Origenes { get; set; }
    DbSet<Prefijo> Prefijos { get; set; }
    DbSet<Rubro> Rubros { get; set; }
    DbSet<TipoRubro> TiposRubros { get; set; }
}