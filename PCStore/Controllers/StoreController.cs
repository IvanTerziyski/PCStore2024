using Microsoft.AspNetCore.Mvc;
using PCStore.BL.Interfaces;
using PCStore.Models.Requests;
using PCStore.Models.Responces;

namespace PCStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        private readonly IStoreService _StoreService;
        public StoreController(IStoreService StoreService)
        {
            _StoreService = StoreService;
        }

        [HttpPost("GetAllProductsFromManufacturerAndDate")]
        public GetAllProductsFromManufacturerResponce?
            GetAllProductsFromManufacturerAndDate([FromBody] GetAllProductsFromManufacturerRequest request)
        {
            return _StoreService.GetAllProductsFromManufacturerAfterReleaseDate(request);
        }

    }
}
