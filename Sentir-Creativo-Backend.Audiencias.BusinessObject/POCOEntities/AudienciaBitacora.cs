using Sentir_Creativo_Backend.Bitacoras.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.POCOEntities;

public class AudienciaBitacora : BaseEntity<int>
{
    public int AudienciaId { get; set; }
    public int BitacoraId { get; set; }
    
    public Audiencias.Entities.POCOEntities.Audiencia? Audiencia { get; set; }
    public Bitacora? Bitacora { get; set; }
    
}