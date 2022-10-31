using Accessories.Infrastructure.Interfaces.ProductCommand;
using Accessories.Infrastructure.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;
using PagedList;

namespace Accessories.Controllers
{
    public class ProductListController : Controller
    {
        private readonly IProductService _productService;
        public ProductListController(IProductService productService)
        {
            _productService = productService;
        }
        public async Task<IActionResult> Index(int? page)
        {
            if (page == null) page = 1; 
            int pageSize = 8;
            int pageNumber = (page ?? 1);
            var products = await _productService.GetAllProductsAsync();
            return View(products.ToPagedList(pageNumber, pageSize));
        }
        [HttpGet]
        public async Task<IActionResult> GetListProductsByCategoryId(int id, int? page)
        {
            //var user =await _userManager.GetUserAsync(User);
            //if(user == null)
            //{
            //    return Redirect("Identity/Account/Login");
            //}    
            if (page == null) page = 1;
            int pageSize = 8;
            int pageNumber = (page ?? 1);
            var products = await _productService.GetProductsByCategoryIdAsync(id);
            return View("Index", products.ToPagedList(pageNumber, pageSize));
        }
    }
}
