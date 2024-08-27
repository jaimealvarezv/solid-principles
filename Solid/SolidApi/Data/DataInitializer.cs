using Solid.Models;
using Solid.Repositories;

namespace Solid.Data
{
    public static class DataInitializer
    {
        public static void SeedData(IProductRepository productRepository)
        {
            productRepository.Add(new Product { Id = 1, Name = "Apple", Price = 1.00m, PhotoUrl = "https://example.com/apple.jpg", ExpirationDate = new DateTime(2024, 12, 31) });
            productRepository.Add(new Product { Id = 2, Name = "Banana", Price = 0.50m, PhotoUrl = "https://example.com/banana.jpg", ExpirationDate = new DateTime(2024, 12, 31) });
            productRepository.Add(new Product { Id = 3, Name = "Orange", Price = 0.75m, PhotoUrl = "https://example.com/orange.jpg", ExpirationDate = new DateTime(2024, 12, 31) });
            Console.WriteLine("Data Seeded");
        }
    }
}
