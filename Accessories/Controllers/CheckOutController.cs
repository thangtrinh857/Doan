using Microsoft.AspNetCore.Mvc;

namespace Accessories.Controllers
{
    public class CheckoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
