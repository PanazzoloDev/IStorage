using IStorage.Application.Models;
using IStorage.Domain.Entities;

namespace IStorage.Application.Interfaces
{
    public interface IMaterialService : IServiceBase
    <
        Material,
        ViewMaterialModel,
        UpdateMaterialModel,
        NewMaterialModel
    >
    {

    }
}