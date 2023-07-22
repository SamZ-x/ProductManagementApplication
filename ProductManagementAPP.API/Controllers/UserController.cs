/*
 * Controller: Endpoints for User entity
 * File: UserController.cs
 * Author: Sam
 */

namespace ProductManagementAPP.API.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using ProductManagementApp.Data;
    using ProductManagementApp.Model;

    public class UserController : BaseApiController
    {
        private readonly PMDataContext _pmDataContext;
        private readonly ILogger<UserController> _logger;

        public UserController(PMDataContext pMDataContext, ILogger<UserController> logger)
        {
            _pmDataContext = pMDataContext;
            _logger = logger;
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
