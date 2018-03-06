using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webapi.Models;

namespace webapi.Controllers
{
    public class ProductController : ApiController
    {
        List<Product> products;

        public ProductController()
        {
            products = new List<Product>();
            products.Add(new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 });
            products.Add(new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M });
            products.Add(new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M  });
        }
        
        public IEnumerable<Product> GetAllProduct()
        {
            return products;
        }

        public string GetString(string a)
        {
            return a;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        public IEnumerable<Product> AddProduct(Product new_product)
        {
            products.Add(new_product);
            return products;
        }
    }
}
