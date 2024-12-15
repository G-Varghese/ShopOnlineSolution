using Microsoft.AspNetCore.Components;
using ShopOnline.Models.Dtos;
using ShopOnline.Web.Services.Contracts;

namespace ShopOnline.Web.Pages
{
    public class ProductDetailsBase : ComponentBase
    {
        [Parameter]
        public int Id { get; set; }

        [Inject]
        public IProductService? ProductService { get; set; }

        public ProductDto? Product { get; set; }

        public string ErrorMessage { get; set; } = string.Empty;

        protected override async Task OnInitializedAsync()
        {
            Console.WriteLine($"Product ID from URL: {Id}"); // This will help you debug if the Id is passed correctly.

            if (ProductService == null)
            {
                ErrorMessage = "ProductService is not available.";
                return;
            }

            try
            {
                Product = await ProductService.GetItem(Id);
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }
    }
}
