using Autoease.Domain.Entities;

namespace Autoease.Domain.Interfaces;

public interface IUserService
{
    Task<bool> NewUser(UserEntity user);
}