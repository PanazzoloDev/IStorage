using IStorage.Application.Models;
using IStorage.Domain.Entities;

namespace IStorage.Application.Interfaces
{
    public interface IMovementService : IServiceBase
    <
        Movement,
        ViewMovementModel,
        UpdateMovementModel,
        NewMovementModel
    >
    {

    }
}