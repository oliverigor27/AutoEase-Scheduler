using Autoease.Domain.ValueObjects;

namespace Autoease.Domain.Entities;

public sealed class UserEntity : BaseEntity
{
    private UserEntity() {}

    public UserEntity(
        string userIdCard, 
        string username, 
        string email, 
        string password,
        string firstName,
        string lastName,
        Address address
    )
    {
        UserIdCard = userIdCard;
        Username = username;
        Email = email;
        Password = password;
        FirstName = firstName;
        LastName = lastName;
        Address = address;
    }

    public required string UserIdCard { get; set; }
    public required string Username { get;  set; }
    public required string Email { get; set; }
    public required string Password { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required Address Address { get; set; }
}
