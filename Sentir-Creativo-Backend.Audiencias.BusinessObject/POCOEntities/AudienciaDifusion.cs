using Sentir_Creativo_Backend.Difusiones.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.POCOEntities;

public class AudienciaDifusion : BaseEntity<int>
{
    public int? DifusionId { get; set; }
    public int? AudienciaId { get; set; }
    
    public virtual Audiencias.Entities.POCOEntities.Audiencia? Audiencia { get; set; }
    public virtual Difusion? Difusion { get; set; }
}