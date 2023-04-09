using Sentir_Creativo_Backend.Audiencia.BusinessObject.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Specifications.AudienciaCuponDescuentos;

public class AudienciaCuponDescuentoAudienciaIdSpecification : BaseSpecification<AudienciaCuponDescuento>
{
    public AudienciaCuponDescuentoAudienciaIdSpecification(int audienciaId) : base(x => x.AudienciaId == audienciaId)
    {
        AddInclude(p => p.CuponDescuento!);
    }
}