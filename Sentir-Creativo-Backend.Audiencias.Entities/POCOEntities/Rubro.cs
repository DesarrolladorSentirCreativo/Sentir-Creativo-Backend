using Sentir_Creativo_Backend.SharedKernel.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.Audiencias.Entities.POCOEntities;

public class Rubro: BaseEntity<int>
{
    public string? Nombre { get; set; }
    public string? EmailGroup { get; set; }
    public string? Icon { get; set; }
    public string? Color { get; set; }
    public string? Image { get; set; }
    public string? Prioridad { get;set; }
    public int? TipoRubroId { get; set; }
    
    public virtual TipoRubro TipoRubro { get; set; }
    public virtual ICollection<Organizacion> Organizaciones { get; set; }
}