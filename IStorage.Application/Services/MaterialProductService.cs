using AutoMapper;
using IStorage.Application.Interfaces;
using IStorage.Application.Models;
using IStorage.Domain.Entities;
using IStorage.Domain.Interfaces;

namespace IStorage.Application.Services
{
    public class MaterialProductService : ServiceBase
    <
        MaterialProduct,
        ViewMaterialProductModel,
        UpdateMaterialProductModel,
        NewMaterialProductModel
    >, IMaterialProductService
    {
        public MaterialProductService(
            IRepositoryBase<MaterialProduct> repository,
            IMapper mapper
        ) : base(repository, mapper)
        {

        }
    }
}