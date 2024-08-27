using Microsoft.AspNetCore.Mvc;
using NoSolidApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace NoSolidApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private static List<Product> products = new List<Product>
        {
            new Product { ID = 1, Name = "Producto 1", Price = 100, Photo = "foto1.jpg", ExpiryDate = DateTime.Now.AddDays(10) },
            new Product { ID = 2, Name = "Producto 2", Price = 200, Photo = "foto2.jpg", ExpiryDate = DateTime.Now.AddDays(20) }
        };

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var product = products.FirstOrDefault(p => p.ID == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            product.ID = products.Max(p => p.ID) + 1;
            products.Add(product);
            return CreatedAtAction(nameof(Get), new { id = product.ID }, product);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Product updatedProduct)
        {
            var product = products.FirstOrDefault(p => p.ID == id);
            if (product == null)
            {
                return NotFound();
            }

            product.Name = updatedProduct.Name;
            product.Price = updatedProduct.Price;
            product.Photo = updatedProduct.Photo;
            product.ExpiryDate = updatedProduct.ExpiryDate;

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var product = products.FirstOrDefault(p => p.ID == id);
            if (product == null)
            {
                return NotFound();
            }

            products.Remove(product);
            return NoContent();
        }
    }
}
