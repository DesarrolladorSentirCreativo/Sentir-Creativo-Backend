using Sentir_Creativo_Backend.SharedKernel.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;

public interface IWriteRepository<T> where T : BaseEntity<int>
{
    Task<T> AddAsync(T entity);
    Task<T> UpdateAsync(T entity);
    Task DeleteAsync(T entity);
    void AddEntity(T entity);
    void UpdateEntity(T entity);
    void DeleteEntity(T entity);
}