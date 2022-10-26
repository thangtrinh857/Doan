using Microsoft.AspNetCore.Mvc;

namespace Accessories.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
