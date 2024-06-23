using IStorage.Application.Models;
using IStorage.Domain.Entities;

namespace IStorage.Application.Interfaces
{
    public interface ISupplyService : IServiceBase
    <
        Supply,
        ViewSupplyModel,
        UpdateSupplyModel,
        NewSupplyModel
    >
    {

    }
}