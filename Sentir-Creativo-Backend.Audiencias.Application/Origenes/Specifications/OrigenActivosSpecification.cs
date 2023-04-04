using Sentir_Creativo_Backend.Audiencias.Domain.Entities;
using Sentir_Creativo_Backend.SharedKernel.Application.Specifications;

namespace Sentir_Creativo_Backend.Audiencias.Application.Origenes.Specifications;

public class OrigenActivosSpecification : BaseSpecification<Origen>
{
    public OrigenActivosSpecification() : base(x => x.Activo == true)
    {
        
    }
}