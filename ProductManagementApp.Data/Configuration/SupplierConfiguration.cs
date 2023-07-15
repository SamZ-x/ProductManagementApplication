/***************************
 * SupplierConfiguration: configure and seed Supplier data.
 * File: SupplierConfiguration.cs
 * Author: Sam
 ***************************/

namespace ProductManagementApp.Data
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using ProductManagementApp.Model;

    public class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            // Base info
            Guid creator = Guid.Parse("4af36f59-a750-4d33-ab0a-c29e59defe11");
            DateTimeOffset baseDate = new DateTimeOffset(2023, 7, 11, 0, 0, 0, new TimeSpan(0, 0, 0));

            builder.HasData(
                new Supplier
                {
                    Id = Guid.Parse("1bf9df1a-26a5-4852-9f45-94f1d6c0131e"),
                    CompanyName = "WangDa Wholesale",
                    Phone = "(780)445-1458",
                    Email = "wdwhole@yahoo.com",
                    Address = "4588 104St SE, Edmonton, AB",
                    SalesName = "Alex",
                    CreatedBy = creator,
                    CreatedDate = baseDate,
                    UpdatedBy = creator,
                    UpdatedDate = baseDate
                });
        }
    }
}
