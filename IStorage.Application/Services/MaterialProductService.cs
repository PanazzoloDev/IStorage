using AutoMapper;
using IStorage.Application.Interfaces;
using IStorage.Application.Models;
using IStorage.Domain.Entities;
using IStorage.Domain.Interfaces;

namespace IStorage.Application.Services
{
    public class SupplyProductService : ServiceBase
    <
        SupplyProduct,
        ViewSupplyProductModel,
        UpdateSupplyProductModel,
        NewSupplyProductModel
    >, ISupplyProductService
    {
        public SupplyProductService(
            ISupplyProductRepository repository,
            IMapper mapper
        ) : base(repository, mapper)
        {

        }
    }
}