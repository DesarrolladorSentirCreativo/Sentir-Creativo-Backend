using Sentir_Creativo_Backend.Audiencias.Domain.Entities;
using Sentir_Creativo_Backend.Audiencias.Domain.Repositories.Audiencias;
using Sentir_Creativo_Backend.SharedKernel.Persistence.Contexts;
using Sentir_Creativo_Backend.SharedKernel.Persistence.Repositories;

namespace Sentir_Creativo_Backend.Audiencias.Persistence.Repositories.Audiencias;

public class AudienciaReadRepository : ReadRepositoryBase<Audiencia,int> , IAudienciaReadRepository
{
    public AudienciaReadRepository(SentirCreativoDbContext context) : base(context)
    {
        
    }
}