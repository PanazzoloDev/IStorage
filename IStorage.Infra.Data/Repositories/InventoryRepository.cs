using IStorage.Domain.Entities;
using IStorage.Domain.Interfaces;
using IStorage.Infra.Data.Context;

namespace IStorage.Infra.Data.Repositories
{
    public class InventoryRepository : BaseRepository<Inventory>, IInventoryRepository
    {
        public InventoryRepository(IStorageDbContext context) : base(context)
        {
        }
    }
}