using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IStorage.Domain.Interfaces
{
    public interface IRepositoryBase<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T?> GetByIdAsync(long? id);
        Task<T> CreateAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(T entity);
    }
}