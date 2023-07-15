/***************************
 * ProductConfiguration: configure and seed Product data.
 * File: ProductConfiguration.cs
 * Author: Sam
 ***************************/

namespace ProductManagementApp.Data
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using ProductManagementApp.Model;

    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            // Base info
            Guid creator = Guid.Parse("4af36f59-a750-4d33-ab0a-c29e59defe11");
            DateTimeOffset baseDate = new DateTimeOffset(2023, 7, 11, 0, 0, 0, new TimeSpan(0, 0, 0));

            builder.HasData(
                new Product { Id = Guid.Parse("34e9683e-7421-4421-bcfe-15015391cc1e"),
                              Name = "SpicyPork Bun",
                              Category = 2,
                              IngredientList = null,
                              CostPrice = 1.2,
                              SalePrice = 6,
                              Unit = "pack",
                              ManHour = 1,
                              IsContinuing = true,
                              OutOfStock = false,
                              Stock = 999,
                              CreatedBy = creator,
                              CreatedDate = baseDate,
                              UpdatedBy = creator,
                              UpdatedDate = baseDate,
                },
                 new Product
                 {
                     Id = Guid.Parse("1a96b935-0bdd-4a9f-98e9-d4be5dc1146e"),
                     Name = "Sweet Wings",
                     Category = 1,
                     IngredientList = null,
                     CostPrice = 4.3,
                     SalePrice = 8,
                     Unit = "pack",
                     ManHour = 1,
                     IsContinuing = true,
                     OutOfStock = false,
                     Stock = 999,
                     CreatedBy = creator,
                     CreatedDate = baseDate,
                     UpdatedBy = creator,
                     UpdatedDate = baseDate,
                 },
                  new Product
                  {
                      Id = Guid.Parse("88e708ac-47a9-4dab-aaf4-d75b2e1a039e"),
                      Name = "ShangHai Fire Noodle",
                      Category = 4,
                      IngredientList = null,
                      CostPrice = 5.5,
                      SalePrice = 9,
                      Unit = "each",
                      ManHour = 1,
                      IsContinuing = true,
                      OutOfStock = false,
                      Stock = 999,
                      CreatedBy = creator,
                      CreatedDate = baseDate,
                      UpdatedBy = creator,
                      UpdatedDate = baseDate,
                  },
                   new Product
                   {
                       Id = Guid.Parse("9d37e8bd-c979-4b47-9c87-0a530e0c19a0"),
                       Name = "Beef Rice",
                       Category = 3,
                       IngredientList = null,
                       CostPrice = 3.5,
                       SalePrice = 8,
                       Unit = "each",
                       ManHour = 1,
                       IsContinuing = true,
                       OutOfStock = false,
                       Stock = 999,
                       CreatedBy = creator,
                       CreatedDate = baseDate,
                       UpdatedBy = creator,
                       UpdatedDate = baseDate,
                   },
                    new Product
                    {
                        Id = Guid.Parse("0568983b-5e73-49cf-9829-544e49febb2e"),
                        Name = "Mix Vegetable Soup",
                        Category = 1,
                        IngredientList = null,
                        CostPrice = 1.9,
                        SalePrice = 3.5,
                        Unit = "each",
                        ManHour = 1,
                        IsContinuing = true,
                        OutOfStock = false,
                        Stock = 999,
                        CreatedBy = creator,
                        CreatedDate = baseDate,
                        UpdatedBy = creator,
                        UpdatedDate = baseDate,
                    }
                );


        }
    }
}
