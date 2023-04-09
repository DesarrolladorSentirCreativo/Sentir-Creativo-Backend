using Sentir_Creativo_Backend.Audiencia.BusinessObject.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Specifications.AudienciaComentarios;

public class AudienciaComentarioAudienciaIdSpecification : BaseSpecification<AudienciaComentario>
{
    public AudienciaComentarioAudienciaIdSpecification(int audienciaId) : base(x => x.AudienciaId == audienciaId)
    {
        AddInclude(p => p.Comentario!);
    }
}