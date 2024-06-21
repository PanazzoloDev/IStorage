using IStorage.Application.Models;
using IStorage.Domain.Entities;

namespace IStorage.Application.Interfaces
{
    public interface IProductService : IServiceBase
    <
        Product,
        ViewProductModel,
        UpdateProductModel,
        NewProductModel
    >
    {

    }
}