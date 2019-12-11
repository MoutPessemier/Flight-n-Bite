using System.Collections.Generic;

namespace Flight_n_Bite_API.Model
{
    public interface IProductRepository
    {
        List<Product> GetProducts();
        void Add(Product product);
        void SaveChanges();
        void GiveDicount(Product product);
    }
}
