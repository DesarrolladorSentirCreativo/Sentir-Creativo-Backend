using Sentir_Creativo_Backend.SharedKernel.Domain;

namespace Sentir_Creativo_Backend.Audiencias.Domain.Entities;

public class Motivacion : BaseEntity<int>
{
    public string Nombre { get; set; }
    
    public virtual ICollection<Audiencia>? Audiencias { get; set; }
}