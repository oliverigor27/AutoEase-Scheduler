using Autoease.Domain.Entities;
using Autoease.Domain.Interfaces;
using Autoease.Infrastructure.Persistence;

namespace Autoease.Application.Service.User;

public class UserService : IUserService
{
    private readonly DatabaseContext _databaseContext;

    public UserService(DatabaseContext databaseContext)
    {
        _databaseContext = databaseContext;
    }

    public async Task<bool> NewUser(UserEntity user)
    {

        UserEntity newUser = new 
        (
            user.UserIdCard,
            user.Username,
            user.Email,
            password: BCrypt.Net.BCrypt.HashPassword(user.Password),
            user.FirstName,
            user.LastName,
            user.Role
        );

        Console.WriteLine(newUser.GetErrors());

        _databaseContext.Users.Add(newUser);
        await _databaseContext.SaveChangesAsync();

        return true;
    }
}