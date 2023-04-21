using System.ComponentModel.DataAnnotations;

namespace Services.ProductAPI.DBContext.Models.Dto
{
    public class Product
    {
        [Key]
        public Guid ProductId { get; set; }
        [Required]
        public string? Name { get; set; }
        [Range(1, 1000)]
        public double Price { get; set; }
        public string? Description { get; set; }
        public string? CategoryName { get; set; }

    }
}
