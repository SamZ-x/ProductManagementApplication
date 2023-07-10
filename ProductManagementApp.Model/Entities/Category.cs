/***************************
 * CategoryEntity: Contain Category information.
 * File: Category.cs
 * Author: Sam
 ***************************/

namespace ProductManagementApp.Model
{
    using System.ComponentModel.DataAnnotations;

    public class Category : BaseEntity
    {
        [Required(ErrorMessage = "Category Id Required.")]
        public int Id { get; set; }

        [MaxLength(100)]
        public string? Name { get; set; }

        [MaxLength(1000)]
        public string? Description { get; set; }
    }
}
