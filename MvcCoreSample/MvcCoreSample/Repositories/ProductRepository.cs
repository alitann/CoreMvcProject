using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcCoreSample.Models;

namespace MvcCoreSample.Repositories
{
    public class ProductRepository : IProductRepository
    {

       public static List<Product> _products;

        public ProductRepository()
        {
            if (_products == null)
            {
                _products = new List<Product>
                {
                    new Product() { Id = 1, Name = "E 250", Price = 300000, Stock = 2, ImagePath = "1.jpg"},
                    new Product() { Id = 1, Name = "Bmw 4.18i GrandCoupe", Price = 300000, Stock = 2, ImagePath = "1.jpg"},
                    new Product() { Id = 1, Name = "Audi A7 ", Price = 300000, Stock = 2, ImagePath = "1.jpg"},
                    new Product() { Id = 1, Name = "Mercedes Amg 63 ", Price = 300000, Stock = 2, ImagePath = "1.jpg"},
                    new Product() { Id = 1, Name = "Bmw 5.25 XDrive", Price = 300000, Stock = 2, ImagePath = "1.jpg"},
                };
            }
        }

        public void Add(Product p )
        {
            _products.Add(p);
        }

        public Product GetProduct(int Id)
        {
            return _products.FirstOrDefault(p => p.Id == Id);
        }

        public IEnumerable<Product> GetProducts()
        {
            return _products.ToList();
        }

        public IEnumerable<Product> SearchProducts(string search)
        {
            return _products.Where(p => p.Name.Contains(search));
        }
    }
}
