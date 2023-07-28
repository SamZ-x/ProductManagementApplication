/*
 * IUserRepository: endpoints for User
 * File: IUserRepository.cs
 * Author: Sam
 */

namespace ProductManagementApp.Data
{
    using ProductManagementApp.Model;

    public interface IUserRepository: IRepository<User>
    {
        Task<User> GetUserByIdAsync(Guid id);
        Task<User> GetUserByUsernameAsync(string username);
        Task<User> GetUserByEmailAsync(string email);
        Task<User> GetUserByNameAsync(string name);
    }
}
