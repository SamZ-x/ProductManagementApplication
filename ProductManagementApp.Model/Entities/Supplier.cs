/***************************
 * SupplierEntity: Contain Supplier information.
 * File: User.cs
 * Author: Sam
 ***************************/

namespace ProductManagementApp.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Supplier", Schema = "Product")]
    public class Supplier : BaseEntity
    {
        [Required(ErrorMessage ="Supplier Id Required.")]
        public Guid Id { get; set; }

        [MaxLength(100)]
        public string? CompanyName { get; set; }

        [DataType(DataType.EmailAddress)]
        [MaxLength(100)]
        public string? Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        [MaxLength(20)]
        public string? Phone { get; set; }

        [MaxLength(1000)]
        public string? Address { get; set; }

        [MaxLength(100)]
        public string? SalesName { get; set; }
    }
}
