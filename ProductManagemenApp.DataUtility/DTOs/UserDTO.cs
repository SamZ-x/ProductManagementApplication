/******************************************
 * RegisterDTO: contains user register info
 * File: RegisterDTO.cs
 * Author: Sam
 ******************************************/

namespace ProductManagementApp.DataUtility
{
    public class UserDTO
    {
        public string? Username { get; set; }

        public string? Token { get; set; }

        public string? Firstname { get; set; }

        public string? Middlename { get; set; }

        public string? Lastname { get; set; }

        public int Role { get; set; }

        public string? Email { get; set; }

        public string? Phone { get; set; }

        public string? Address { get; set; }
    }
}
