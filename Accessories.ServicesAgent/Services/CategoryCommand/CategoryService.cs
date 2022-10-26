using Accessories.Data.Context;
using Accessories.Infrastructure.Interfaces.CategoryCommand;
using Accessories.Infrastructure.ViewModels;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessories.ServicesAgent.Services.CategoryCommand
{
    public class CategoryService : BaseService, ICategoryService
    {
        public CategoryService(IDbContextFactory<AccessoriesDbContext> dbContextFactory, IMapper mapper) : base(dbContextFactory, mapper)
        {

        }

        public async Task<List<CategoryViewModel>> GetCategoriesAsync()
        {
            var context = _dbContextFactory.CreateDbContext();
            var categories = context.Categories.Where(t => t.IsActive).Include(t => t.Products).ToList();
            if(categories.Any())
            {
                return _mapper.Map<List<CategoryViewModel>>(categories);
            }    
            return new List<CategoryViewModel>();
        }
    }
}
