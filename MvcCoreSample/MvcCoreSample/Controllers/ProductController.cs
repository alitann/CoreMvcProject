using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MvcCoreSample.Repositories;
using MvcCoreSample.ViewModels;

namespace MvcCoreSample.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly IHostingEnvironment _hostingEnvironment;

        public List<SelectListItem> Brands { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "1", Text = "Merco" },
            new SelectListItem { Value = "2", Text = "BMW" },
            new SelectListItem { Value = "3", Text = "Audi"  }
        };

        public ProductController(IProductRepository productRepository, IHostingEnvironment hostingEnvironment)
        {
            _productRepository = productRepository;
            _hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Index()
        {
            var products = _productRepository.GetProducts();
            return View(products);
        }

        public IActionResult Search(string search)
        {
            var products = _productRepository.GetProducts();
            return View(products);
        }

        [HttpPost]
        public IActionResult Index(string searchString)
        {
            var products = _productRepository.GetProducts();
            if (!String.IsNullOrEmpty(searchString))
            {
                products = products.Where(s => s.Name.Contains(searchString));
            }

            return View(products);
        }

        [HttpPost]
        public IActionResult Create(ProductCreateViewModel model)
        {
            if (model.FormFile.Length > 0)
            {
                var filePath = Path.Combine(_hostingEnvironment.WebRootPath, @"images", model.FormFile.FileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    model.FormFile.CopyToAsync(stream);
                    model.Product.ImagePath = model.FormFile.FileName;
                }
            }
            _productRepository.Add(model.Product);
            return RedirectToAction("Index");
        }


        public IActionResult Create()
        {
            ProductCreateViewModel model = new ProductCreateViewModel();
            model.Brands = Brands;
            return View(model);
        }
    }
}