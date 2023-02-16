using Microsoft.EntityFrameworkCore;
using Services.ProductAPI.Models;

namespace Services.ProductAPI.DBContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
