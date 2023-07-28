/*
 * IRepository: common endpoints for entities
 * File: IRepository.cs
 * Author: Sam
 */

namespace ProductManagementApp.Data
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAllAsync();

        void AddSync(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);

        Task<bool> saveAllAsync();
    }
}
