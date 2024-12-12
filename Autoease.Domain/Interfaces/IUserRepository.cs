using Autoease.Domain.AggregateModel.UserAggregate;

namespace Autoease.Domain.Interfaces;

public interface IUserRepository
{
    Task<bool> CreateNewUser(User user);
}