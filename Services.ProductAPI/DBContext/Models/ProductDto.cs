using System.ComponentModel.DataAnnotations;

namespace Services.ProductAPI.DBContext.Models
{
    public class ProductDto
    {
        public Guid ProductId { get; set; }
        public string? Name { get; set; }
        public double Price { get; set; }
        public string? Description { get; set; }
        public string? CategoryName { get; set; }
    }
}
