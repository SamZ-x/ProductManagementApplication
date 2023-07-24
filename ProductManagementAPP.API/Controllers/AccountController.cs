/*
 * Controller: Account endpoints (login, register)
 * File: AccountController.cs
 * Author: Sam
 */

namespace ProductManagementApp.API.Controllers
{
    using Microsoft.AspNetCore.Http.HttpResults;
    using Microsoft.AspNetCore.Mvc;
    using ProductManagementApp.Data;
    using ProductManagementApp.DataUtility;
    using ProductManagementApp.Model;

    public class AccountController: BaseApiController
    {
        // db connection
        private readonly PMDataContext _PMDataContext;

        public AccountController(PMDataContext PMDataContext)
        {
            _PMDataContext = PMDataContext;
        }

        // User register
        // receive user object from front End
        // map properties and create a new user entity
        // add new user to db
        // response: 200 with new user?
        [HttpPost, Route("register")]
        public IActionResult Register([FromBody] RegisterDTO registerInfo)
        {
            Guid newUserId = Guid.NewGuid();

            User newUser = new User
            {
                Id = newUserId,
                Username = registerInfo.username,
                Password = registerInfo.password,
                FirstName = registerInfo.firstname,
                MiddleName = registerInfo.middlename,
                LastName = registerInfo.lastname,
                Role = 1,
                Phone = registerInfo.phone,
                Email = registerInfo.email,
                Address = registerInfo.address
            };

            _PMDataContext.User.Add( newUser );

            var result = _PMDataContext.SaveChanges();

            if (result == 1)
            {
                return Ok("Succeed");
            }

            return StatusCode(StatusCodes.Status400BadRequest, "failed to add new user!");
        }
    }
}
