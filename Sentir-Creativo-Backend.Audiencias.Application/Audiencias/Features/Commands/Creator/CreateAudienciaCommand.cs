using MediatR;

namespace Sentir_Creativo_Backend.Audiencias.Application.Audiencias.Features.Commands.Creator;

public class CreateAudienciaCommand : IRequest<int>
{
    public string Nombre { get; set; }
    public string? Apellido { get; set; }
    public string? Profesion { get; set; }
    public string Email { get; set; }
    public string? Celular { get; set; }
    public int OrganizacionId { get; set; }
    public string Departamento { get; set; }
    public string? Cargo { get; set; }
    public int AntiguedadId { get; set; }
    public int CercaniaId { get; set; }
    public int MotivacionId { get; set; }
    public int EstadoId { get; set; }
    public int PrefijoId { get; set; }
    public int OrigenId { get; set; }
    public string? Email2 { get; set; }
    public bool? Destacado { get; set; }
    public string? DocumentoIdentidad  { get; set; }
    public bool Activo { get; set; }
}