using AutoMapper;
using IStorage.Application.Interfaces;
using IStorage.Application.Models;
using IStorage.Domain.Entities;
using IStorage.Domain.Interfaces;

namespace IStorage.Application.Services
{
    public class WarehouseService : ServiceBase
    <
        Warehouse,
        ViewWarehouseModel,
        UpdateWarehouseModel,
        NewWarehouseModel
    >, IWarehouseService
    {
        public WarehouseService(
            IRepositoryBase<Warehouse> repository,
            IMapper mapper
        ) : base(repository, mapper)
        {

        }
    }
}