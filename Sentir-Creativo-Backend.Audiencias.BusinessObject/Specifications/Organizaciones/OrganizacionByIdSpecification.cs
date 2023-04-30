using Sentir_Creativo_Backend.Audiencias.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Specifications.Organizaciones;

public class OrganizacionByIdSpecification : BaseSpecification<Organizacion>
{
    public OrganizacionByIdSpecification(int audienciaId) : base(x => x.Id == audienciaId)
    {
        
    }
}