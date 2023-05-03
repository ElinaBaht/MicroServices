using Frontend.Shop.Client.Models;
using Microsoft.AspNetCore.Components;
using Shop.Client.Services.IServices;
using System.Runtime.CompilerServices;

namespace Shop.Client.Pages
{
	public partial class ProductDetails
	{
		protected string Message = string.Empty;
		protected ProductDto product { get;set; } = new ProductDto();
		[Parameter]
		public string Id { get; set; }

		[Inject]
		private IProductService productService { get; set; }

		[Inject]
		private NavigationManager navigationManager { get; set; }

		protected async override Task OnInitializedAsync()
		{
			if(string.IsNullOrEmpty(Id))
			{
				//Adding a new product
			}
			else
			{
				//Update product
			}
		}
	}
}
