using Autoease.Domain.Entities;
using Autoease.Domain.Interfaces;

namespace Autoease.Application.Service.User;

public class CreateUser : ICreateUser
{
    Task<UserEntity> ICreateUser.CreateUser(UserEntity user)
    {
        throw new NotImplementedException();
    }
}