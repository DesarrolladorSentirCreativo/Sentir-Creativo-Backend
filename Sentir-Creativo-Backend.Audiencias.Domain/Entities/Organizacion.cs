using Sentir_Creativo_Backend.SharedKernel.Domain;

namespace Sentir_Creativo_Backend.Audiencias.Domain.Entities;

public class Organizacion : BaseEntity<int>
{
    public string Nombre { get; set; }
    public string? Website { get; set; }
    public string? Facebook { get; set; }
    public string? Twitter { get; set; }
    public string? Instagram { get; set; }
    public string? Historial { get; set; }
    public string? Email { get; set; }
    public int? RubroId { get; set; }
    public string? Telefono { get; set; }
    
    public virtual Rubro? Rubro { get; set; }
    public virtual ICollection<Audiencia> Audiencias { get; set; } 
}