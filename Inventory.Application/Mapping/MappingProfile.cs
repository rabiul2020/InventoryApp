using AutoMapper;
using Inventory.Application.Features.DTOS;
using Inventory.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Application.Common.Mappings
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            // Product -> ProductDto
            CreateMap<Product, ProductDto>()
                .ForMember(
                    dest => dest.CategoryName,
                    opt => opt.MapFrom(src => src.Category != null ? src.Category.Name : string.Empty)
                )
                .ReverseMap();

            // Create Product
            CreateMap<CreateProductRequest, Product>();

            // Update Product
            CreateMap<UpdateProductRequest, Product>();
        }
    }
}
