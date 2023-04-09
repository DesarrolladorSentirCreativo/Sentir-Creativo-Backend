using Sentir_Creativo_Backend.Audiencia.BusinessObject.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Specifications.AudienciaPublicoObjetivos;

public class AudienciaPublicoObjetivoAudienciaIdSpecification : BaseSpecification<AudienciaPublicoObjetivo>
{
    public AudienciaPublicoObjetivoAudienciaIdSpecification(int audienciaId) : base(x => x.AudienciaId == audienciaId)
    {
        AddInclude(p => p.PublicoObjetivo!);
    }
}