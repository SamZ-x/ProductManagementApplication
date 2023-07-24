/*
 * Controller: Endpoints for User entity
 * File: UserController.cs
 * Author: Sam
 */

namespace ProductManagementApp.API.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using ProductManagementApp.Data;
    using ProductManagementApp.Model;

    public class UserController : BaseApiController
    {
        private readonly PMDataContext _pmDataContext;

        public UserController(PMDataContext pMDataContext)
        {
            _pmDataContext = pMDataContext;
        }

        /// <summary>
        /// Get all users
        /// </summary>
        /// <returns>List of Users</returns>
        [HttpGet, Route("all")]
        public async Task<ActionResult<IEnumerable<User>>> GetAllUsers()
        {
            return await _pmDataContext.User.ToListAsync();
        }
    }
}
