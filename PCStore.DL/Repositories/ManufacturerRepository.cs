using PCStore.DL.InMemoryDb;
using PCStore.DL.Interfaces;
using PCStore.Models.Models;


namespace PCStore.DL.Repositories
{
    public class ManufacturerRepository : IManufacturerRepository
    {
        public void AddManufacturer(Manufacturer Manufacturer)
        {
            StaticData.Manufacturers.Add(Manufacturer);
        }

        public void DeleteManufacturer(int id)
        {
            var Manufacturer = StaticData.Manufacturers.FirstOrDefault(m => m.Id == id);
            if (Manufacturer == null) return;
            StaticData.Manufacturers.Remove(Manufacturer);
        }

        public List<Manufacturer> GetAllManufacturers()
        {
            return StaticData.Manufacturers;
        }

        public Manufacturer? GetManufacturer(int id)
        {
            return StaticData.Manufacturers.FirstOrDefault(m => m.Id == id);
        }

        public void UpdateManufacturer(Manufacturer Manufacturer)
        {
            var existingManufacturer = StaticData.Manufacturers.FirstOrDefault(m => m.Id == Manufacturer.Id);
            if (existingManufacturer == null) return;

            StaticData.Manufacturers.Remove(existingManufacturer);

            StaticData.Manufacturers.Add(new Manufacturer()
            {
                Id = existingManufacturer.Id,
                Name = Manufacturer.Name,
                Description = Manufacturer.Description,
            });
        }
    }
}
