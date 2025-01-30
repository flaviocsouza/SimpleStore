using SimpleStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStore.Application.Interfaces.Repositories;

public interface IBaseRepository <TEntity> where TEntity : BaseEntity
{
    Task<TEntity> GetByIdAsync(Guid id);
    Task<List<TEntity>> GetAllAsync();
    Task<List<TEntity>> Find(Expression<Func<TEntity, bool>> query);
    Task Insert(TEntity entity);
    Task Update(TEntity entity);
    Task Delete(Guid id);
}
