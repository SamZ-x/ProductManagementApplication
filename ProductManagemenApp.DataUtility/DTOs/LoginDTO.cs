/******************************************
 * RegisterDTO: contains user register info
 * File: RegisterDTO.cs
 * Author: Sam
 ******************************************/

namespace ProductManagementApp.DataUtility
{
    using System.ComponentModel.DataAnnotations;

    public class LoginDTO
    {
        // could be username or email.
        [Required]
        public string? UserId { get; set; }

        public string? Password { get; set; }
    }
}
