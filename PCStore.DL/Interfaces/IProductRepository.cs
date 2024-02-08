using PCStore.Models.Models;

namespace PCStore.DL.Interfaces
{
    public interface IProductRepository
    {
        public void AddProduct(Product product);

        public void DeleteProduct(int id);

        public void UpdateProduct(Product product);

        public Product? GetProduct(int id);

        public List<Product> GetAllProducts();

        public List<Product> GetAllProductsByManufacturer(int ManufacturerId);
    }
}
