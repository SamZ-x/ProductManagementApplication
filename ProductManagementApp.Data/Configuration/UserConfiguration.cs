/***************************
 * UserConfiguration: configure and seed user data.
 * File: UserConfiguration.cs
 * Author: Sam
 ***************************/

namespace ProductManagementApp.Data
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using ProductManagementApp.Model;
    using System.IO;
    using System.Reflection;
    using System.Security.Cryptography;
    using System.Text;

    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        //seeding data in the configuration
        public void Configure(EntityTypeBuilder<User> builder)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Stream? stream = assembly.GetManifestResourceStream("ProductManagementApp.Data.Json.User.json");

            // Base info
            Guid creator = Guid.Parse("4af36f59-a750-4d33-ab0a-c29e59defe11");
            DateTimeOffset baseDate = new DateTimeOffset(2023, 7, 11, 0, 0, 0, new TimeSpan(0, 0, 0));

            // store user object
            List<User> users = new List<User>();

            // set test password
            string Password = "abcde12345";
            // create salt and hash
            byte[] rndSalt = new byte[64];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(rndSalt);
            }
            using var hmac = new HMACSHA512(rndSalt);
            var hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(Password));
            var key = rndSalt;

            using (StreamReader file = new StreamReader(stream))
            //using (StreamReader file = File.OpenText(pathTmp))
            {
                using (JsonTextReader textReader = new JsonTextReader(file))
                {
                    while (textReader.Read())
                    {
                        if (textReader.TokenType == JsonToken.StartObject)
                        {
                            JObject user = (JObject)JToken.ReadFrom(textReader);
                            //JObject users = JObject.Load(textRead);

                            User newUser = new User
                            {
                                Id = Guid.Parse((string)user["Id"]),
                                Username = (string)user["Username"],
                                PasswordHash = hash,
                                PasswordSalt = key,
                                FirstName = (string)user["FirstName"],
                                MiddleName = (string)user["MiddleName"],
                                LastName = (string)user["LastName"],
                                Role = (int)user["Role"],
                                Phone = (string)user["Phone"],
                                Email = (string)user["Email"],
                                Address = (string)user["Address"],
                                CreatedBy = creator,
                                CreatedDate = baseDate,
                                UpdatedBy = creator,
                                UpdatedDate = baseDate
                            };

                            users.Add(newUser);
                        }
                    }
                }
            }

            builder.HasData(users);

        }
    }
}
