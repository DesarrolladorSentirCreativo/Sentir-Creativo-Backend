using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Sentir_Creativo_Backend.SharedKernel.EFCore.Repositories.Contexts;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.SharedKernel.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.SharedKernel.EFCore.Repositories.Repositories;

public class BaseWriteRepository<T> : IWriteRepository<T> where T: BaseEntity<int>
{
    protected readonly SentirCreativoDbContext _context;
    
    public BaseWriteRepository(SentirCreativoDbContext context)
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
        _context.Set<T>().Attach(entity);
        _context.Entry(entity).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        
        return entity;
    }

    public async Task DeleteAsync(T entity)
    {
        _context.Set<T>().Remove(entity);
        await _context.SaveChangesAsync();
    }

    public void AddEntity(T entity)
    {
        _context.Set<T>().Add(entity);
    }

    public void UpdateEntity(T entity)
    {
        _context.Set<T>().Attach(entity);
        _context.Entry(entity).State = EntityState.Modified;
    }

    public void DeleteEntity(T entity)
    {
        _context.Set<T>().Remove(entity);
    }

    public void DeleteWhere(Expression<Func<T, bool>> where)
    {
        var entitiesToDelete = _context.Set<T>().Where(where);
        _context.Set<T>().RemoveRange(entitiesToDelete);
    }
}