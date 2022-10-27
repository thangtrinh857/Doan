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
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> GetListProductsByCategoryId(int categoryId)
        {
            //var user =await _userManager.GetUserAsync(User);
            //if(user == null)
            //{
            //    return Redirect("Identity/Account/Login");
            //}    
            var products = await _productService.GetProductsByCategoryIdAsync(categoryId);
            return View(products);
        }
    }
}
