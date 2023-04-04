using Sentir_Creativo_Backend.SharedKernel.Domain;

namespace Sentir_Creativo_Backend.Audiencias.Domain.Entities;

public class Cercania: BaseEntity<int>
{
    public string Nombre { get; set; } 
    public bool Activo { get; set; }
    
    public virtual ICollection<Audiencia>? Audiencias { get; set; }
}