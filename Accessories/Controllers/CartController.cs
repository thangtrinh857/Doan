using Accessories.Domain.Models;
using Accessories.Infrastructure.Contents.MessageEnum;
using Accessories.Infrastructure.Interfaces.CartProductCommand;
using Accessories.Infrastructure.Interfaces.ProductCommand;
using Accessories.Infrastructure.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Accessories.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartProductService _cartProductService;
        private readonly UserManager<UserEntity> _userManager;
        private readonly IProductService _productService;
        private readonly ILogger<CartController> _logger;

        public CartController(
            ICartProductService cartProductService,
            UserManager<UserEntity> userManager,
            ILogger<CartController> logger,
            IProductService productService)
        {
            _cartProductService = cartProductService;
            _userManager = userManager;
            _productService = productService;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return View("Index",MessageConst.Not_Found_User);
            }
            var productCarts = await _cartProductService.GetCartProductsByUserIdAsync(user.Id);
            return View(productCarts);
        }
        [HttpPost]
        public async Task<IActionResult> AdditionalCart(int id, int quantity)
        {
            try
            {
                var user = await _userManager.GetUserAsync(User);
                if (user == null)
                {
                    return Json(MessageConst.Not_Found_User);
                }
                var product = await _productService.GetProductByIdAsync(id);
                product.Quantity = quantity;
                var result = await _cartProductService.AdditionalProductIntoCartByUserId(product, user.Id);
                return result ? Json(MessageConst.Message_Notice_Add_Success) : Json(MessageConst.Message_Notice_Add_Fail);
            }
            catch(Exception ex)
            {
                _logger.LogInformation("AdditionalCart " + ex.StackTrace);
                _logger.LogInformation("AdditionalCart msg" + ex.Message);
                return Json(ex.Message);
            }
        }
        [HttpPost]
        public async Task<IActionResult> RemoveProductFromCartByUser(int cartProductId)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return Json(MessageConst.Not_Found_User);
            }
            await _cartProductService.RemoveProductFromCart(cartProductId);
            var productCarts = await _cartProductService.GetCartProductsByUserIdAsync(user.Id);
            return Json(MessageConst.Message_Notice_Add_Success);
        }
    }
}
