/***************************
 * OrderEntity: Contain Order information.
 * File: Order.cs
 * Author: Sam
 ***************************/

namespace ProductManagementApp.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Runtime.Serialization;

    [DataContract]
    [Table("Order", Schema = "Product")]
    public class Order : BaseEntity
    {
        [Required(ErrorMessage = "Order Id Required.")]
        public Guid Id { get; set; }

        public DateTimeOffset StartingDate { get; set; }

        public DateTimeOffset DeliveryDate { get; set; }

        [NotMapped] // #TODO: error
        public IReadOnlyDictionary<Guid, int>? ItemList { get; set; }

        public double OrderAmount { get; set; }

        public double AppliedDiscount { get; set; }

        public double CreditAmount { get; set; }

        public Guid Client { get; set; }

    }
}
