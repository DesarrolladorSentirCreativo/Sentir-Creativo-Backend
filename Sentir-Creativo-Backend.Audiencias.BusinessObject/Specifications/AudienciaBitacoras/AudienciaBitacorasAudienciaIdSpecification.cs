using Sentir_Creativo_Backend.Audiencia.BusinessObject.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Specifications.AudienciaBitacoras;

public class AudienciaBitacorasAudienciaIdSpecification : BaseSpecification<AudienciaBitacora>
{
    public AudienciaBitacorasAudienciaIdSpecification(int audienciaId) : base(x => x.AudienciaId == audienciaId)
    {
        AddInclude(p => p.Bitacora!);
    }
}