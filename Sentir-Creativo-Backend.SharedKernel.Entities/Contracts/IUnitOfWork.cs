using Sentir_Creativo_Backend.SharedKernel.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;

public interface IUnitOfWork: IDisposable
{
    IWriteRepository<TEntity> WriteRepository<TEntity>() where TEntity : BaseEntity<int>;

    Task<int> Complete();
}
    