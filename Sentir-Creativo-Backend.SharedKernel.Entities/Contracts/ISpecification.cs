using System.Linq.Expressions;

namespace Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;

public interface ISpecification<T>
{
    Expression<Func<T, bool>> Criteria { get; }
    List<Expression<Func<T, object>>> Includes { get; }

    Expression<Func<T, object>> OrderBy { get; }
    Expression<Func<T, object>> OrderByDescending { get; }

    int Take { get; }
    int Skip { get; }

    bool IsPagingEnable { get; }
}