using Frontend.Shop.Client.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using Shop.Client.Services.IServices;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Shop.Client.Pages
{
    public partial class Products
    {
        [Inject]
        private IProductService productService { get; set; }
        public List<ProductDto> list { get; set; } = new();

        protected async override Task OnInitializedAsync()
        {
            var response = await productService.GetAllProductsAsync<ResponseDto>();

            if (response != null && response.IsSuccess)
            {
                list = JsonConvert.DeserializeObject<List<ProductDto>>(Convert.ToString(response.Result));
            }
        }
    }
}
