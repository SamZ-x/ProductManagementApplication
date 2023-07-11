/***************************
 * ProductEntity: Contain product information.
 * File: Product.cs
 * Author: Sam
 ***************************/

namespace ProductManagementApp.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Runtime.Serialization;

    // #TOD: data annotations need to be review  
    [DataContract]
    [Table("Product", Schema = "Product")]
    public class Product : BaseEntity
    {
        [Required(ErrorMessage = "Product Id Required.")]
        public Guid Id { get; set; }

        [MaxLength(100)]
        public string? Name { get; set; }

        public int Category { get; set; }

        public IReadOnlyDictionary<Guid, double>? IngredientList { get; set; }

        public double CostPrice { get; set; }

        public double SalePrice { get; set; }

        public string? Unit { get; set; }

        public double ManHour { get; set; }

        public bool IsContinuing { get; set; }

        public bool OutOfStock { get; set; }

        // #TODO: enable when start the implement the feature
        // public Blob Image { get; set; }
    }
}
