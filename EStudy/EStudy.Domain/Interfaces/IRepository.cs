using EStudy.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EStudy.Domain.Interfaces
{
    public interface IRepository<TEntity, Id> where TEntity : BaseModel<Id>
    {
        Task<TEntity> CreateAsync(TEntity entity);
        Task CreateAsync(List<TEntity> entities);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task UpdateAsync(List<TEntity> entities);
        Task<TEntity> RemoveAsync(TEntity entity);
        Task RemoveRangeAsync(List<TEntity> entities);
        Task<int> CountAsync();
        Task<int> CountAsync(Expression<Func<TEntity, bool>> match);
        Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> match);
        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> match);
        Task<TEntity> GetByIdAsync(Id id);
        Task<List<TEntity>> GetAllAsync(int offset, int count);
    }
}
