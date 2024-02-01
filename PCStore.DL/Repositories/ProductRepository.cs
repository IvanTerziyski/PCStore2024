using PCStore.DL.InMemoryDb;
using PCStore.DL.Interfaces;
using PCStore.Models.Models;

namespace PCStore.DL.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public void AddProduct(Product Product)
        {
            StaticData.Products.Add(Product);
        }

        public void DeleteProduct(int id)
        {
            var Product = StaticData.Products.FirstOrDefault(p => p.Id == id);
            if (Product == null) return;
            StaticData.Products.Remove(Product);
        }

        public List<Product> GetAllProducts()
        {
            return StaticData.Products;
        }

        //public List<Product> GetAllProductsByAuthor(int authorId)
        //{
        //    return InMemoryDb.StaticData.Products
        //            .Where(b => b.AuthorId == authorId)
        //            .ToList();
        //}

        public Product? GetProduct(int id)
        {
            return StaticData.Products.FirstOrDefault(p => p.Id == id);
        }

        public void UpdateProduct(Product Product)
        {
            var existingProduct = StaticData.Products.FirstOrDefault(p => p.Id == Product.Id);
            if (existingProduct == null) return;

            StaticData.Products.Remove(existingProduct);

            StaticData.Products.Add(new Product()
            {
                Id = existingProduct.Id,
                ProductName = Product.ProductName,
            });
        }
    }
}
