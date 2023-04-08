using Sentir_Creativo_Backend.Audiencias.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Specifications.Prefijos;

public class PrefijoActivosSpecification: BaseSpecification<Prefijo>
{
    public PrefijoActivosSpecification() : base(x => x.Activo == true)
    {
        
    }
}