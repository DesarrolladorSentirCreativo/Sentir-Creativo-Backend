using Sentir_Creativo_Backend.Audiencias.Domain.Entities;
using Sentir_Creativo_Backend.Audiencias.Domain.Repositories.Audiencias;
using Sentir_Creativo_Backend.SharedKernel.Persistence.Contexts;
using Sentir_Creativo_Backend.SharedKernel.Persistence.Repositories;

namespace Sentir_Creativo_Backend.Audiencias.Persistence.Repositories.Audiencias;

public class AudienciaWriteRepository : WriteRepositoryBase<Audiencia, int>, IAudienciaWriteRepository
{
    public AudienciaWriteRepository(SentirCreativoDbContext context) : base(context)
    {
    }
}