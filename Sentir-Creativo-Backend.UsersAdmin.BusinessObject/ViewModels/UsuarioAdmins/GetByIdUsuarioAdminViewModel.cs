using Senitr_Creativo_Backend.Comentarios.Entities.DTO;
using Sentir_Creativo_Backend.Archivos.Entities.DTO;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.AcuerdosUserAdmin;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.Privilegios;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.Roles;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.Sucursales;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.UsuarioAdmins;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.UsuarioAdmins;

public class GetByIdUsuarioAdminViewModel : CuentaBancariaDto
{
    public int Id { get; set; }
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
    public DateTime FechaPago { get; set; }
    public DateTime FechaInicio { get; set; }
    public DateTime? FechaFin { get; set; }
    public string SueldoBruto { get; set; }
    public int EstadoId { get; set; }
    public string Email { get; set; }
    public string? Direccion { get; set; }
    public int ComunaId { get; set; }
    public int RegionId { get; set; }
    public int PaisId { get; set; }
    
    public IReadOnlyList<RolIdDto> Roles { get; set; }
    public IReadOnlyList<AcuerdoIdDto> Acuerdos { get; set; }
    public IReadOnlyList<PrivilegioIdDto> Privilegios { get; set; }
    public IReadOnlyList<SucursalIdDto> Sucursales { get; set; }
}