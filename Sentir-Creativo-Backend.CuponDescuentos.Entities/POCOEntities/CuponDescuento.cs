using Sentir_Creativo_Backend.SharedKernel.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.CuponDescuentos.Entities.POCOEntities;

public class CuponDescuento : BaseEntity<int>
{
    public string Codigo { get; set; }
    public DateTime CreatedAt { get; set; }
    public int? CreatedBy { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? PublishedAt { get; set; }
    public int? UpdatedBy { get; set; }
    public DateTime? FechaInicio { get; set; }
    public DateTime? FechaFin { get; set;}
    public string? Descripcion { get; set; }
    public bool Activo { get; set; }
}