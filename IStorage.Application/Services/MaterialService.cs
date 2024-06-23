using AutoMapper;
using IStorage.Application.Interfaces;
using IStorage.Application.Models;
using IStorage.Domain.Entities;
using IStorage.Domain.Interfaces;

namespace IStorage.Application.Services
{
    public class SupplyService : ServiceBase
    <
        Supply,
        ViewSupplyModel,
        UpdateSupplyModel,
        NewSupplyModel
    >, ISupplyService
    {
        public SupplyService(
            ISupplyRepository repository,
            IMapper mapper
        ) : base(repository, mapper)
        {

        }
    }
}