using Sentir_Creativo_Backend.Audiencias.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Specifications.EstadosAudiencias;

public class EstadoAudienciaActivosSpecification: BaseSpecification<EstadoAudiencia>
{
    public EstadoAudienciaActivosSpecification() : base(x => x.Activo)
    {
        
    }
    
}