
using IStorage.Domain.Interfaces;
using IStorage.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace IStorage.Infra.Data.Repositories
{
    public class BaseRepository<T> : IRepositoryBase<T> where T : class
    {
        internal readonly IStorageDbContext _context;
        internal readonly DbSet<T> _dbSet;

        public BaseRepository(IStorageDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task<T> CreateAsync(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public async Task<T> DeleteAsync(T entity)
        {
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T?> GetByIdAsync(long? id)
        {
            if (id == null)
                return null;

            return await _dbSet.FindAsync(id);
        }

        public async Task<T> UpdateAsync(T entity)
        {
            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}