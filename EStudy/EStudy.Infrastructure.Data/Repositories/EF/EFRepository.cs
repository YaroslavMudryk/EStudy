using EStudy.Domain.Interfaces;
using EStudy.Domain.Models;
using EStudy.Infrastructure.Data.EntityFramework.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EStudy.Infrastructure.Data.Repositories.EF
{
    public class EFRepository<TEntity, Id> : IRepository<TEntity, Id> where TEntity : BaseModel<Id>
    {
        protected EStudyContext db;
        protected DbSet<TEntity> dbSet;
        public EFRepository(EStudyContext _db)
        {
            db = _db;
            dbSet = db.Set<TEntity>();
        }

        public async Task<int> CountAsync()
        {
            return await db.Set<TEntity>().AsNoTracking().CountAsync();
        }

        public async Task<int> CountAsync(Expression<Func<TEntity, bool>> match)
        {
            return await db.Set<TEntity>().AsNoTracking().CountAsync(match);
        }

        public async Task<TEntity> CreateAsync(TEntity entity)
        {
            await db.Set<TEntity>().AddAsync(entity);
            await db.SaveChangesAsync();
            return entity;
        }

        public async Task CreateAsync(List<TEntity> entities)
        {
            await db.Set<TEntity>().AddRangeAsync(entities);
            await db.SaveChangesAsync();
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public async Task<List<TEntity>> GetAllAsync(int offset, int count)
        {
            return await db.Set<TEntity>()
                .AsNoTracking()
                .OrderByDescending(d => d.CreatedAt)
                .Skip(offset).Take(count)
                .ToListAsync();
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> match)
        {
            return await db.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync(match);
        }

        public async Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> match)
        {
            return await db.Set<TEntity>().AsNoTracking().Where(match).ToListAsync();
        }

        public async Task<TEntity> RemoveAsync(TEntity entity)
        {
            db.Set<TEntity>().Remove(entity);
            await db.SaveChangesAsync();
            return entity;
        }

        public async Task RemoveRangeAsync(List<TEntity> entities)
        {
            db.Set<TEntity>().RemoveRange(entities);
            await db.SaveChangesAsync();
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            db.Set<TEntity>().Update(entity);
            await db.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(List<TEntity> entities)
        {
            db.Set<TEntity>().UpdateRange(entities);
            await db.SaveChangesAsync();
        }
    }
}