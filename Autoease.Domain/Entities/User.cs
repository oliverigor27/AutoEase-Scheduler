using Autoease.Domain.ValueObjects;

namespace Autoease.Domain.Entities;

public class UserEntity : BaseEntity
{
    public UserEntity() {}

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

    private readonly List<string> errors = new List<string>();
    public string UserIdCard { get; private set; }
    public string Username { get; private set; }
    public string Email { get; private set; }
    public string Password { get; private set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public Address Address { get; private set; }
}
