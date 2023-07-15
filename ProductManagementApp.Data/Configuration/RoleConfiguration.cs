/***************************
 * RoleConfiguration: configure and seed Role data.
 * File: RoleConfiguration.cs
 * Author: Sam
 ***************************/

namespace ProductManagementApp.Data
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using ProductManagementApp.Model;

    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            // Base info
            Guid creator = Guid.Parse("4af36f59-a750-4d33-ab0a-c29e59defe11");
            DateTimeOffset baseDate = new DateTimeOffset(2023, 7, 11, 0, 0, 0, new TimeSpan(0, 0, 0));

            builder.HasData( 
                new Role { Id = 1, Name = "SysAdmin", CreatedBy = creator, CreatedDate = baseDate, UpdatedBy = creator, UpdatedDate = baseDate },
                new Role { Id = 2, Name = "Merchant", CreatedBy = creator, CreatedDate = baseDate, UpdatedBy = creator, UpdatedDate = baseDate },
                new Role { Id = 3, Name = "Supplier", CreatedBy = creator, CreatedDate = baseDate, UpdatedBy = creator, UpdatedDate = baseDate },
                new Role { Id = 4, Name = "Customer", CreatedBy = creator, CreatedDate = baseDate, UpdatedBy = creator, UpdatedDate = baseDate }
            );
        }
    }
}
