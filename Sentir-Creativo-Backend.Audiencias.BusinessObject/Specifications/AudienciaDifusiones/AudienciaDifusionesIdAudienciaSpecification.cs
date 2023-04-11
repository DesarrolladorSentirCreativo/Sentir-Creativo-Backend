using Sentir_Creativo_Backend.Audiencia.BusinessObject.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Specifications.AudienciaDifusiones;

public class AudienciaDifusionesIdAudienciaSpecification : BaseSpecification<AudienciaDifusion>
{
    public AudienciaDifusionesIdAudienciaSpecification(int audienciaId) : base(x => x.AudienciaId == audienciaId)
    {
        AddInclude(p => p.Difusion!);
    }
}