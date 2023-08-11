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
    using ProductManagementApp.DataUtility;
    using ProductManagementApp.Model;

    [Authorize(policy: "AdminAccess")]
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
        public async Task<IActionResult> GetAllUsers()
        {
            try
            {
                List<User> users = (List<User>)await _unitOfWork.UserRepository.GetAllAsync();

                List<UserDTO> result = new List<UserDTO>();

                foreach (var user in users)
                {
                    result.Add(_mapper.Map<UserDTO>(user));
                }

                return StatusCode(StatusCodes.Status200OK, result);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }
        }


        [HttpGet, Route("Id")]
        public async Task<ActionResult<User>> GetUserById(string id)
        {
            try
            {
                Guid userId = Guid.Parse(id);

                var user = await _unitOfWork.UserRepository.GetUserByIdAsync(userId);

                if (user != null)
                {
                    UserDTO result = _mapper.Map<UserDTO>(user);
                    return StatusCode(StatusCodes.Status200OK, result);
                }
                else
                {
                    return StatusCode(StatusCodes.Status204NoContent, "No user found.");
                }
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }


            
        }
    }
}
