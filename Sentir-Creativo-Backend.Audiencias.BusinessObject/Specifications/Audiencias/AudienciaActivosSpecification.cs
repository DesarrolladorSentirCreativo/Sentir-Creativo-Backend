using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Specifications.Audiencias;

public class AudienciaActivosSpecification : BaseSpecification<Sentir_Creativo_Backend.Audiencias.Entities.POCOEntities.Audiencia>
{
    public AudienciaActivosSpecification(): base(x => x.Activo == true){}
}