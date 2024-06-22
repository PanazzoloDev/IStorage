using AutoMapper;
using IStorage.Application.Interfaces;
using IStorage.Application.Models;
using IStorage.Domain.Entities;
using IStorage.Domain.Interfaces;

namespace IStorage.Application.Services
{
    public class OrderService : ServiceBase
    <
        Order,
        ViewOrderModel,
        UpdateOrderModel,
        NewOrderModel
    >, IOrderService
    {
        public OrderService(
            IRepositoryBase<Order> repository,
            IMapper mapper
        ) : base(repository, mapper)
        {

        }
    }
}