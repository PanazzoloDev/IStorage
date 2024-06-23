using IStorage.Application.Models;
using IStorage.Domain.Entities;

namespace IStorage.Application.Interfaces
{
    public interface IWarehouseService : IServiceBase
    <
        Warehouse,
        ViewWarehouseModel,
        UpdateWarehouseModel,
        NewWarehouseModel
    >
    {

    }
}