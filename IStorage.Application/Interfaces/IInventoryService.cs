using IStorage.Application.Models;
using IStorage.Domain.Entities;

namespace IStorage.Application.Interfaces
{
    public interface IInventoryService : IServiceBase
    <
        Inventory,
        ViewInventoryModel,
        UpdateInventoryModel,
        NewInventoryModel
    >
    {

    }
}