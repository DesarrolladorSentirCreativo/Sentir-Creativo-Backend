using Sentir_Creativo_Backend.Audiencia.BusinessObject.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Specifications.Audiencias;

public class AudienciaDifusionIdAudienciaSpecification : BaseSpecification<AudienciaDifusion>
{
    public AudienciaDifusionIdAudienciaSpecification(int difusionId) : base(x => x.DifusionId == difusionId)
    {
        AddInclude(p => p.Audiencia!);
        AddInclude(p => p.Difusion!);
        AddInclude(p => p.Audiencia!.Organizacion!);
    }
}