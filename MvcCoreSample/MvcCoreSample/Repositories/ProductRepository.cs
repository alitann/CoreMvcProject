using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcCoreSample.Data;
using MvcCoreSample.Models;

namespace MvcCoreSample.Repositories
{
    public class ProductRepository : IProductRepository
    {

        //public static List<Product> _products;

        MvcSampleDbContext _mvcSampleDbContext;
        public ProductRepository(MvcSampleDbContext mvcSampleDbContext)
        {
            //if (_products == null)
            //{
            //    _products = new List<Product>
            //    {
            //        new Product() { Id = 1, Name = "E 250", Price = 300000, Stock = 2, ImagePath = "1.jpg"},
            //        new Product() { Id = 2, Name = "Bmw 4.18i GrandCoupe", Price = 300000, Stock = 2, ImagePath = "1.jpg"},
            //        new Product() { Id = 3, Name = "Audi A7 ", Price = 300000, Stock = 2, ImagePath = "1.jpg"},
            //        new Product() { Id = 4, Name = "Mercedes Amg 63 ", Price = 300000, Stock = 2, ImagePath = "1.jpg"},
            //        new Product() { Id = 5, Name = "Bmw 5.25 XDrive", Price = 300000, Stock = 2, ImagePath = "1.jpg"},
            //    };
            //}
            _mvcSampleDbContext = mvcSampleDbContext;
        }

        public void Add(Product product )
        {
            //_products.Add(p);
            _mvcSampleDbContext.Products.Add(product);
            _mvcSampleDbContext.SaveChanges();
        }

        public Product GetProduct(int Id)
        {
            //return _products.FirstOrDefault(p => p.Id == Id);
            return _mvcSampleDbContext.Products.FirstOrDefault(p => p.Id == Id);

        }

        public IEnumerable<Product> GetProducts()
        {
            //return _products.ToList();
            return _mvcSampleDbContext.Products.ToList();
        }

        public IEnumerable<Product> SearchProducts(string search)
        {
            //return _products.Where(p => p.Name.Contains(search));
            return _mvcSampleDbContext.Products.Where(p => p.Name.Contains(search));

        }
    }
}
