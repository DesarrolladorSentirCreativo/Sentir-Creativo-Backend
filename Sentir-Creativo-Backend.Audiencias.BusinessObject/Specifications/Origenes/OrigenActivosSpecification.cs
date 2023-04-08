using Sentir_Creativo_Backend.Audiencias.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Specifications.Origenes;

public class OrigenActivosSpecification: BaseSpecification<Origen>
{
    public OrigenActivosSpecification() : base(x => x.Activo == true)
    {
        
    }
}