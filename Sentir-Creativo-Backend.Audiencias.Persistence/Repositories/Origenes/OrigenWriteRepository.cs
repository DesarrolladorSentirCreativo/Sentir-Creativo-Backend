using Sentir_Creativo_Backend.Audiencias.Domain.Entities;
using Sentir_Creativo_Backend.Audiencias.Domain.Repositories.Origenes;
using Sentir_Creativo_Backend.SharedKernel.Persistence.Contexts;
using Sentir_Creativo_Backend.SharedKernel.Persistence.Repositories;

namespace Sentir_Creativo_Backend.Audiencias.Persistence.Repositories.Origenes;

public class OrigenWriteRepository : WriteRepositoryBase<Origen,int>, IOrigenWriteRepository
{
    public OrigenWriteRepository(SentirCreativoDbContext context) : base(context)
    {
        
    }
}