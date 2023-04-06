using Sentir_Creativo_Backend.Audiencias.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Specifications.Cercanias;

public class CercaniaActivosSpecification : BaseSpecification<Cercania>
{
    public CercaniaActivosSpecification() : base(x => x.Activo == true)
    {
        
    }
}