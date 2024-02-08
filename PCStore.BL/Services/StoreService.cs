using PCStore.BL.Interfaces;
using PCStore.Models.Responces;
using PCStore.Models.Requests;

namespace PCStore.BL.Services
{
    public class StoreService : IStoreService
    {
        private readonly IManufacturerService _manufacturerService;
        private readonly IProductService _productService;
        public StoreService(IManufacturerService manufacturerService, IProductService productService)
        {
            _manufacturerService = manufacturerService;
            _productService = productService;
        }

        public int CheckProductCount(int input)
        {
            if (input < 0) return 0;
            var productCount = _productService.GetAllProducts();
            return productCount.Count + input;
        }

        public GetAllProductsFromManufacturerResponce 
            GetAllProductsFromManufacturerAfterReleaseDate(GetAllProductsFromManufacturerRequest request)
        {
            var response = new GetAllProductsFromManufacturerResponce();
            response.Manufacturer = _manufacturerService.GetManufacturer(request.ManufacturerId);
            response.Products = _productService.GetAllProductsFromManufacturerAfterReleaseDate
                (request.ManufacturerId, request.DateAfter);
            return response;
        }
    }
}
