using IStorage.Domain.Entities;
using IStorage.Domain.Interfaces;
using IStorage.Infra.Data.Context;

namespace IStorage.Infra.Data.Repositories
{
    public class SupplyRepository : BaseRepository<Supply>, ISupplyRepository
    {
        public SupplyRepository(IStorageDbContext context) : base(context)
        {
        }
    }
}