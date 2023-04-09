using Sentir_Creativo_Backend.SharedKernel.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.Archivos.Entities.POCOEntities;

public class Archivo : BaseEntity<int>
{
    public string? Nombre { get; set; }
    public string? Path { get; set; }
    public int? TipoArchivoId { get; set; }
    public bool? Publico { get; set; }
    public bool Activo { get; set; }
    public DateTime CreatedAt { get; set; }
    public int? CreatedBy { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? PublishedAt { get; set; }
    public int? UpdatedBy { get; set; }
    
    public virtual TipoArchivo? TipoArchivo { get; set; }
}