using Solid.Models;

namespace Solid.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> _products = new List<Product>();

        public IEnumerable<Product> GetAll() => _products;

        public Product GetById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id) ?? throw new Exception("Product not found");
        }

        public void Add(Product product) => _products.Add(product);

        public void Update(Product product)
        {
            var existingProduct = GetById(product.Id);
            if (existingProduct != null)
            {
                existingProduct.Name = product.Name;
                existingProduct.Price = product.Price;
                existingProduct.PhotoUrl = product.PhotoUrl;
                existingProduct.ExpirationDate = product.ExpirationDate;
            }
        }

        public void Delete(int id)
        {
            var product = GetById(id);
            if (product != null) _products.Remove(product);
        }
    }
}
