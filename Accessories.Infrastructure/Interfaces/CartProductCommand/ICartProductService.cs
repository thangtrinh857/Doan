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
        Task AdditionalProductIntoCartByUserId(ProductViewModel product, string userId);
        Task UpdateCart(List<string> cartIds, string userId);

    }
}
