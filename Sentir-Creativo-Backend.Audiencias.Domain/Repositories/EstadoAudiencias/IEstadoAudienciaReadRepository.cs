using Sentir_Creativo_Backend.Audiencias.Domain.Entities;
using Sentir_Creativo_Backend.SharedKernel.Domain.Repositories;

namespace Sentir_Creativo_Backend.Audiencias.Domain.Repositories.EstadoAudiencias;

public interface IEstadoAudienciaReadRepository : IAsyncReadRepository<EstadoAudiencia,int>
{
    
}