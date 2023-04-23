using Sentir_Creativo_Backend.Difusiones.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;

namespace Sentir_Creativo_Backend.Difusiones.BusinessObject.Specifications;

public class DifusionActivosSpecification : BaseSpecification<Difusion>
{
    public DifusionActivosSpecification() : base(x => x.Activo == true)
    {
        
    }
}