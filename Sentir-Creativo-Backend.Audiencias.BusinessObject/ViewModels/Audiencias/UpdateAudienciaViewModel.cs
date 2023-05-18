using Senitr_Creativo_Backend.Comentarios.Entities.ViewModels;
using Sentir_Creativo_Backend.Archivos.BusinessObject.ViewModels;
using Sentir_Creativo_Backend.CuponDescuentos.Entities.ViewModels;
using Sentir_Creativo_Backend.Difusiones.Entities.ViewModels;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Audiencias;

public class UpdateAudienciaViewModel
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public string? Email { get; set; }
    public long? Celular { get; set; }
    public string? Profesion { get; set; }
    public int? OrganizacionId { get; set; }
    public string? Departamento { get; set; }
    public string? Cargo { get; set; }
    public int? AntiguedadId { get; set; }
    public int? CercaniaId { get; set; }
    public int? MotivacionId { get; set; }
    public string? Apellido { get; set; }
    public int? EstadoAudienciaId { get; set; }
    public int? PrefijoId { get; set; }
    public int? OrigenId { get; set; }
    public string? Email2 { get; set; }
    public bool? Destacado { get; set; }
    public string? DocumentoIdentidad { get; set; }
    public bool Activo { get; set; }
    public DateTime? PublishedAt { get; set; }

    public IReadOnlyList<IdCuponDescuentoViewModel> CuponDescuentos { get; set; }
    public IReadOnlyList<IdDifusionViewModel> Difusiones { get; set; }
    public IReadOnlyList<IdComentarioViewModel> Comentarios { get; set; }
    public IReadOnlyList<IdArchivoViewModel> Archivos { get; set; }

}