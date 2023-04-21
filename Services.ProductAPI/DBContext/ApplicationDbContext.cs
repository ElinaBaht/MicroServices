using Microsoft.EntityFrameworkCore;
using Services.ProductAPI.DBContext.Models.Dto;

namespace Services.ProductAPI.DBContext
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
    }
}
