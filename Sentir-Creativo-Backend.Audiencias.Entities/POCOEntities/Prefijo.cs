using Sentir_Creativo_Backend.SharedKernel.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.Audiencias.Entities.POCOEntities;

public class Prefijo : BaseEntity<int>
{
    public string Nombre { get; set; }
    public bool Activo { get; set; }
    
    public virtual ICollection<Audiencia>? Audiencias { get; set; }
}