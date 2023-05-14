using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Specifications.Audiencias;

public class AudienciaActivosWithRelations  : BaseSpecification<Sentir_Creativo_Backend.Audiencias.Entities.POCOEntities.Audiencia>
{

    public AudienciaActivosWithRelations(): base(x => x.Activo == true)
    {
        AddInclude(p => p.Antiguedad!);
        AddInclude(p => p.Organizacion!);
        AddInclude(p => p.Cercania!);
        AddInclude(p => p.EstadoAudiencia!);
        AddInclude(p => p.Motivacion!);
        AddInclude(p => p.Prefijo!);
    }
}