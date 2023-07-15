/***************************
 * CategoryConfiguration: configure and seed Category data.
 * File: CategoryConfiguration.cs
 * Author: Sam
 ***************************/

namespace ProductManagementApp.Data
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using ProductManagementApp.Model;

    public class CategoryConfiguration: IEntityTypeConfiguration<Category>
    {
        // Base info
        Guid creator = Guid.Parse("4af36f59-a750-4d33-ab0a-c29e59defe11");
        DateTimeOffset baseDate = new DateTimeOffset(2023, 7, 11, 0, 0, 0, new TimeSpan(0, 0, 0));

        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category { Id = 1, Name = "Appetizer", CreatedBy = creator, CreatedDate = baseDate, UpdatedBy = creator, UpdatedDate = baseDate },
                new Category { Id = 2, Name = "Dimsum", CreatedBy = creator, CreatedDate = baseDate, UpdatedBy = creator, UpdatedDate = baseDate },
                new Category { Id = 3, Name = "FireRice", CreatedBy = creator, CreatedDate = baseDate, UpdatedBy = creator, UpdatedDate = baseDate },
                new Category { Id = 4, Name = "Noodle", CreatedBy = creator, CreatedDate = baseDate, UpdatedBy = creator, UpdatedDate = baseDate },
                new Category { Id = 5, Name = "All", CreatedBy = creator, CreatedDate = baseDate, UpdatedBy = creator, UpdatedDate = baseDate }
                );
        }
    }
}
