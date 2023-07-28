/*
 * Repository implementation: common endpoints for entities.
 * File: Repository.cs
 * Author: Sam
 */

namespace ProductManagementApp.Data
{
    using Microsoft.EntityFrameworkCore;

    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly PMDataContext _pmDataContext;
        internal DbSet<TEntity> dbSet;

        public Repository(PMDataContext pMDataContext) 
        {
            _pmDataContext = pMDataContext;
            dbSet = _pmDataContext.Set<TEntity>();
        }

        public void AddSync(TEntity entity)
        {
            dbSet.AddAsync(entity);
        }

        public void Delete(TEntity entity)
        {
            dbSet.Remove(entity);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            IQueryable<TEntity> query = dbSet;
            return await query.ToListAsync();
        }

        public async Task<bool> saveAllAsync()
        {
            int result = await _pmDataContext.SaveChangesAsync();
            return result > 0;
        }

        public void Update(TEntity entity)
        {
            dbSet.Update(entity);
        }
    }
}
