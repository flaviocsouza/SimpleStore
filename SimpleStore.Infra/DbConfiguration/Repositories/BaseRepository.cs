using Microsoft.EntityFrameworkCore;
using SimpleStore.Application.Interfaces.Repositories;
using SimpleStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStore.Infra.DbConfiguration.Repositories;

public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity>, IDisposable where TEntity : BaseEntity, new()
{
    protected SimpleStoreDbContext _dbContext;
    protected DbSet<TEntity> _dbSet;

    protected BaseRepository(SimpleStoreDbContext context)
    {
        _dbContext = context;
        _dbSet = context.Set<TEntity>();
    }

    public async Task<TEntity> GetByIdAsync(Guid id)
        => await _dbSet.FirstOrDefaultAsync(e => e.Id == id);

    public async Task<List<TEntity>> GetAllAsync()
        => await _dbSet.AsNoTracking().ToListAsync();

    public async Task<List<TEntity>> Find(Expression<Func<TEntity, bool>> query)
        =>  await _dbSet.AsNoTracking().Where(query).ToListAsync();
    

    public async Task Insert(TEntity entity)
    {
        await _dbSet.AddAsync(entity);
        await SaveChangesAsync();
    }

    public async Task Update(TEntity entity)
    {
        entity.UpdatedAt = DateTime.UtcNow;
        _dbSet.Update(entity);
        await SaveChangesAsync();
    }
    public async Task Delete(Guid id)
    {
        var entity = new TEntity { Id = id };
        _dbSet.Remove(entity);
        await SaveChangesAsync();
    }

    protected async Task SaveChangesAsync()
    {
        await _dbContext.SaveChangesAsync();
        Dispose();
    }

    public void Dispose()
    {
        _dbContext?.Dispose();
    }
}
