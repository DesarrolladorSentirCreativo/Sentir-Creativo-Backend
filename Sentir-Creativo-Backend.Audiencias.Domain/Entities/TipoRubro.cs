using Sentir_Creativo_Backend.SharedKernel.Domain;

namespace Sentir_Creativo_Backend.Audiencias.Domain.Entities;

public class TipoRubro : BaseEntity<int>
{
    public string Nombre  { get; set; }
    
    public virtual ICollection<Rubro> Rubros { get; set; }
}