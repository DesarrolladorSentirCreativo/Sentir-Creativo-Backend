using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Specifications.Audiencias;

public class AudienciaPaginationSpecification: BaseSpecification<Sentir_Creativo_Backend.Audiencias.Entities.POCOEntities.Audiencia>
{
    public AudienciaPaginationSpecification(AudienciaPaginationSpecificationParams audienciaParams) : base(
        x => 
            string.IsNullOrEmpty(audienciaParams.Search) || x.Nombre!.Contains(audienciaParams.Search) 
                                                         || x.Apellido!.Contains(audienciaParams.Search) || x.Departamento!.Contains(audienciaParams.Search)
                                                         || x.Antiguedad!.Nombre.Contains(audienciaParams.Search) || x.Email!.Contains(audienciaParams.Search) 
                                                         || x.Organizacion!.Nombre.Contains(audienciaParams.Search) || x.Prefijo!.Nombre.Contains(audienciaParams.Search) 
                                                         || x.Profesion!.Contains(audienciaParams.Search) || x.Cercania!.Nombre.Contains(audienciaParams.Search)
                                                         || x.Email2!.Contains(audienciaParams.Search) || x.Celular == Convert.ToInt32(audienciaParams.Search)
                                                         || x.Cargo!.Contains(audienciaParams.Search) || x.DocumentoIdentidad!.Contains(audienciaParams.Search))
    {
        AddInclude(p => p.Antiguedad!);
        AddInclude(p => p.Organizacion!);
        AddInclude(p => p.Cercania!);
        AddInclude(p => p.EstadoAudiencia!);
        AddInclude(p => p.Motivacion!);
        AddInclude(p => p.Prefijo!);
        
        ApplyPaging(audienciaParams.PageSize * (audienciaParams.PageIndex - 1),audienciaParams.PageSize);

        if (!string.IsNullOrEmpty(audienciaParams.Sort))
        {
            switch (audienciaParams.Sort)
            {
                case "nombreAsc": 
                    AddOrderBy(p => p.Nombre!);
                    break;
                case "nombreDesc": 
                    AddOrderByDescending(p => p.Nombre!);
                    break;
                case "apellidoAsc": 
                    AddOrderBy(p => p.Apellido!);
                    break;
                case "apellidoDesc": 
                    AddOrderByDescending(p => p.Apellido!);
                    break;
                default:
                    AddOrderBy(p => p.Id);
                    break;
            }
        }
    }
    
}