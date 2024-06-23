using IStorage.Application.Models;
using IStorage.Domain.Entities;

namespace IStorage.Application.Interfaces
{
    public interface ISupplyProductService : IServiceBase
    <
        SupplyProduct,
        ViewSupplyProductModel,
        UpdateSupplyProductModel,
        NewSupplyProductModel
    >
    {

    }
}