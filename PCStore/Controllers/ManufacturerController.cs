using Microsoft.AspNetCore.Mvc;
using PCStore.BL.Interfaces;
using PCStore.Models.Models;

namespace PCStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManufacturerController : ControllerBase
    {
        private readonly IManufacturerService _ManufacturerService;
        public ManufacturerController(IManufacturerService ManufacturerService)
        {
            _ManufacturerService = ManufacturerService;
        }

        [HttpGet("GetById")]
        public Manufacturer? GetManufacturer(int id)
        {
            return _ManufacturerService.GetManufacturer(id);
        }

        [HttpPost("Add")]
        public void AddManufacturer([FromBody] Manufacturer Manufacturer)
        {
            _ManufacturerService.AddManufacturer(Manufacturer);
        }

        [HttpDelete("Delete")]
        public void DeleteManufacturer(int id)
        {
            _ManufacturerService.DeleteManufacturer(id);
        }

        [HttpPost("Update")]
        public void UpdateManufacturer([FromBody] Manufacturer Manufacturer)
        {
            _ManufacturerService.UpdateManufacturer(Manufacturer);
        }

        [HttpGet("GetAllManufacturers")]
        public List<Manufacturer> GetAllManufacturers()
        {
            return _ManufacturerService.GetAllManufacturers();
        }

    }
}
