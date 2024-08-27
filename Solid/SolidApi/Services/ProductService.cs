using Solid.Models;
using Solid.Repositories;

namespace Solid.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IEnumerable<Product> GetAll() => _productRepository.GetAll();

        public Product GetById(int id) => _productRepository.GetById(id);

        public void Add(Product product) => _productRepository.Add(product);

        public void Update(Product product) => _productRepository.Update(product);

        public void Delete(int id) => _productRepository.Delete(id);
    }
}
