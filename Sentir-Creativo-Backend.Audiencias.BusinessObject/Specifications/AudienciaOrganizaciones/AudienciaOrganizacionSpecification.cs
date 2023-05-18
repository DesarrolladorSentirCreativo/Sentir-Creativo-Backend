using Sentir_Creativo_Backend.Audiencia.BusinessObject.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Specifications.AudienciaOrganizaciones;

public class AudienciaOrganizacionSpecification : BaseSpecification<AudienciaOrganizacion>
{
    public AudienciaOrganizacionSpecification(int audienciaId)
        : base(x => x.AudienciaId == audienciaId)
    {
    }
}