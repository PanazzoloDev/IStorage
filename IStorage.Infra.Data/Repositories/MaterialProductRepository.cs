using IStorage.Domain.Entities;
using IStorage.Domain.Interfaces;
using IStorage.Infra.Data.Context;

namespace IStorage.Infra.Data.Repositories
{
    public class MaterialProductRepository: BaseRepository<MaterialProduct>, IMaterialProductRepository
    {
        public MaterialProductRepository(IStorageDbContext context) : base(context)
        {
        }
    }
}