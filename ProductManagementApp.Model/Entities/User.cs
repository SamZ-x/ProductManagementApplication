/***************************
 * UserEntity: Contain user information.
 * File: User.cs
 * Author: Sam
 ***************************/

namespace ProductManagementApp.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("User", Schema = "AppUser")]
    public class User : BaseEntity
    {
        [Required(ErrorMessage = "User Id Required.")]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Username { get; set; }

        [Required]
        [MaxLength(100)]
        public string? FirstName { get; set; }

        [MaxLength(100)]
        public string? MiddleName { get; set; }

        [Required]
        [MaxLength(100)]
        public string? LastName { get; set; }

        [Required]
        public int Role { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string? Phone { get; set; }

        [MaxLength(1000)]
        public string? Address { get; set; }
    }
}
