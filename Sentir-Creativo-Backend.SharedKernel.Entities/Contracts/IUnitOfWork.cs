using Sentir_Creativo_Backend.SharedKernel.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;

public interface IUnitOfWork: IDisposable
{
    IWriteRepository<TEntity,TId> WriteRepository<TEntity,TId>() where TEntity : BaseEntity<TId>;

    Task<int> Complete();
}
    