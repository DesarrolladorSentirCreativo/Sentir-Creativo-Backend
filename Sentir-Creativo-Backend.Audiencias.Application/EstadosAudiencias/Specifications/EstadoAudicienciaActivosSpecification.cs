using Sentir_Creativo_Backend.Audiencias.Domain.Entities;
using Sentir_Creativo_Backend.SharedKernel.Application.Specifications;

namespace Sentir_Creativo_Backend.Audiencias.Application.EstadosAudiencias.Specifications;

public class EstadoAudicienciaActivosSpecification : BaseSpecification<EstadoAudiencia>
{
    public EstadoAudicienciaActivosSpecification() : base(x => x.Activo)
    {
        
    }
    
}