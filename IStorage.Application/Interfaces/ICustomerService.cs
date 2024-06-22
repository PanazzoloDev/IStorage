using IStorage.Application.Models;
using IStorage.Domain.Entities;

namespace IStorage.Application.Interfaces
{
    public interface ICustomerService : IServiceBase
    <
        Customer,
        ViewCustomerModel,
        UpdateCustomerModel,
        NewCustomerModel
    >
    {

    }
}