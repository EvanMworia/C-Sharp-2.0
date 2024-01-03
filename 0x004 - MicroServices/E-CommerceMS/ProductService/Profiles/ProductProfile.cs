using AutoMapper;
using ProductService.Models;
using ProductService.Models.DTOs;

namespace ProductService.Profiles
{
    public class ProductProfile:Profile
    {
        public ProductProfile()
        {
            CreateMap<AddProductDTO, Product>()
                .ForMember(dest=>dest.UnitsPresent, src=> src.MapFrom(x=>x.UnitsAdded));

            CreateMap<GetProductDTO, Product>().ReverseMap();
            CreateMap<ProductDTO, Product>().ReverseMap();
        }
    }
}
