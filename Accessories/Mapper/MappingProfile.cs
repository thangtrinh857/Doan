using Accessories.Domain.Models;
using Accessories.Infrastructure.ViewModels;
using AutoMapper;

namespace Accessories.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CategoryViewModel, CategoryEntity>();
            CreateMap<CategoryEntity, CategoryViewModel>();
            CreateMap<ProductViewModel, ProductEntity>();
            CreateMap<ProductEntity, ProductViewModel>();
            CreateMap<CartProduct, CartProductViewModel>();
            CreateMap<CartProductViewModel, CartProduct>();


        }
    }
}
