using PCStore.BL.Interfaces;
using PCStore.DL.Interfaces;
using PCStore.Models.Models;

namespace PCStore.BL.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _ProductRepository;
        public ProductService(IProductRepository ProductRepository)
        {
            _ProductRepository = ProductRepository;
        }
        public void AddProduct(Product Product)
        {
            _ProductRepository.AddProduct(Product);
        }

        public void DeleteProduct(int id)
        {
            _ProductRepository.DeleteProduct(id);
        }

        public List<Product> GetAllProducts()
        {
            return _ProductRepository.GetAllProducts();
        }

        //public List<Product> GetAllProductsByAuthorAfterReleaseDate(int authorId, DateTime DateAfter)
        //{
        //    var result = _ProductRepository.GetAllProductsByAuthor(authorId);
        //    return result.Where(b => b.ReleaseDate >= DateAfter).ToList();
        //}

        public Product? GetProduct(int id)
        {
            return _ProductRepository.GetProduct(id);
        }

        public void UpdateProduct(Product Product)
        {
            _ProductRepository.UpdateProduct(Product);
        }
    }
}
