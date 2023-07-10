/***************************
 * IngredientEntity: Contain ingredient information.
 * File: Ingredient.cs
 * Author: Sam
 ***************************/

using System.ComponentModel.DataAnnotations;

namespace ProductManagementApp.Model
{
    public class Ingredient : BaseEntity
    {
        [Required(ErrorMessage = "Ingredient Id Required.")]
        public Guid Id { get; set; }

        public string? Code { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public string? brand { get; set; }

        public Guid CurrentSupplier { get; set; }

        public double PrimeCost { get; set; }

        public string? Unit { get; set; }

        public string? UsageUnit { get; set; }

        public double CostPerUnit { get; set; }

        public double HistoryHighPrice { get; set; }

        public double HistoryLowPrice { get; set;}
    }
}
