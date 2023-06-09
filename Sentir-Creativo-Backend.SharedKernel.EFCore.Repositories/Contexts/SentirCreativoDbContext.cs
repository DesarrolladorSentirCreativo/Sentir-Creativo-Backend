using Microsoft.EntityFrameworkCore;
using Senitr_Creativo_Backend.Comentarios.Entities.POCOEntities;
using Sentir_Creativo_Backend.Archivos.EFCore.Repositories.Configurations;
using Sentir_Creativo_Backend.Archivos.Entities.POCOEntities;
using Sentir_Creativo_Backend.Areas.EFCore.Repositories.Configurations;
using Sentir_Creativo_Backend.Areas.Entities.POCOEntities;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.POCOEntities;
using Sentir_Creativo_Backend.Audiencias.EFCore.Repositories.Configurations;
using Sentir_Creativo_Backend.Audiencias.Entities.POCOEntities;
using Sentir_Creativo_Backend.Bitacoras.EFCore.Repositories.Configurations;
using Sentir_Creativo_Backend.Bitacoras.Entities.POCOEntities;
using Sentir_Creativo_Backend.Colecciones.EFCore.Repositories.Configurations;
using Sentir_Creativo_Backend.Colecciones.Entities.POCOEntities;
using Sentir_Creativo_Backend.Comentarios.EFCore.Repositories.Configurations;
using Sentir_Creativo_Backend.CuponDescuentos.EFCore.Repositories.Configurations;
using Sentir_Creativo_Backend.CuponDescuentos.Entities.POCOEntities;
using Sentir_Creativo_Backend.Difusiones.Entities.POCOEntities;
using Sentir_Creativo_Backend.Direcciones.EFCore.Repositories.Configurations;
using Sentir_Creativo_Backend.Direcciones.Entities.POCOEntities;
using Sentir_Creativo_Backend.Plantillas.EFCore.Repositories.Configurations;
using Sentir_Creativo_Backend.Plantillas.Entities.POCOEntities;
using Sentir_Creativo_Backend.Proyectos.EFCore.Repositories.Configurations;
using Sentir_Creativo_Backend.Proyectos.Entities.POCOEntities;
using Sentir_Creativo_Backend.PublicoObjetivos.EFCore.Repositories.Configurations;
using Sentir_Creativo_Backend.PublicoObjetivos.Entities.POCOEntities;
using Sentir_Creativo_Backend.Servicios.EFCore.Repositories.Configurations;
using Sentir_Creativo_Backend.Servicios.Entities.POCOEntities;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.POCOEntities;
using Sentir_Creativo_Backend.UsersAdmin.EFCore.Repositories.Configurations;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;
using Sentir_Cretivo_Backend.Difusiones.EFCore.Repositories.Configuraciones;

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
        modelBuilder.ApplyConfiguration(new BitacoraAudienciaConfiguration());
        modelBuilder.ApplyConfiguration(new CuponDescuentoConfiguration());
        modelBuilder.ApplyConfiguration(new TipoArchivoConfiguration());
        modelBuilder.ApplyConfiguration(new AudienciaCuponDescuentoConfiguration());
        modelBuilder.ApplyConfiguration(new ComentarioConfiguration());
        modelBuilder.ApplyConfiguration(new AudienciaComentarioConfiguration());
        modelBuilder.ApplyConfiguration(new ArchivoConfiguration());
        modelBuilder.ApplyConfiguration(new AudienciaArchivoConfiguration());
        modelBuilder.ApplyConfiguration(new PublicoObjetivoConfiguration());
        modelBuilder.ApplyConfiguration(new AudienciaPublicoObjetivoConfiguration());
        modelBuilder.ApplyConfiguration(new AreaConfiguration());
        modelBuilder.ApplyConfiguration(new TipoProyectoConfiguration());
        modelBuilder.ApplyConfiguration(new EstadoProyectoConfiguration());
        modelBuilder.ApplyConfiguration(new PlantillaConfiguration());
        modelBuilder.ApplyConfiguration(new ColeccionConfiguration());
        modelBuilder.ApplyConfiguration(new PlataformaConfiguration());
        modelBuilder.ApplyConfiguration(new DifusionConfiguration());
        modelBuilder.ApplyConfiguration(new AudienciaDifusionConfiguration());
        modelBuilder.ApplyConfiguration(new EstadoServicioConfiguration());
        modelBuilder.ApplyConfiguration(new FormatoConfiguration());
        modelBuilder.ApplyConfiguration(new UserAdminConfiguration());
        modelBuilder.ApplyConfiguration(new PaisConfiguration());
        modelBuilder.ApplyConfiguration(new RegionConfiguration());
        modelBuilder.ApplyConfiguration(new CiudadConfiguration());
        modelBuilder.ApplyConfiguration(new DireccionConfiguration());
        modelBuilder.ApplyConfiguration(new OrganizacionDireccionConfiguration());
        modelBuilder.ApplyConfiguration(new AudienciaOrganizacionConfiguration());
        modelBuilder.ApplyConfiguration(new SucursalConfiguration());
        modelBuilder.ApplyConfiguration(new CategoriaPrivilegioConfiguration());
        modelBuilder.ApplyConfiguration(new ModuloConfiguration());
        modelBuilder.ApplyConfiguration(new ColeccionUserAdminConfiguration());
        modelBuilder.ApplyConfiguration(new AccesoConfiguration());
        modelBuilder.ApplyConfiguration(new PrivilegioConfiguration());
        modelBuilder.ApplyConfiguration(new PrivilegioAccesoConfiguration());
        modelBuilder.ApplyConfiguration(new AcuerdoUserAdminConfiguration());
        modelBuilder.ApplyConfiguration(new RolConfiguration());
        modelBuilder.ApplyConfiguration(new RolAcuerdoConfiguration());
        modelBuilder.ApplyConfiguration(new RolPrivilegioConfiguration());
        modelBuilder.ApplyConfiguration(new CategoriaUserAdminConfigurarion());
        modelBuilder.ApplyConfiguration(new AfpConfiguration());
        modelBuilder.ApplyConfiguration(new ModoTrabajoConfiguration());
        modelBuilder.ApplyConfiguration(new PrevisionConfiguration());
        modelBuilder.ApplyConfiguration(new EstadoUserAdminConfiguration());
        modelBuilder.ApplyConfiguration(new CuentaBancariaConfiguration());
        modelBuilder.ApplyConfiguration(new UsuarioAdminConfiguration());
        modelBuilder.ApplyConfiguration(new UsuarioArchivoConfiguration());
        modelBuilder.ApplyConfiguration(new UsuarioComentarioConfiguration());
        modelBuilder.ApplyConfiguration(new UsuarioAcuerdoConfiguration());
        modelBuilder.ApplyConfiguration(new UsuarioSucursalConfiguration());
        modelBuilder.ApplyConfiguration(new UsuarioRolConfiguration());
        modelBuilder.ApplyConfiguration(new UsuarioPrevilegioConfiguration());
        modelBuilder.ApplyConfiguration(new TecnicaArtisticaConfiguration());
        modelBuilder.ApplyConfiguration(new OcacionConfiguration());
        
        
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
    DbSet<AudienciaBitacora> AudienciaBitacoras { get; set; }
    DbSet<CuponDescuento> CuponDescuentos { get; set; }
    DbSet<AudienciaCuponDescuento> AudienciaCuponDescuentos { get; set; }
    DbSet<Archivo> Archivos { get; set; }
    DbSet<AudienciaArchivo> AudienciaArchivos { get; set; }
    DbSet<TipoArchivo> TipoArchivos { get; set; }
    DbSet<Comentario> Comentarios { get; set; }
    DbSet<AudienciaComentario> AudienciaComentarios { get; set; }
    DbSet<PublicoObjetivo> PublicosObjetivos { get; set; }
    DbSet<AudienciaPublicoObjetivo> AudienciaPublicosObjetivos { get; set; }
    DbSet<Area> Areas { get; set; }
    DbSet<TipoProyecto> TiposProyectos { get; set; }
    DbSet<EstadoProyecto> EstadoProyectos { get; set; }
    DbSet<Plantilla> Plantillas { get; set; } 
    DbSet<Coleccion> Colecciones { get; set; }
    DbSet<Plataforma> Plataformas { get; set; }
    DbSet<Difusion> Difusiones { get; set; }
    DbSet<AudienciaDifusion> AudienciaDifusiones { get; set; }
    DbSet<EstadoServicio> EstadoServicios { get; set; }
    DbSet<Formato> Formatos { get; set; }
    DbSet<UserAdmin> UserAdmins { get; set; }
    DbSet<Pais> Paises { get; set; }
    DbSet<Region> Regiones { get; set; }
    DbSet<Ciudad> Ciudades { get; set; }
    DbSet<Direccion> Direcciones { get; set; }
    DbSet<OrganizacionDireccion> OrganizacionDirecciones { get; set; }
    DbSet<AudienciaOrganizacion> AudienciaOrganizaciones { get; set; }
    DbSet<CategoriaPrivilegio> CategoriaPrivilegios { get; set; }
    DbSet<Privilegio> Privilegios { get; set; }
    DbSet<Acceso> Accesos { get; set; }
    DbSet<PrivilegioAcceso> PrivilegioAccesos { get; set; } 
    DbSet<AcuerdoUserAdmin> AcuerdoUserAdmins { get; set; }
    DbSet<Rol> Roles { get; set; }
    DbSet<RolAcuerdo> RolAcuerdos { get; set; }
    DbSet<RolPrivilegio> RolPrivilegios { get; set; }
    DbSet<CategoriaUserAdmin> CategoriaUserAdmins { get; set; }
    DbSet<Afp> Afps { get; set; }
    DbSet<ModoTrabajo> ModoTrabajos { get; set; }
    DbSet<Prevision> Previsiones { get; set; }
    DbSet<EstadoUserAdmin> EstadoUserAdmins { get; set;}
    DbSet<CuentaBancaria> CuentaBancarias { get; set; }
    DbSet<UsuarioAdmin> UsuarioAdmins { get; set; }
    DbSet<UsuarioAcuerdo> UsuarioAcuerdos { get; set; }
    DbSet<UsuarioArchivo> UsuarioArchivos { get; set; }
    DbSet<UsuarioComentario> UsuarioComentarios { get; set; }
    DbSet<UsuarioSucursal> UsuarioSucursales { get; set; }
    DbSet<UsuarioRol> UsuarioRoles { get; set; }
    DbSet<UsuarioPrivilegio> UsuarioPrivilegios { get; set; }
    DbSet<TecnicaArtistica> TecnicaArtisticas { get; set; }
    DbSet<Ocacion> Ocacions { get; set;}

}