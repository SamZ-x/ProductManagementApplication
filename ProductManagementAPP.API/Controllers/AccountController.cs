/*
 * Controller: Account endpoints (login, register)
 * File: AccountController.cs
 * Author: Sam
 */

namespace ProductManagementApp.API.Controllers
{
    using AutoMapper;
    using Microsoft.AspNetCore.Http.HttpResults;
    using Microsoft.AspNetCore.Mvc;
    using ProductManagementApp.Data;
    using ProductManagementApp.DataUtility;
    using ProductManagementApp.Model;
    using System.Security.Cryptography;
    using System.Text;

    public class AccountController: BaseApiController
    {
        // db connection
        private readonly ITokenService _tokenService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _Mapper;

        public AccountController(IUnitOfWork unitOfWork, ITokenService tokenService, IMapper mapper)
        {
            this._unitOfWork = unitOfWork;
            this._tokenService = tokenService;
            this._Mapper = mapper;
        }

        [HttpPost, Route("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDTO registerInfo)
        {
            // Server side validation: verify existence of the username, email.
            bool isValid = await newUserValidation(registerInfo);
            if (!isValid)
            {
                return StatusCode(StatusCodes.Status409Conflict, "UserId has already registered.");
            }

            // Create guid for new user
            Guid newUserId = Guid.NewGuid();

            User newUser = _Mapper.Map<User>(registerInfo);
            // manually set
            newUser.Id = newUserId;
            newUser.Role = 1;

            _unitOfWork.UserRepository.AddSync(newUser);
            bool result = await _unitOfWork.UserRepository.saveAllAsync();

            if (result)
            {
                UserDTO user = _Mapper.Map<UserDTO>(newUser);
                var token = _tokenService.CreateToken(newUser);
                user.Token = token;

                return Ok(user);
            }

            return StatusCode(StatusCodes.Status500InternalServerError, "Server Error.");
        }

        [HttpPost, Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginDTO loginInfo)
        {
            try
            {
                User userByName = await _unitOfWork.UserRepository.GetUserByUsernameAsync(loginInfo.UserId);
                User userByEmail = await _unitOfWork.UserRepository.GetUserByEmailAsync(loginInfo.UserId);

                if(userByName == null && userByEmail == null)
                {
                    return StatusCode(StatusCodes.Status404NotFound, "Invalid UserId.");
                }

                // Get the match user
                User foundUser = userByName == null ? userByEmail : userByName;

                // verify hash
                // using the salt of the DB user, to create a keyed HMACSHA512 instance 
                using var hmac = new HMACSHA512(foundUser.PasswordSalt);

                // create the hasd of the login password.
                var computeHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(loginInfo.Password));

                // get the db password hash
                var dbHash = foundUser.PasswordHash;
                
                // Compare password hash byte[]
                if (computeHash.Length != dbHash.Length) 
                {
                    return StatusCode(StatusCodes.Status401Unauthorized, "Invalid Password.");
                }

                for (int i = 0; i < computeHash.Length; i++)
                {
                    if (computeHash[i] != dbHash[i])
                    {
                        return StatusCode(StatusCodes.Status401Unauthorized, "Invalid Password.");
                    }
                }

                // Return login user
                UserDTO user = _Mapper.Map<UserDTO>(foundUser);
                var token = _tokenService.CreateToken(foundUser);
                user.Token = token;

                return StatusCode(StatusCodes.Status200OK, user);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Server Error: {ex}");
            }
        }

        /// <summary>
        /// Verify the username and email.
        /// </summary>
        /// <param name="registerInfo">RegisterDTO</param>
        /// <returns>True if no match username or email</returns>
        private async Task<bool> newUserValidation(RegisterDTO registerInfo)
        {
            User userByUsername = await _unitOfWork.UserRepository.GetUserByUsernameAsync(registerInfo.username);
            User userByEmail = await _unitOfWork.UserRepository.GetUserByUsernameAsync(registerInfo.email);

            return userByUsername == null && userByEmail == null;
        }
    }
}
