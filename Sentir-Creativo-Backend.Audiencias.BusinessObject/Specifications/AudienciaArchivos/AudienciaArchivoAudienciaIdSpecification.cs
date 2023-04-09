using Sentir_Creativo_Backend.Audiencia.BusinessObject.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Specifications.AudienciaArchivos;

public class AudienciaArchivoAudienciaIdSpecification : BaseSpecification<AudienciaArchivo>
{
    public AudienciaArchivoAudienciaIdSpecification(int audienciaId) : base(x => x.AudienciaId == audienciaId)
    {
        AddInclude(p => p.Archivo!);
    }
}