using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using MvcCoreSample.Models;
using System.Collections.Generic;
using System.ComponentModel;

namespace MvcCoreSample.ViewModels
{
    public class ProductCreateViewModel
    {
        public Product Product { get; set; }
   
        public IFormFile FormFile { get; set; }

        public List<SelectListItem> Brands { get; set; }

        [DisplayName("Marka")]
        public string BrandId { get; set; }
    }
}
