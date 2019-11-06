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

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
