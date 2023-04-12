using Sentir_Creativo_Backend.CuponDescuentos.Entities.DTO;
using Sentir_Creativo_Backend.Difusiones.Entities.DTO;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.DTO.Audiencias;

public class CreateAudienciaDto
{
    public string Nombre { get; set; }
    public string Email { get; set; }
    public string? Celular { get; set; }
    public int OrganizacionId { get; set; }
    public string? Departamento { get; set; }
    public string? Cargo { get; set; }
    public int AntiguedadId { get; set; }
    public int CercaniaId { get; set; }
    public int MotivacionId { get; set; }
    public int UserId { get; set; }
    public string? Apellido { get; set; }
    public int EstadoAudienciaId { get; set; }
    public int PrefijoId { get; set; }
    public int OrigenId { get; set; }
    public string? Email2 { get; set; }
    public bool Destacado { get; set; }
    public string? DocumentoIdentidad { get; set; }
    public bool Activo { get; set; }
    
    IReadOnlyList<IdCuponDescuentoDto> CuponDescuentos { get; set; }
    IReadOnlyList<IdDifusionDto> Difusiones { get; set; }
}