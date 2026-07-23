using Inventory.Application.Interfaces;
using Inventory.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public IRepository<Product> Products => throw new NotImplementedException();

        public IRepository<Category> Categories => throw new NotImplementedException();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
