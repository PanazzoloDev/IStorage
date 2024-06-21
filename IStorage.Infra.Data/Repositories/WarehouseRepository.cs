using IStorage.Domain.Entities;
using IStorage.Domain.Interfaces;
using IStorage.Infra.Data.Context;

namespace IStorage.Infra.Data.Repositories
{
    public class WarehouseRepository : BaseRepository<Warehouse>, IWarehouseRepository
    {
        public WarehouseRepository(IStorageDbContext context) : base(context)
        {
        }
    }
}