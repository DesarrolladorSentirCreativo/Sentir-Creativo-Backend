using Microsoft.EntityFrameworkCore;
using Sentir_Creativo_Backend.SharedKernel.Domain;
using Sentir_Creativo_Backend.SharedKernel.Domain.Repositories;
using Sentir_Creativo_Backend.SharedKernel.Persistence.Contexts;

namespace Sentir_Creativo_Backend.SharedKernel.Persistence.Repositories;

public abstract class WriteRepositoryBase<T,TId> : IAsyncWriteRepository<T,TId> where T: BaseEntity<TId>
{
    protected readonly SentirCreativoDbContext _context;
    
    public WriteRepositoryBase(SentirCreativoDbContext context)
    {
        _context = context;
    }

    public async Task<T> AddAsync(T entity)
    {
        _context.Set<T>().Add(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<T> UpdateAsync(T entity)
    {
        _context.Entry(entity).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        
        return entity;
    }

    public async Task DeleteAsync(T entity)
    {
        _context.Set<T>().Remove(entity);
        await _context.SaveChangesAsync();
    }
}
