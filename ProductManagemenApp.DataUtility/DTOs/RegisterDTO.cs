/******************************************
 * RegisterDTO: contains user register info
 * File: RegisterDTO.cs
 * Author: Sam
 ******************************************/

namespace ProductManagementApp.DataUtility
{
    public class RegisterDTO
    {
        public string? username {  get; set; }

        public string? password { get; set; }

        public string? firstname { get; set; }

        public string? middlename { get; set; }

        public string? lastname { get; set; }

        public string? email { get; set; }

        public string? phone { get; set; }

        public string? address { get; set; }
    }
}
