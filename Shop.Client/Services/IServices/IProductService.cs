using Frontend.Shop.Client.Models;

namespace Shop.Client.Services.IServices
{
    public interface IProductService :IBaseService
    {
        Task<T> GetAllProductsAsync<T>();
        Task<T> GetProductByIdAsync<T>(Guid id);
        Task<T> CreateProductAsync<T>(ProductDto productDto);
        Task<T> UpdateProductAsync<T>(ProductDto productDto);
        Task<T> DeleteProductAsync<T>(Guid id);
    }
}
