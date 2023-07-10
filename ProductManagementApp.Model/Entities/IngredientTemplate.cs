/***************************
 * IngredientTemplateEntity: Contain ingredient template information.
 * File: IngredientTemplate.cs
 * Author: Sam
 ***************************/

namespace ProductManagementApp.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class IngredientTemplate : BaseEntity
    {
        [Required(ErrorMessage = "IngredientTemplate Id Required.")]
        public Guid Id { get; set; }

        [MaxLength(100)]
        public string? Name { get; set; }

        [MaxLength(1000)]
        public string? Description { get; set; }

        public int Category { get; set; }

        [NotMapped] 
        // #TODO: error : "The property 'IngredientTemplate.IngredientList' could not be mapped because it is of type 'IReadOnlyDictionary<Guid, double>',
        // which is not a supported primitive type or a valid entity type."
        public IReadOnlyDictionary<Guid, double>? IngredientList { get; set; }

        public double TotalCost { get; set; }
    }
}
