using System.Collections.Generic;
using System.Linq;
using Flight_n_Bite_API.Model;
using Microsoft.AspNetCore.Mvc;

namespace Flight_n_Bite_API.Controllers
{
    [Route("api/[controller]")]
    [ApiConventionType(typeof(DefaultApiConventions))]
    [Produces("application/json")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public List<Product> GetProducts()
        {
            return _productRepository.GetProducts();
        }

        [HttpGet("{id}")]
        public Product GetProductById(int id)
        {
            return _productRepository.GetProducts().FirstOrDefault(p => p.Id == id);
        }

        [HttpPost]
        public void GiveDiscount(Product productWithDiscount)
        {
            _productRepository.GiveDicount(productWithDiscount);
            _productRepository.SaveChanges();
        }
    }
}