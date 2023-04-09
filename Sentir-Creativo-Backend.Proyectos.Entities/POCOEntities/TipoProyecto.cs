using Sentir_Creativo_Backend.Areas.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.Proyectos.Entities.POCOEntities;

public class TipoProyecto : BaseEntity<int>
{
    public string? Nombre { get; set; }
    public string? Icon { get; set; }
    public int? AreaId { get; set; }
    public bool Activo { get; set; }
    public DateTime? CreatedAt { get; set; }
    public int? CreatedBy { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public DateTime? PublishedAt { get; set; }
    public int? UpdatedBy { get; set; }
    
    public virtual Area? Area { get; set; }
}