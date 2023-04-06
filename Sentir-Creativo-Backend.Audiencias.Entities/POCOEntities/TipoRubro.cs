using Sentir_Creativo_Backend.SharedKernel.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.Audiencias.Entities.POCOEntities;

public class TipoRubro: BaseEntity<int>
{
    public string Nombre  { get; set; }
    
    public virtual ICollection<Rubro> Rubros { get; set; }
}