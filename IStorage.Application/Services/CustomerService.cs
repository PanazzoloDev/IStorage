using AutoMapper;
using IStorage.Application.Interfaces;
using IStorage.Application.Models;
using IStorage.Domain.Entities;
using IStorage.Domain.Interfaces;

namespace IStorage.Application.Services
{
    public class CustomerService : ServiceBase
    <
        Customer,
        ViewCustomerModel,
        UpdateCustomerModel,
        NewCustomerModel
    >, ICustomerService
    {
        public CustomerService(
            IRepositoryBase<Customer> repository,
            IMapper mapper
        ) : base(repository, mapper)
        {

        }
    }
}