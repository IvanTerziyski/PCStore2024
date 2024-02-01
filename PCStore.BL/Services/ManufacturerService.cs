using PCStore.BL.Interfaces;
using PCStore.DL.Interfaces;
using PCStore.Models.Models;

namespace PCStore.BL.Services
{
    public class ManufacturerService : IManufacturerService
    {
        private readonly IManufacturerRepository _ManufacturerRepository;
        public ManufacturerService(IManufacturerRepository ManufacturerRepository)
        {
            _ManufacturerRepository = ManufacturerRepository;
        }
        public void AddManufacturer(Manufacturer Manufacturer)
        {
            _ManufacturerRepository.AddManufacturer(Manufacturer);
        }

        public void DeleteManufacturer(int id)
        {
            _ManufacturerRepository.DeleteManufacturer(id);
        }

        public List<Manufacturer> GetAllManufacturers()
        {
            return _ManufacturerRepository.GetAllManufacturers();
        }

        public Manufacturer? GetManufacturer(int id)
        {
            return _ManufacturerRepository.GetManufacturer(id);
        }

        public void UpdateManufacturer(Manufacturer Manufacturer)
        {
            _ManufacturerRepository.UpdateManufacturer(Manufacturer);
        }
    }
}
