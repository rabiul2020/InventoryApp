using AutoMapper;
using Inventory.Application.Common.Interfaces;
using Inventory.Application.Common.Models;
using Inventory.Application.Features.Products.DTOS;
using Inventory.Application.Features.Products.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Application.Features.Products.Services
{
    public class ProductService : IProductService
    {
        private IApplicationDbContext _context;
        private IMapper _mapper;

        public ProductService(
    IApplicationDbContext context,
    IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        Task<Result<int>> IProductService.CreateAsync(CreateProductRequest request)
        {
            throw new NotImplementedException();
        }

        Task<Result> IProductService.DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

         async Task<Result<List<ProductDto>>> IProductService.GetAllAsync()
        {
            var products = await _context.Products
             .AsNoTracking()
             .ToListAsync();

            var dto = _mapper.Map<List<ProductDto>>(products);

            return Result<List<ProductDto>>.Success(dto);
        }

        public async Task<Result<ProductDto>> GetByIdAsync(int id)
        {
            var product = await _context.Products.FindAsync(id);

            if (product == null)
                return Result<ProductDto>.Failure("Product not found.");

            var dto = _mapper.Map<ProductDto>(product);

            return Result<ProductDto>.Success(dto);
        }

        Task<Result> IProductService.UpdateAsync(UpdateProductRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
