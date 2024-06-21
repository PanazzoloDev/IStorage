using IStorage.Domain.Entities;
using IStorage.Domain.Interfaces;
using IStorage.Infra.Data.Context;

namespace IStorage.Infra.Data.Repositories
{
    public class MaterialRepository: BaseRepository<Material>, IMaterialRepository
    {
        public MaterialRepository(IStorageDbContext context) : base(context)
        {
        }
    }
}