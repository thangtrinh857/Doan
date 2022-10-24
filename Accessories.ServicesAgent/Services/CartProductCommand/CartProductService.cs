using Accessories.Data.Context;
using Accessories.Domain.Models;
using Accessories.Infrastructure.Interfaces.CartProductCommand;
using Accessories.Infrastructure.ViewModels;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessories.ServicesAgent.Services.CartProductCommand
{
    public class CartProductService : BaseService, ICartProductService
    {
        public CartProductService(IDbContextFactory<AccessoriesDbContext> dbContextFactory, IMapper mapper) : base(dbContextFactory, mapper)
        {

        }
        public async Task<List<CartProductViewModel>> GetCartProductsByUserIdAsync(string userId)
        {
            var context = _dbContextFactory.CreateDbContext();
            var carts = context.CartProducts.Where(t => t.IsActive && t.CreatedBy == userId).ToList();
            if (carts == null && carts.Count == 0) return null;
            return _mapper.Map<List<CartProductViewModel>>(carts);
        }
        public async Task AdditionalProductIntoCartByUserId(ProductViewModel product, string userId)
        {
            var context = _dbContextFactory.CreateDbContext();
            var user = context.Users.Where(u=> u.Id == userId).FirstOrDefault();
            CartProduct cart = new CartProduct();
            cart.IsActive = true;
            cart.Address = user?.Email;
            cart.CreatedBy = userId;
            cart.CreatedDate = DateTime.Now;
            cart.UpdatedDate = DateTime.Now;
            cart.UpdatedBy = userId;
            cart.PhoneNumber = user?.PhoneNumber;
            cart.ProductId = product.Id;
            cart.Quantity = product.Quantity;
            await context.CartProducts.AddAsync(cart);
            await context.SaveChangesAsync();
        }
        public async Task UpdateCart(List<string> cartIds, string userId)
        {

        }    
    }
}
