using System.Linq.Expressions;
using Sentir_Creativo_Backend.SharedKernel.Domain.Contracts;

namespace Sentir_Creativo_Backend.SharedKernel.Domain.Repositories;

public interface IAsyncReadRepository<T, TId> where T : BaseEntity<TId>
{
    Task<IReadOnlyList<T>> GetAllAsync();
    Task<IReadOnlyList<T>> GetAsync(Expression<Func<T,bool>> predicate);
    Task<IReadOnlyList<T>> GetAsync(Expression<Func<T,bool>> predicate = null,
                                    Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                    string includeString = null,
                                    bool disableTracking = true);
    Task<IReadOnlyList<T>> GetAsync(Expression<Func<T,bool>> predicate = null,
                                    Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                    List<Expression<Func<T,object>>> includes = null,
                                    bool disableTracking = true);

    Task<T?> GetByIdAsync(TId id);
    
    Task<T> GetByIdWithSpec(ISpecification<T> spec);

    Task<IReadOnlyList<T>> GetAllWithSpec(ISpecification<T> spec);

    Task<int> CountAsync(ISpecification<T> spec);
}