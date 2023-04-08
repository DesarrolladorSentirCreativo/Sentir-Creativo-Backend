using Sentir_Creativo_Backend.Audiencias.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Specifications.Organizaciones;

public class OrganizacionActivosSpecification : BaseSpecification<Organizacion>
{
    public OrganizacionActivosSpecification() : base(x => x.Activo == true)
    {
        
    }
    
}