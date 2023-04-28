using Sentir_Creativo_Backend.Direcciones.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;

namespace Sentir_Creativo_Backend.Direcciones.BusinessObjects.Specifications.Paises;

public class PaisActivosSpecification : BaseSpecification<Pais>
{
    public PaisActivosSpecification(): base(x => x.Id == 41)
    {
    
    }
}