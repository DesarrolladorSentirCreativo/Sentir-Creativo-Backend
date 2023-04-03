using Sentir_Creativo_Backend.Audiencias.Domain.Entities;
using Sentir_Creativo_Backend.SharedKernel.Domain.Repositories;

namespace Sentir_Creativo_Backend.Audiencias.Domain.Repositories;

public interface IAudienciaWriteRepository : IAsyncWriteRepository<Audiencia,int>
{
    
}