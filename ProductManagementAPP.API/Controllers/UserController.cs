/*
 * Controller: Endpoints for User entity
 * File: UserController.cs
 * Author: Sam
 */

namespace ProductManagementApp.API.Controllers
{
    using AutoMapper;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using ProductManagementApp.Data;
    using ProductManagementApp.Model;

    [Authorize]
    public class UserController : BaseApiController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UserController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        /// <summary>
        /// Get all users
        /// </summary>
        /// <returns>List of Users</returns>
        [HttpGet, Route("all")]
        [Authorize(policy: "AdminAccess")]
        public async Task<IEnumerable<User>> GetAllUsers()
        {
            return await _unitOfWork.UserRepository.GetAllAsync();
        }


        [HttpGet, Route("Id")]
        public async Task<ActionResult<User>> GetUserById(string id)
        {
            Guid userId = Guid.Parse(id);

            var user = await _unitOfWork.UserRepository.GetUserByIdAsync(userId);

            if (user!= null)
            {
                return Ok(user);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
