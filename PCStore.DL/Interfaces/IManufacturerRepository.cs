using PCStore.Models.Models;

namespace PCStore.DL.Interfaces
{
    public interface IManufacturerRepository
    {
        public void AddManufacturer(Manufacturer manufacturer);

        public void DeleteManufacturer(int id);

        public void UpdateManufacturer(Manufacturer manufacturer);

        public Manufacturer? GetManufacturer(int id);

        public List<Manufacturer> GetAllManufacturers();
    }
}
