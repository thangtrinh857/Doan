using Accessories.Infrastructure.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessories.Infrastructure.Interfaces.CartProductCommand
{
    public interface ICartProductService
    {
        Task<List<CartProductViewModel>> GetCartProductsByUserIdAsync(string userId);
        Task<bool> AdditionalProductIntoCartByUserId(ProductViewModel product, string userId);
        Task RemoveProductFromCart(int cartProductId);

    }
}
