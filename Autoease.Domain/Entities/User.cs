using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Autoease.Domain.ValueObjects;

namespace Autoease.Domain.Entities;

public class UserEntity
{
    private readonly List<string> errors = new();

    [Key]
    public string UserIdCard { get; private set; }
    public string Username { get; private set; }
    public string Email { get; private set; }
    public string Password { get; private set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public Address Address { get; private set; }

    
    protected UserEntity() {}
    public UserEntity(string userIdCard, string username, string email, string password, string firstName, string lastName, Address address)
    {
        UserIdCard = userIdCard;
        Username = username;
        Email = email;
        Password = password;
        FirstName = firstName;
        LastName = lastName;
        Address = address;

        Validate();
    }

    public bool IsValid()
    {
        return errors.Count == 0;
    }

    private void Validate()
    {
        if(UserIdCard == null && UserIdCard.Length < 8)  errors.Add("User Id Card cannot be empty and must have 8 or more characters");
        if(Username.Length < 2 && string.IsNullOrEmpty(Username)) errors.Add("Username cannot be empty and must have more than 3 caractres");
    }
}