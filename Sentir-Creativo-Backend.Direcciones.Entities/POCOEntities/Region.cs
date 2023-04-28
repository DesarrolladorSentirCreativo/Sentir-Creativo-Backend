using Sentir_Creativo_Backend.SharedKernel.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.Direcciones.Entities.POCOEntities;

public class Region : BaseEntity<int>
{
    public string Nombre { get; set; }
    public int PaisId { get; set; }
    
    public Pais? Pais { get; set; }
}