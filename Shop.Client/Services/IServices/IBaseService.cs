using Frontend.Shop.Client.Models;
using Shop.Client.Models;

namespace Shop.Client.Services.IServices
{
    public interface IBaseService :IDisposable
    {
        ResponseDto responseModel { get; set; }
        Task<T> SendAsync<T>(ApiRequest apiRequest);
    }
}
