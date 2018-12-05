using MvcCoreSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreSample.Repositories
{
    public interface IProductRepository
    {
        void Add(Product p);
        IEnumerable<Product> GetProducts();

        IEnumerable<Product> SearchProducts(string search);

        Product GetProduct(int Id);
    }
}
