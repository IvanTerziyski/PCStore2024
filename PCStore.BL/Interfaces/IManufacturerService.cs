using PCStore.Models.Models;

namespace PCStore.BL.Interfaces
{
    public interface IManufacturerService
    {
        public void AddManufacturer(Manufacturer Manufacturer);

        public void DeleteManufacturer(int id);

        public void UpdateManufacturer(Manufacturer Manufacturer);


        public Manufacturer? GetManufacturer(int id);


        public List<Manufacturer> GetAllManufacturers();
    }
}
