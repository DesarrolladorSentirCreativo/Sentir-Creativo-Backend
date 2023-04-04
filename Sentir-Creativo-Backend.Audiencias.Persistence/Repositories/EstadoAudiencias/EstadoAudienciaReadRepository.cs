using Sentir_Creativo_Backend.Audiencias.Domain.Entities;
using Sentir_Creativo_Backend.Audiencias.Domain.Repositories.EstadoAudiencias;
using Sentir_Creativo_Backend.SharedKernel.Persistence.Contexts;
using Sentir_Creativo_Backend.SharedKernel.Persistence.Repositories;

namespace Sentir_Creativo_Backend.Audiencias.Persistence.Repositories.EstadoAudiencias;

public class EstadoAudienciaReadRepository : ReadRepositoryBase<EstadoAudiencia,int>,IEstadoAudienciaReadRepository
{
    public EstadoAudienciaReadRepository(SentirCreativoDbContext context) : base(context)
    {
        
    }
}