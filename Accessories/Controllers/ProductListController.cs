using Accessories.Infrastructure.Interfaces.ProductCommand;
using Accessories.Infrastructure.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Accessories.Controllers
{
    public class ProductListController : Controller
    {
        private readonly IProductService _productService;
        public ProductListController(IProductService productService)
        {
            _productService = productService;
        }
        public async Task<IActionResult> Index()
        {
            var products = await _productService.GetAllProductsAsync();
            return View(products);
        }
        [HttpGet]
        public async Task<IActionResult> GetListProductsByCategoryId(int id)
        {
            //var user =await _userManager.GetUserAsync(User);
            //if(user == null)
            //{
            //    return Redirect("Identity/Account/Login");
            //}    
            var products = await _productService.GetProductsByCategoryIdAsync(id);
            return View("Index",products);
        }
    }
}
