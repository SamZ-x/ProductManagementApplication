/*
 * DataContext: contains data sets.
 * File: DataContext.cs
 * Author: Sam
 */

namespace ProductManagementApp.Data
{
    using Microsoft.EntityFrameworkCore;
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
    }
}