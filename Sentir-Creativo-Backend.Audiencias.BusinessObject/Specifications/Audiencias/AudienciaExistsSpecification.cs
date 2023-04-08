using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Specifications.Audiencias;

public class AudienciaExistsSpecification: BaseSpecification<Sentir_Creativo_Backend.Audiencias.Entities.POCOEntities.Audiencia>
{
    public AudienciaExistsSpecification(AudienciaExistsSpecificationParams specParams) : base(
        x => string.IsNullOrEmpty(specParams.Email) || x.Email!.Contains(specParams.Email)
            && string.IsNullOrEmpty(specParams.DocumentoIdentidad) || x.DocumentoIdentidad!.Contains(specParams.DocumentoIdentidad))
    {
        
    }
}