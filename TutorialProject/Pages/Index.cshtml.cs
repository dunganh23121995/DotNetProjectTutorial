using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TutorialProject.Models.Entitys;
using TutorialProject.Models.JsonFileProductServices;

namespace TutorialProject.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IEnumerable<Product> Products { get; private set; }
        private JsonFileProductService  ProductService;
        public IndexModel(ILogger<IndexModel> logger, JsonFileProductService jsonFileProductService)
        {
            _logger = logger;
            ProductService = jsonFileProductService;

        }

        public void OnGet()
        {
            Products = ProductService.GetProducts();
        }
    }
}
