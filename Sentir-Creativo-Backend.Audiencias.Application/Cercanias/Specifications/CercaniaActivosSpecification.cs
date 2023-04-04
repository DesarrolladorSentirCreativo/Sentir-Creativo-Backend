using Sentir_Creativo_Backend.Audiencias.Domain.Entities;
using Sentir_Creativo_Backend.SharedKernel.Application.Specifications;

namespace Sentir_Creativo_Backend.Audiencias.Application.Cercanias.Specifications;

public class CercaniaActivosSpecification : BaseSpecification<Cercania>
{
    public CercaniaActivosSpecification() : base(x => x.Activo == true)
    {
        
    }
}