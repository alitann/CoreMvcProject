using Microsoft.AspNetCore.Mvc;
using MvcCoreSample.Models;
using MvcCoreSample.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreSample.ViewComponents
{
    public class ProductCard : ViewComponent
    {
        private readonly IProductRepository _productRepository;
        public ProductCard(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IViewComponentResult Invoke(int Id)
        {
            return View(_productRepository.GetProduct(Id));
        }
    }
}
