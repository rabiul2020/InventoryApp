using Inventory.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Application.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        // Get
        Task<T?> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();

        // Find
        Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);

        // Create
        Task AddAsync(T entity);

        // Update
        void Update(T entity);

        // Delete
        void Delete(T entity);

        // Check
        Task<bool> ExistsAsync(Expression<Func<T, bool>> predicate);
    }
}
