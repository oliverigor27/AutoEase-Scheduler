using Autoease.Domain.Entities;

namespace Autoease.Domain.Interfaces;

public interface ICreateUser
{
    Task<UserEntity> CreateUser(UserEntity user);
}