using Accessories.Infrastructure.Interfaces.API.RegionCommand;
using Accessories.Infrastructure.Interfaces.CategoryCommand;
using Accessories.Infrastructure.Interfaces.ProductCommand;
using Accessories.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Accessories.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public readonly IProductService _productService;
        public readonly ICategoryService _categoryService;
        public readonly IRegionAPIService _regionAPIService;
        public HomeController(
            ILogger<HomeController> logger,
            ICategoryService categoryService,
            IRegionAPIService regionAPIService,
            IProductService productService)
        {
            _logger = logger;
            _productService = productService;
            _categoryService = categoryService;
            _regionAPIService = regionAPIService;
        }

        public async Task<IActionResult> Index()
        {
            var categories =await _categoryService.GetCategoriesAsync();
            var data = await _regionAPIService.GetListWardByDistrictId("271");
            return View(categories);
        }
       
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}