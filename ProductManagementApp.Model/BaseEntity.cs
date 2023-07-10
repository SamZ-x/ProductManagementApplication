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
        public Guid CreateBy { get; set; }

        // #TODO: use default value or set to 'required' 
        public DateTimeOffset CreateDate { get; set; } = DateTimeOffset.UtcNow;

        [Required]
        public Guid UpdateBy { get; set; }

        // #TODO: use default value or set to 'required' 
        public DateTimeOffset UpdateDate { get; set; } = DateTimeOffset.UtcNow;
    }
}