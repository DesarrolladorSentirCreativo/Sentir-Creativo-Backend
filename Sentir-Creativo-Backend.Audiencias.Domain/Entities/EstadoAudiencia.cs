using Sentir_Creativo_Backend.SharedKernel.Domain;

namespace Sentir_Creativo_Backend.Audiencias.Domain.Entities;

public class EstadoAudiencia : BaseEntity<int>
{
    public string? Nombre { get; set; }
    public string? Prioridad { get; set; }
    public string? Color { get; set; }
    public string? Image { get; set; }
    public string? Icon { get; set; }
    
    public virtual ICollection<Audiencia>? Audiencias { get; set; }
}