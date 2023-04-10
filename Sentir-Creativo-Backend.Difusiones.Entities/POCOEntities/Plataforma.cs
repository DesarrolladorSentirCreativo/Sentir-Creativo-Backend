using Sentir_Creativo_Backend.SharedKernel.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.Difusiones.Entities.POCOEntities;

public class Plataforma : BaseEntity<int>
{
    public string Nombre { get; set; }
    public DateTime CreatedAt { get; set; }
    public int? CreatedBy { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? PublishedAt { get; set; }
    public int? UpdatedBy { get; set; }
    public bool Activo { get; set; }
}