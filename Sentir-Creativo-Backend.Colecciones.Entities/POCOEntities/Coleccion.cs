using Sentir_Creativo_Backend.SharedKernel.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.Colecciones.Entities.POCOEntities;

public class Coleccion : BaseEntity<int>
{
    public string Nombre { get; set; }
    public string? Descripcion { get; set; }
    public DateTime CreatedAt { get; set; }
    public int? CreatedBy { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? PublishedAt { get; set; }
    public int? UpdatedBy { get; set; }
    public bool Activo { get; set; }
    
}