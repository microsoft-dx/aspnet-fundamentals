using SimpleTokenAuthentication.Models;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web.Http;

namespace SimpleTokenAuthentication.Controllers
{
    [Authorize]
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
            var userName = (User.Identity as ClaimsIdentity).Claims.FirstOrDefault(claim => claim.Type == "UserName").Value;

            return products;
        }

        [HttpPost]
        public void AddProduct(Product product)
        {
            products.Add(product);
        }
    }
}
