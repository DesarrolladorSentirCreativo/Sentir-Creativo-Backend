using Sentir_Creativo_Backend.SharedKernel.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.Areas.Entities.POCOEntities;

public class Area : BaseEntity<int>
{
    public string? Descripcion { get; set; }
    public string? ColorPrimario { get; set; }
    public string? ColorSecundario { get; set; }
    public string? Slogan { get; set; }
    public string? Focus  { get; set; }
    public string? Nombre { get; set; }
    public string? Icono  { get; set; }
    public int? Prioridad { get; set; }
    public bool Activo { get; set; }
    public DateTime CreatedAt { get; set; }
    public int? CreatedBy { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? PublishedAt { get; set; }
    public int? UpdatedBy { get; set; }
}