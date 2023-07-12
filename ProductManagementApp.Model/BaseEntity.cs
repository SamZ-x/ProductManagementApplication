/***************************
 * BaseEntity: Contain common fields all entities
 * File: BaseEntity.cs
 * Author: Sam
 ***************************/

namespace ProductManagementApp.Model
{
    using System.ComponentModel.DataAnnotations;

    public class BaseEntity
    {
        [Required]
        public Guid CreatedBy { get; set; }

        // #TODO: use default value or set to 'required' 
        public DateTimeOffset CreatedDate { get; set; } = DateTimeOffset.UtcNow;

        [Required]
        public Guid UpdatedBy { get; set; }

        // #TODO: use default value or set to 'required' 
        public DateTimeOffset UpdatedDate { get; set; } = DateTimeOffset.UtcNow;
    }
}