using Microsoft.AspNetCore.Mvc;

namespace Accessories.Controllers
{
    public class ProductListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
