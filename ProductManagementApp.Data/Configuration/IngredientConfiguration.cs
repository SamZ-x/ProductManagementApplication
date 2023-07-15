/***************************
 * IngredientConfiguration: configure and seed Ingredient data.
 * File: IngredientConfiguration.cs
 * Author: Sam
 ***************************/

namespace ProductManagementApp.Data
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using ProductManagementApp.Model;

    public class IngredientConfiguration : IEntityTypeConfiguration<Ingredient>
    {
        public void Configure(EntityTypeBuilder<Ingredient> builder)
        {
            // Base info
            Guid creator = Guid.Parse("4af36f59-a750-4d33-ab0a-c29e59defe11");
            DateTimeOffset baseDate = new DateTimeOffset(2023, 7, 11, 0, 0, 0, new TimeSpan(0, 0, 0));

            builder.HasData(
                new Ingredient { Id = Guid.Parse("04cc37d8-555a-4139-94f4-a2d26cacad4a"), Code = "I001", Name = "Salt", Description = null, Brand = "NoName", CurrentSupplier = Guid.Parse("1bf9df1a-26a5-4852-9f45-94f1d6c0131e"), PrimeCost = 14, Quantity = 5, Unit = "Kg", UsageUnit = "g", HistoryHighPrice = 14, HistoryLowPrice = 12, CreatedBy = creator, CreatedDate = baseDate, UpdatedBy = creator, UpdatedDate = baseDate },
                new Ingredient { Id = Guid.Parse("f8e9be1a-49f3-401a-9d5e-26926b18b730"), Code = "I002", Name = "Sugar", Description = null, Brand = "NoName", CurrentSupplier = Guid.Parse("1bf9df1a-26a5-4852-9f45-94f1d6c0131e"), PrimeCost = 15, Quantity = 5, Unit = "Kg", UsageUnit = "g", HistoryHighPrice = 15, HistoryLowPrice = 13, CreatedBy = creator, CreatedDate = baseDate, UpdatedBy = creator, UpdatedDate = baseDate },
                new Ingredient { Id = Guid.Parse("764ba3c5-ae6a-4ee2-be7d-bd69fe0f6462"), Code = "I003", Name = "Wheat Flour", Description = null, Brand = "NoName", CurrentSupplier = Guid.Parse("1bf9df1a-26a5-4852-9f45-94f1d6c0131e"), PrimeCost = 10, Quantity = 5, Unit = "Kg", UsageUnit = "g", HistoryHighPrice = 10, HistoryLowPrice = 9, CreatedBy = creator, CreatedDate = baseDate, UpdatedBy = creator, UpdatedDate = baseDate },
                new Ingredient { Id = Guid.Parse("63829485-1afd-4e21-910f-553363736493"), Code = "I004", Name = "Rice Noodle", Description = null, Brand = "NoName", CurrentSupplier = Guid.Parse("1bf9df1a-26a5-4852-9f45-94f1d6c0131e"), PrimeCost = 34, Quantity = 30, Unit = "lb", UsageUnit = "g", HistoryHighPrice = 34, HistoryLowPrice = 24, CreatedBy = creator, CreatedDate = baseDate, UpdatedBy = creator, UpdatedDate = baseDate },
                new Ingredient { Id = Guid.Parse("b59619f1-bae6-442a-a3f6-ef8487542a7b"), Code = "I005", Name = "Rice", Description = null, Brand = "NoName", CurrentSupplier = Guid.Parse("1bf9df1a-26a5-4852-9f45-94f1d6c0131e"), PrimeCost = 34, Quantity = 30, Unit = "kg", UsageUnit = "g", HistoryHighPrice = 34, HistoryLowPrice = 31, CreatedBy = creator, CreatedDate = baseDate, UpdatedBy = creator, UpdatedDate = baseDate },
                new Ingredient { Id = Guid.Parse("1e674b1e-db3f-4466-93d0-895832c43266"), Code = "I006", Name = "Soya", Description = null, Brand = "NoName", CurrentSupplier = Guid.Parse("1bf9df1a-26a5-4852-9f45-94f1d6c0131e"), PrimeCost = 45, Quantity = 20, Unit = "L", UsageUnit = "g", HistoryHighPrice = 45, HistoryLowPrice = 40, CreatedBy = creator, CreatedDate = baseDate, UpdatedBy = creator, UpdatedDate = baseDate }
                );
        }
    }
}
