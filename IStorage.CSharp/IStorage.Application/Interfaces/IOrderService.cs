using IStorage.Application.Models;
using IStorage.Domain.Entities;

namespace IStorage.Application.Interfaces
{
    public interface IOrderService : IServiceBase
    <
        Order,
        ViewOrderModel,
        UpdateOrderModel,
        NewOrderModel
    >
    {

    }
}