using Sentir_Creativo_Backend.Audiencias.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Specifications.Rubros;

public class RubroActivosSpecification : BaseSpecification<Rubro>
{
    public RubroActivosSpecification() : base(x => x.Activo == true)
    {
        
    }
}