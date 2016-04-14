using SimpleProductsApi.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace SimpleProductsApi.Controllers
{
    public class ProductsController : ApiController
    {
        private static List<Product> products = new List<Product>()
        {
            new Product(1, "Onion", "Food", 13),
            new Product(2, "Red Onion", "Food", 14)
        };

        [HttpGet]
        public List<Product> GetProducts()
        {
            return products;
        }
    }
}
