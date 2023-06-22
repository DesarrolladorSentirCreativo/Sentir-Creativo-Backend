using Sentir_Creativo_Backend.Audiencias.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

public class UsuarioAdmin : BaseEntity<int>
{
    public int PrefijoId { get; set; }
    public string Nombre { get; set; }
    public string Apellidos { get; set; }
    public int PrevisionId  { get; set; }
    public int AfpId { get; set; }
    public int ModoId { get; set; }
    public int CategoriaId { get; set; }
    public int CuentaBancariaId { get; set; }
    public bool ValidaDocumento { get; set; }
    public string TipoDocumento { get; set; }
    public string NumDocumento { get; set; }
    public string? Telefono { get; set; }
    public string? EmailPersonal { get; set; }
    public DateTime FechaPago { get; set; }
    public DateTime FechaInicio { get; set; }
    public DateTime? FechaFin { get; set; }
    public decimal SueldoBruto { get; set; }
    public string Alias { get; set; }
    public int EstadoId { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string? Direccion { get; set; }
    public int ComunaId { get; set; }
    public int RegionId { get; set; }
    public int PaisId { get; set; }
    public bool Activo { get; set; }
    public DateTime CreatedAt { get; set; }
    public int? CreatedBy { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public DateTime? PublishedAt { get; set; }
    public int? UpdatedBy { get; set; }
    
    //relaciones
    public virtual Prevision Prevision { get; set; }
    public virtual Afp Afp { get; set; }
    public virtual ModoTrabajo Modo { get; set; }
    public virtual CategoriaUserAdmin Categoria { get; set; }
    public virtual CuentaBancaria CuentaBancaria { get; set; }
    public virtual Prefijo Prefijo { get; set; }
    public virtual EstadoUserAdmin Estado { get; set; }


}