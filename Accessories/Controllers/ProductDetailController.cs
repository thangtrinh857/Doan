using Accessories.Infrastructure.Interfaces.ProductCommand;
using Microsoft.AspNetCore.Mvc;

namespace Accessories.Controllers
{
    public class ProductDetailController : Controller
    {
        private readonly IProductService _productService;
        public ProductDetailController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> GetDetailProduct(int id)
        {
            var product = await _productService.GetProductByIdAsync(id);
            return View("Index",product);
        }
    }
}
