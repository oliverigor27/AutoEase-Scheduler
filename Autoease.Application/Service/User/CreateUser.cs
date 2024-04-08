using Autoease.Domain.Entities;
using Autoease.Domain.Interfaces;
using Autoease.Infrastructure.Persistence;

namespace Autoease.Application.Service.User;

public class CreateUser : ICreateUser
{
    private readonly DatabaseContext _databaseContext;

    public CreateUser(DatabaseContext databaseContext)
    {
        _databaseContext = databaseContext;
    }
    public async Task<UserEntity> NewUser(UserEntity user)
    {
        _databaseContext.Users.Add(user);
        await _databaseContext.SaveChangesAsync();

        return user;
    }
}