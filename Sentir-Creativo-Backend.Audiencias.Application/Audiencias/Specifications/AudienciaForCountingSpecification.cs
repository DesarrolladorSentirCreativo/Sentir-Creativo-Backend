using Sentir_Creativo_Backend.Audiencias.Domain.Entities;
using Sentir_Creativo_Backend.SharedKernel.Application.Specifications;

namespace Sentir_Creativo_Backend.Audiencias.Application.Audiencias.Specifications;

public class AudienciaForCountingSpecification : BaseSpecification<Audiencia>
{
    public AudienciaForCountingSpecification(AudienciaSpecificationParams audienciaParams) : base(
        x => string.IsNullOrEmpty(audienciaParams.Search) || x.Nombre!.Contains(audienciaParams.Search) 
            || x.Apellido!.Contains(audienciaParams.Search) || x.Departamento!.Contains(audienciaParams.Search)
            || x.Antiguedad!.Nombre.Contains(audienciaParams.Search) || x.Email!.Contains(audienciaParams.Search) 
            || x.Organizacion!.Nombre.Contains(audienciaParams.Search) || x.Prefijo!.Nombre.Contains(audienciaParams.Search) 
            || x.Profesion!.Contains(audienciaParams.Search) || x.Cercania!.Nombre.Contains(audienciaParams.Search)
            || x.Email2!.Contains(audienciaParams.Search) || x.Celular!.Contains(audienciaParams.Search)
            || x.Cargo!.Contains(audienciaParams.Search) || x.DocumentoIdentidad!.Contains(audienciaParams.Search))
    
    {
        AddInclude(p => p.Antiguedad!);
        AddInclude(p => p.Organizacion!);
        AddInclude(p => p.Cercania!);
        AddInclude(p => p.EstadoAudiencia!);
        AddInclude(p => p.Motivacion!);
        AddInclude(p => p.Prefijo!);
    }
}