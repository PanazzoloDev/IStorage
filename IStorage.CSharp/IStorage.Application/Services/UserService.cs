using AutoMapper;
using IStorage.Application.Interfaces;
using IStorage.Application.Models;
using IStorage.Domain.Entities;
using IStorage.Domain.Interfaces;

namespace IStorage.Application.Services
{
    public class UserService : ServiceBase
    <
        User,
        ViewUserModel,
        UpdateUserModel,
        NewUserModel
    >, IUserService 
    {
        public UserService(
            IUserRepository repository,
            IMapper mapper
        ) : base(repository, mapper)
        {

        }
    }
}