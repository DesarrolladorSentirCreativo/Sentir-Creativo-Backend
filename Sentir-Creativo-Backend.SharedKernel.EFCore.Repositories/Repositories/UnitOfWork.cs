using System.Collections;
using Sentir_Creativo_Backend.SharedKernel.EFCore.Repositories.Contexts;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.SharedKernel.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.SharedKernel.EFCore.Repositories.Repositories;

public class UnitOfWork: IUnitOfWork
{
    private Hashtable _repositories;
    private readonly SentirCreativoDbContext _context;

    public UnitOfWork(SentirCreativoDbContext context)
    {
        _context = context;
    }
    
    public void Dispose()
    {
        _context.Dispose();
    }

    public IWriteRepository<TEntity, TId> WriteRepository<TEntity, TId>() where TEntity : BaseEntity<TId>
    {
        if (_repositories == null)
        {
            _repositories = new Hashtable();
        }

        var type = typeof(TEntity).Name;

        if (!_repositories.ContainsKey(type))
        {
            var repositoryType = typeof(IWriteRepository<,>);
            var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(TEntity),typeof(TId)),_context);
            _repositories.Add(type,repositoryInstance);
        }

        return (IWriteRepository<TEntity, TId>)_repositories[type];
    }

    public async Task<int> Complete()
    {
        return await _context.SaveChangesAsync();
    }
}