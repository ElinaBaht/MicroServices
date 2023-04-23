using Microsoft.EntityFrameworkCore;
using Services.ProductAPI.DBContext.Models.Dto;

namespace Services.ProductAPI.DBContext
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = Guid.NewGuid(),
                Name = "Snacks",
                Price = 15,
                Description = "Test",
                CategoryName = "Appetizer"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = Guid.NewGuid(),
                Name = "Salad",
                Price = 10,
                Description = "Test",
                CategoryName = "Appetizer"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = Guid.NewGuid(),
                Name = "Pie",
                Price = 8.99,
                Description = "Test",
                CategoryName = "Dessert"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = Guid.NewGuid(),
                Name = "Pasta",
                Price = 18,
                Description = "Test",
                CategoryName = "Entree"
            });
        }
    }
}
