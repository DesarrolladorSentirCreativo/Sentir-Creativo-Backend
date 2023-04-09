using Sentir_Creativo_Backend.PublicoObjetivos.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.POCOEntities;

public class AudienciaPublicoObjetivo : BaseEntity<int>
{
    public int? AudienciaId { get; set; }
    public int? PublicoObjetivoId { get; set; }
    
    public Audiencias.Entities.POCOEntities.Audiencia? Audiencia { get; set; }
    public PublicoObjetivo? PublicoObjetivo { get; set; }

}