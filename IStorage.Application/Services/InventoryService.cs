using AutoMapper;
using IStorage.Application.Interfaces;
using IStorage.Application.Models;
using IStorage.Domain.Entities;
using IStorage.Domain.Interfaces;

namespace IStorage.Application.Services
{
    public class InventoryService : ServiceBase
    <
        Inventory,
        ViewInventoryModel,
        UpdateInventoryModel,
        NewInventoryModel
    >, IInventoryService 
    {
        public InventoryService(
            IInventoryRepository repository,
            IMapper mapper
        ) : base(repository, mapper)
        {

        }
    }
}