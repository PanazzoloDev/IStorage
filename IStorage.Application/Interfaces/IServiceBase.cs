using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IStorage.Application.Interfaces
{
    public interface IServiceBase <Entity, View, Update, New> 
        where View : class 
        where Update : class
        where New : class
    {
        Task<IEnumerable<View>> GetAllAsync();
        Task<View> GetByIdAsync(long? id);
        Task CreateAsync(New product);
        Task UpdateAsync(Update product);
        Task DeleteAsync(long? id); 
    }
}