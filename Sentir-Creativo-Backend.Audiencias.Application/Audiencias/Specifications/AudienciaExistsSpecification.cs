using Sentir_Creativo_Backend.Audiencias.Domain.Entities;
using Sentir_Creativo_Backend.SharedKernel.Application.Specifications;

namespace Sentir_Creativo_Backend.Audiencias.Application.Audiencias.Specifications;

public class AudienciaExistsSpecification : BaseSpecification<Audiencia>
{
    public AudienciaExistsSpecification(AudienciaExistsSpecificationParams specParams) : base(
        x => string.IsNullOrEmpty(specParams.Email) || x.Email!.Contains(specParams.Email)
            && string.IsNullOrEmpty(specParams.DocumentoIdentidad) || x.DocumentoIdentidad!.Contains(specParams.DocumentoIdentidad))
    {
        
    }
}