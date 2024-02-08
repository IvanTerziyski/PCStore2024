using PCStore.BL.Interfaces;
using PCStore.Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace PCStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _ProductService;
        public ProductController(IProductService ProductService)
        {
            _ProductService = ProductService;
        }

        [HttpGet("GetById")]
        public Product? GetProduct(int id)
        {
            return _ProductService.GetProduct(id);
        }

        [HttpPost("Add")]
        public void AddProduct([FromBody] Product Product)
        {
            _ProductService.AddProduct(Product);
        }

        [HttpDelete("Delete")]
        public void DeleteProduct(int id)
        {
            _ProductService.DeleteProduct(id);
        }

        [HttpPost("Update")]
        public void UpdateProduct([FromBody] Product Product)
        {
            _ProductService.UpdateProduct(Product);
        }

        [HttpGet("GetAllProducts")]
        public List<Product> GetAllProducts()
        {
            return _ProductService.GetAllProducts();
        }

    }
}
