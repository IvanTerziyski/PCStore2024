using PCStore.Models.Models;

namespace PCStore.DL.InMemoryDb
{
    internal class StaticData
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product()
            {
                Id = 1,
                ProductName = "Laptop 1",
                ManufacturerId = 1,
                ReleaseDate = new DateTime(2006,10,10)
            },
            new Product()
            {
                Id = 2,
                ProductName = "Laptop 2",
                ManufacturerId = 2,
                ReleaseDate = new DateTime(2010,04,26)
            },
            new Product()
            {
                Id = 3,
                ProductName = "PC 1",
                ManufacturerId = 3,
                ReleaseDate = new DateTime(2012,12,20)
            },
            new Product()
            {
                Id = 4,
                ProductName = "PC 2",
                ManufacturerId = 1,
                ReleaseDate = new DateTime(2015,08,20)
            },
        };
        public static List<Manufacturer> Manufacturers = new List<Manufacturer>()
        {
            new Manufacturer()
            {
                Id = 1,
                Name = "Acer",
                Description = "Acer Inc. is a Taiwanese multinational hardware and electronics corporation specializing " +
                "in advanced electronics technology, headquartered in Xizhi, New Taipei City."
            },
            new Manufacturer()
            {
                Id = 2,
                Name = "Lenovo",
                Description = "Lenovo Group Limited, doing business as Lenovo, is a Chinese multinational technology company " +
                "specializing in designing, manufacturing, and marketing consumer electronics, personal computers, software and related services."
            },
            new Manufacturer()
            {
                Id = 3,
                Name = "Dell",
                Description = "Dell Inc. is an American technology company that develops, sells, repairs, " +
                "and supports computers and related products and services. Dell is owned by its parent company, Dell Technologies."
            },
        };
    }
}
