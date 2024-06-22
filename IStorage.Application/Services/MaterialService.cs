using AutoMapper;
using IStorage.Application.Interfaces;
using IStorage.Application.Models;
using IStorage.Domain.Entities;
using IStorage.Domain.Interfaces;

namespace IStorage.Application.Services
{
    public class MaterialService : ServiceBase
    <
        Material,
        ViewMaterialModel,
        UpdateMaterialModel,
        NewMaterialModel
    >, IMaterialService 
    {
        public MaterialService(
            IRepositoryBase<Material> repository,
            IMapper mapper
        ) : base(repository, mapper)
        {

        }
    }
}