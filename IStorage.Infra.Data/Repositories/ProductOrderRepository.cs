using IStorage.Domain.Entities;
using IStorage.Domain.Interfaces;
using IStorage.Infra.Data.Context;

namespace IStorage.Infra.Data.Repositories
{
    public class ProductProductOrderRepository : BaseRepository<ProductOrder>, IProductOrderRepository
    {
        public ProductProductOrderRepository(IStorageDbContext context) : base(context)
        {
        }
    }
}