using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Specifications.Audiencias;

public class AudienciaIdSpecification : BaseSpecification<Sentir_Creativo_Backend.Audiencias.Entities.POCOEntities.Audiencia>
{
    public AudienciaIdSpecification(int audienciaId) : base(x => x.Id == audienciaId && x.Activo == true)
    {
        
    }
}