using Autoease.Domain.Entities;

namespace Autoease.Domain.Interfaces;

public interface IUserService
{
    Task<UserEntity> NewUser(UserEntity user);
}