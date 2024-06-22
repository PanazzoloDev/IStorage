using IStorage.Application.Models;
using IStorage.Domain.Entities;

namespace IStorage.Application.Interfaces
{
    public interface IMaterialProductService : IServiceBase
    <
        MaterialProduct,
        ViewMaterialProductModel,
        UpdateMaterialProductModel,
        NewMaterialProductModel
    >
    {

    }
}