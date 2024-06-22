using AutoMapper;
using IStorage.Application.Interfaces;
using IStorage.Application.Models;
using IStorage.Domain.Entities;
using IStorage.Domain.Interfaces;

namespace IStorage.Application.Services
{
    public class MovementService : ServiceBase
    <
        Movement,
        ViewMovementModel,
        UpdateMovementModel,
        NewMovementModel
    >, IMovementService
    {
        public MovementService(
            IRepositoryBase<Movement> repository,
            IMapper mapper
        ) : base(repository, mapper)
        {

        }
    }
}