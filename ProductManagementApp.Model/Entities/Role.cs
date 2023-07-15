/***************************
 * UserEntity: Contain user information.
 * File: User.cs
 * Author: Sam
 ***************************/

namespace ProductManagementApp.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Runtime.Serialization;
    
    [DataContract]
    [Table("Role", Schema = "AppUser")]
    public class Role : BaseEntity
    {
        [Required(ErrorMessage = "User Id Required.")]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string? Name { get; set; }
    }
}
