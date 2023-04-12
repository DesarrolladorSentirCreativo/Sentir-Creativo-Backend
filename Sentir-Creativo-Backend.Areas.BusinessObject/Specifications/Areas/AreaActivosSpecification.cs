using Sentir_Creativo_Backend.Areas.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;

namespace Sentir_Creativo_Backend.Areas.BusinessObject.Specifications.Areas;

public class AreaActivosSpecification : BaseSpecification<Area>
{
    public AreaActivosSpecification() : base(x => x.Activo == true)
    {
        
    }
}