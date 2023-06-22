using Senitr_Creativo_Backend.Comentarios.Entities.DTO;
using Sentir_Creativo_Backend.Archivos.Entities.DTO;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.AcuerdosUserAdmin;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.Privilegios;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.Roles;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.Sucursales;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.UsuarioAdmins;

public class UpdateUsuarioAdminDto : CuentaBancariaDto
{
    public int Id { get; set; }
    public int UserId { get; set; }
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
    public decimal SueldoBruto { get; set; }
    public int EstadoId { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string? Direccion { get; set; }
    public int CiudadId { get; set; }
    public int RegionId { get; set; }
    public int PaisId { get; set; }
    public string Alias { get; set; }
    public string Telefono { get; set; }
    public string EmailPersonal { get; set; }
    public int PrefijoId { get; set; }
    
    public IReadOnlyList<RolIdDto> Roles { get; set; }
    public IReadOnlyList<ArchivoIdDto> Archivos { get; set; }
    public IReadOnlyList<IdComentarioDto> Comentarios { get; set; }
    public IReadOnlyList<AcuerdoIdDto> Acuerdos { get; set; }
    public IReadOnlyList<PrivilegioIdDto> Privilegios { get; set; }
    public IReadOnlyList<SucursalIdDto> Sucursales { get; set; }
}