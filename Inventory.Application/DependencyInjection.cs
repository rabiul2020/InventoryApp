using FluentValidation;
using Inventory.Application.Interfaces;
using Inventory.Application.Mapping;
using Inventory.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            

            services.AddAutoMapper(typeof(MappingProfile));
            services.AddScoped<IProductService, ProductService>();
            

            return services;


        }
    }
}
