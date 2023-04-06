using Sentir_Creativo_Backend.Audiencias.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Specifications.Antiguedades;

public class AntiguedadActivosSpecification : BaseSpecification<Antiguedad>
{
    public AntiguedadActivosSpecification() : base(x => x.Activo == true)
    {
        
    }
}