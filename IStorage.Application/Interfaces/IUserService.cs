using IStorage.Application.Models;
using IStorage.Domain.Entities;

namespace IStorage.Application.Interfaces
{
    public interface IUserService : IServiceBase
    <
        User,
        ViewUserModel,
        UpdateUserModel,
        NewUserModel
    >
    {

    }
}