using Sentir_Creativo_Backend.SharedKernel.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.Direcciones.Entities.POCOEntities;

public class Pais : BaseEntity<int>
{
    public string Nombre { get; set; }
}