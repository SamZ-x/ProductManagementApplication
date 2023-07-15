/***************************
 * IngredientTemplateConfiguration: configure and seed IngredientTemplate data.
 * File: IngredientTemplateConfiguration.cs
 * Author: Sam
 ***************************/

namespace ProductManagementApp.Data
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using ProductManagementApp.Model;

    public class IngredientTemplateConfiguration : IEntityTypeConfiguration<IngredientTemplate>
    {
        public void Configure(EntityTypeBuilder<IngredientTemplate> builder)
        {
            // Base info
            Guid creator = Guid.Parse("4af36f59-a750-4d33-ab0a-c29e59defe11");
            DateTimeOffset baseDate = new DateTimeOffset(2023, 7, 11, 0, 0, 0, new TimeSpan(0, 0, 0));

            Dictionary<Guid, double> baseIngredient = new Dictionary<Guid, double>() {
                { Guid.Parse("04cc37d8-555a-4139-94f4-a2d26cacad4a"), 5.0 },
                { Guid.Parse("f8e9be1a-49f3-401a-9d5e-26926b18b730"), 3.0 }
            };

            Dictionary<Guid, double> bunBaseIngredient = new Dictionary<Guid, double>() {
                { Guid.Parse("04cc37d8-555a-4139-94f4-a2d26cacad4a"), 5.0 },
                { Guid.Parse("f8e9be1a-49f3-401a-9d5e-26926b18b730"), 30.0 },
                { Guid.Parse("764ba3c5-ae6a-4ee2-be7d-bd69fe0f6462"), 200.0 }
            };

            builder.HasData(
                new IngredientTemplate { Id = Guid.Parse("dcda4b0c-dc6e-4644-bc95-bb21b3501c04"), Name = "flavor Base", Description = "Basic flavor", Category = 5, IngredientList = baseIngredient, CreatedBy = creator, CreatedDate = baseDate, UpdatedBy = creator , UpdatedDate = baseDate},
                new IngredientTemplate { Id = Guid.Parse("7f9ac754-d077-4818-9df3-2c23ef5a1c0e"), Name = "Bun Base", Description = "Basic ingredient of making buns", Category = 2, IngredientList = bunBaseIngredient, CreatedBy = creator, CreatedDate = baseDate, UpdatedBy = creator, UpdatedDate = baseDate }
                );
        }
    }
}
