using IStorage.Domain.Entities;
using IStorage.Domain.Interfaces;
using IStorage.Infra.Data.Context;

namespace IStorage.Infra.Data.Repositories
{
    public class ProductOrderRepository : BaseRepository<ProductOrder>, IProductOrderRepository
    {
        public ProductOrderRepository(IStorageDbContext context) : base(context)
        {
        }
    }
}