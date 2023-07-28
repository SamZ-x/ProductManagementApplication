/*
 * Repository implementation: basic query function of User entity
 * File: UserRepository.cs
 * Author: Sam
 */

namespace ProductManagementApp.Data
{
    using Microsoft.EntityFrameworkCore;
    using ProductManagementApp.Model;

    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly PMDataContext _pmDataContext;

        public UserRepository(PMDataContext pMDataContext) : base(pMDataContext)
        {
            _pmDataContext = pMDataContext;
        }

        public async Task<User> GetUserByEmailAsync(string email)
        {
            return await _pmDataContext.User.FirstOrDefaultAsync((user) => user.Email == email);
        }

        public async Task<User> GetUserByIdAsync(Guid id)
        {
            return await _pmDataContext.User.FirstOrDefaultAsync((user) => user.Id == id);
        }

        public async Task<User> GetUserByNameAsync(string name)
        {
            return await _pmDataContext.User.FirstOrDefaultAsync((user) =>
            user.FirstName == name || user.MiddleName == name || user.LastName == name);
        }

        public async Task<User> GetUserByUsernameAsync(string username)
        {
            return await _pmDataContext.User.FirstOrDefaultAsync((user) => user.Username == username);
        }
    }
}
