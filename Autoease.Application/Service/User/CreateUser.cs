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

        UserEntity newUser = new 
        (
            user.UserIdCard,
            user.Username,
            user.Email,
            user.Password,
            user.FirstName,
            user.LastName,
            user.Address
        );

        _databaseContext.Users.Add(newUser);
        await _databaseContext.SaveChangesAsync();

        return user;
    }
}