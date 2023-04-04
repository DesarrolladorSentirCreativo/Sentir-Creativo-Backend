using Sentir_Creativo_Backend.Audiencias.Domain.Entities;
using Sentir_Creativo_Backend.Audiencias.Domain.Repositories.Cercanias;
using Sentir_Creativo_Backend.SharedKernel.Persistence.Contexts;
using Sentir_Creativo_Backend.SharedKernel.Persistence.Repositories;

namespace Sentir_Creativo_Backend.Audiencias.Persistence.Repositories.Cercanias;

public class CercaniaWriteRepository : WriteRepositoryBase<Cercania,int>, ICercaniaWriteRepository
{
    public CercaniaWriteRepository(SentirCreativoDbContext context) : base(context)
    {
    }
}