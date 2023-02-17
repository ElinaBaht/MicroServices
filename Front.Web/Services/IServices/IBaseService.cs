using Front.Web.Models;

namespace Front.Web.Services.IServices
{
    public interface IBaseService :IDisposable
    {
        ResponseDto responseModal { get; set; }
        Task<T> SendAsync<T>(ApiRequest apiRequest);

    }
}
