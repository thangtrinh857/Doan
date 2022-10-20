using Microsoft.AspNetCore.Mvc;

namespace Accessories.Controllers
{
    public class ProductDetailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
