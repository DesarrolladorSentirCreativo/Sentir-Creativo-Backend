using Sentir_Creativo_Backend.Audiencias.Domain.Entities;
using Sentir_Creativo_Backend.Audiencias.Domain.Repositories.Prefijos;
using Sentir_Creativo_Backend.SharedKernel.Persistence.Contexts;
using Sentir_Creativo_Backend.SharedKernel.Persistence.Repositories;

namespace Sentir_Creativo_Backend.Audiencias.Persistence.Repositories.Prefijos;

public class PrefijoWriteRepository : WriteRepositoryBase<Prefijo,int>, IPrefijoWriteRepository
{
    public PrefijoWriteRepository(SentirCreativoDbContext context) : base(context)
    {
        
    }
}