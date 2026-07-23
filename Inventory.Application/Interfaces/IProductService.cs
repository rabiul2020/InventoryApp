using Inventory.Application.Common.Models;
using Inventory.Application.Features.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Application.Features.Products.Interfaces
{
    public interface IProductService
    {
        Task<Result<List<ProductDto>>> GetAllAsync();

        Task<Result<ProductDto>> GetByIdAsync(int id);

        Task<Result<int>> CreateAsync(CreateProductRequest request);

        Task<Result> UpdateAsync(UpdateProductRequest request);

        Task<Result> DeleteAsync(int id);
    }
}
