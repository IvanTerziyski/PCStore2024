using PCStore.Models.Models;

namespace PCStore.BL.Interfaces
{
    public interface IProductService
    {
        public void AddProduct(Product product);

        public void DeleteProduct(int id);

        public void UpdateProduct(Product product);


        public Product? GetProduct(int id);

        public List<Product> GetAllProductsFromManufacturerAfterReleaseDate(int ManufacturerId, DateTime DateAfter);
        public List<Product> GetAllProducts();
    }
}
