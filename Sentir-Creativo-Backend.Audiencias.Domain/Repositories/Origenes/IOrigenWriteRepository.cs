using Sentir_Creativo_Backend.Audiencias.Domain.Entities;
using Sentir_Creativo_Backend.SharedKernel.Domain.Repositories;

namespace Sentir_Creativo_Backend.Audiencias.Domain.Repositories.Origenes;

public interface IOrigenWriteRepository : IAsyncWriteRepository<Origen,int>
{
    
}