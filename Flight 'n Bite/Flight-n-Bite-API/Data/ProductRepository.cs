using Flight_n_Bite_API.Model;
using System.Collections.Generic;
using System.Linq;

namespace Flight_n_Bite_API.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly FlightDbContext _context;

        public ProductRepository(FlightDbContext context)
        {
            _context = context;
        }

        public void Add(Product product)
        {
            _context.Products.Add(product);
        }

        public List<Product> GetProducts()
        {
            return _context.Products.ToList();
        }

        public void GiveDicount(Product product)
        {
            _context.Products.FirstOrDefault(p => p.Id == product.Id).Discount = product.Discount;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
