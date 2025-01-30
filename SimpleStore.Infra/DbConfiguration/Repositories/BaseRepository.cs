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

internal abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity, new()
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
    

    public Task Insert(TEntity entity)
    {
    }

    public Task Update(TEntity entity)
    {
        throw new NotImplementedException();
    }
    public Task Delete(Guid id)
    {
        throw new NotImplementedException();
    }
}
