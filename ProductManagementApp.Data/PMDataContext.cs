/*
 * DataContext: contains data sets.
 * File: DataContext.cs
 * Author: Sam
 */

namespace ProductManagementApp.Data
{
    using Microsoft.EntityFrameworkCore;
    using Newtonsoft.Json;
    using ProductManagementApp.Model;

    public class PMDataContext : DbContext
    {
        public PMDataContext(DbContextOptions<PMDataContext> options) : base (options) { }
        
        // data tables
        public DbSet<Category> Category { get; set; }
         
        public DbSet<Ingredient> Ingredient { get; set;}

        public DbSet<IngredientTemplate> IngredientTemplate { get; set; }

        public DbSet<Order> Order { get; set; }

        public DbSet<Product> Product { get; set; }

        public DbSet<Supplier> Supplier { get; set; }

        public DbSet<User> User { get; set; }

        public DbSet<Role> Role { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Add type conversion
            modelBuilder.Entity<Product>().Property(e => e.IngredientList).HasConversion(
                d => JsonConvert.SerializeObject(d),
                d => JsonConvert.DeserializeObject<IReadOnlyDictionary<Guid, double>>(d));
            modelBuilder.Entity<Order>().Property(e => e.ItemList).HasConversion(
                d => JsonConvert.SerializeObject(d),
                d => JsonConvert.DeserializeObject<IReadOnlyDictionary<Guid, int>>(d));
            modelBuilder.Entity<IngredientTemplate>().Property(e => e.IngredientList).HasConversion(
                d => JsonConvert.SerializeObject(d),
                d => JsonConvert.DeserializeObject<IReadOnlyDictionary<Guid, double>>(d));

            // Add table key
            modelBuilder.Entity<User>().HasKey(x => new { x.Id });
            modelBuilder.Entity<Supplier>().HasKey(x => new { x.Id });
            modelBuilder.Entity<Category>().HasKey(x => new { x.Id });
            modelBuilder.Entity<Product>().HasKey(x => new { x.Id });
            modelBuilder.Entity<Order>().HasKey(x => new { x.Id });
            modelBuilder.Entity<IngredientTemplate>().HasKey(x => new { x.Id });
            modelBuilder.Entity<Ingredient>().HasKey(x => new { x.Id });
            modelBuilder.Entity<Role>().HasKey(x => new { x.Id });

            // Apply model configuration
            // Seeding data.
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new IngredientConfiguration());
            modelBuilder.ApplyConfiguration(new IngredientTemplateConfiguration());
            modelBuilder.ApplyConfiguration(new SupplierConfiguration());
        }
    }
}