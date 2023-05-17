using Sentir_Creativo_Backend.Archivos.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Audiencias;

public class ArchivoViewModel
{
    public int Id { get; set; }
    public string? Path { get; set; }
    public string? Nombre { get; set; }
    public DateTime? PublishedAt { get; set; }
    public int? TipoArchivoId { get; set; }
    public string? TipoArchivo { get; set; }
    public bool? Publico { get; set; }
}