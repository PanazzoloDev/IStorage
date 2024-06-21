using IStorage.Domain.Entities;
using IStorage.Domain.Interfaces;
using IStorage.Infra.Data.Context;

namespace IStorage.Infra.Data.Repositories
{
    public class MovementRepository : BaseRepository<Movement>, IMovementRepository
    {
        public MovementRepository(IStorageDbContext context) : base(context)
        {
        }
    }
}