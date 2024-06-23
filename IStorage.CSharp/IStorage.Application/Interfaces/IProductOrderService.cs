using IStorage.Application.Models;
using IStorage.Domain.Entities;

namespace IStorage.Application.Interfaces
{
    public interface IProductOrderService : IServiceBase
    <
        ProductOrder,
        ViewProductOrderModel,
        UpdateProductOrderModel,
        NewProductOrderModel
    >
    {

    }
}