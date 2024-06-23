using AutoMapper;
using IStorage.Application.Interfaces;
using IStorage.Application.Models;
using IStorage.Domain.Entities;
using IStorage.Domain.Interfaces;

namespace IStorage.Application.Services
{
    public class ProductOrderService : ServiceBase
    <
        ProductOrder,
        ViewProductOrderModel,
        UpdateProductOrderModel,
        NewProductOrderModel
    >, IProductOrderService
    {
        public ProductOrderService(
            IProductOrderRepository repository,
            IMapper mapper
        ) : base(repository, mapper)
        {

        }
    }
}