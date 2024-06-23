using IStorage.Domain.Entities;
using IStorage.Domain.Interfaces;
using IStorage.Infra.Data.Context;

namespace IStorage.Infra.Data.Repositories
{
    public class SupplyProductRepository : BaseRepository<SupplyProduct>, ISupplyProductRepository
    {
        public SupplyProductRepository(IStorageDbContext context) : base(context)
        {
        }
    }
}