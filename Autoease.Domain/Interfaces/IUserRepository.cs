using Autoease.Domain.Entities;

namespace Autoease.Domain.Interfaces;

public interface IUserRepository
{
    Task<bool> CreateNewUser(UserEntity user);
}