namespace Sentir_Creativo_Backend.SharedKernel.Domain.Repositories;

public interface IAsyncWriteRepository<T, TId> where T : BaseEntity<TId>
{
    Task<T> AddAsync(T entity);
    Task<T> UpdateAsync(T entity);
    Task DeleteAsync(T entity);
}