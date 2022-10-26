using Accessories.Data.Context;
using Accessories.Infrastructure.Interfaces.ProductCommand;
using Accessories.Infrastructure.ViewModels;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessories.ServicesAgent.Services.ProductCommand
{
    public class ProductService : BaseService, IProductService
    {
        public ProductService(IDbContextFactory<AccessoriesDbContext> dbContextFactory, IMapper mapper) : base(dbContextFactory, mapper)
        {

        }

        public async Task<List<ProductViewModel>> GetAllProductsAsync()
        {
            var context = _dbContextFactory.CreateDbContext();
            var products = context.Products.Where(t => t.IsActive).ToList();
            if(products.Any())
            {
                return _mapper.Map<List<ProductViewModel>>(products);
            }
            return new List<ProductViewModel>();
        }

        public async Task<ProductViewModel> GetProductByCategoryIdAsync(int categoryId)
        {
            var context = _dbContextFactory.CreateDbContext();
            var product = context.Products.Where(t => t.CategoryId == categoryId && t.IsActive).FirstOrDefaultAsync();
            if (product != null)
            {
                return _mapper.Map<ProductViewModel>(product);
            }
            return new ProductViewModel();
        }

        public async Task<ProductViewModel> GetProductByIdAsync(int id)
        {
            var context = _dbContextFactory.CreateDbContext();
            var product = context.Products.Where(t => t.Id == id && t.IsActive).FirstOrDefaultAsync();
            if (product != null)
            {
                return _mapper.Map<ProductViewModel>(product);
            }
            return new ProductViewModel();
        }
    }
}
