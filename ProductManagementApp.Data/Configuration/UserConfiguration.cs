/***************************
 * UserConfiguration: configure and seed user data.
 * File: UserConfiguration.cs
 * Author: Sam
 ***************************/

namespace ProductManagementApp.Data.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Newtonsoft.Json;
    using ProductManagementApp.Model;

    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            //seeding data in the configuration
            // builder.HasData();
            
            // Base info
            Guid creator = Guid.Parse("4af36f59-a750-4d33-ab0a-c29e59defe11");
            DateTimeOffset baseDate = new DateTimeOffset(2023, 7, 11, 0, 0, 0, new TimeSpan(0, 0, 0));

            //var serializer = new JsonSerializer();
            //List<User> users = new List<User>();
            //using (StreamReader streamReader = File.OpenText(@"..\Json\User.json"))
            //using (var textRead = new JsonTextReader(streamReader)) 
            //{
            //   users = serializer.Deserialize<List<User>>(textRead);
            //}

            builder.HasData(
                new User { Id = Guid.Parse("1b1c209b-1af9-49f3-9d8b-c57d65752215"),
                            Username = "GavinP",
                            FirstName = "Gavin",
                            MiddleName = null,
                            LastName = "Poole",
                            Role = 2,
                            Phone = "(878)577-3238",
                            Address = "3948 123Ave, Edmonton, AB",
                            CreatedBy = creator,
                            CreatedDate = baseDate,
                            UpdatedBy = creator,
                            UpdatedDate = baseDate
                         }
                );
        }
    }
}
