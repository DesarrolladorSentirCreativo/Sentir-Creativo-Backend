using Sentir_Creativo_Backend.Audiencias.Domain.Entities;
using Sentir_Creativo_Backend.SharedKernel.Application.Specifications;

namespace Sentir_Creativo_Backend.Audiencias.Application.Prefijos.Specifications;

public class PrefijoActivosSpecification : BaseSpecification<Prefijo>
{
    public PrefijoActivosSpecification() : base(x => x.Activo == true)
    {
        
    }
}