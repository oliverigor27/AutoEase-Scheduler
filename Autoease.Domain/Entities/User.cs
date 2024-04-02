using Autoease.Domain.ValueObjects;

namespace Autoease.Domain.Entities;

public class User : BaseEntity
{
    private readonly List<string> errors = new();
    public User()
    {
    }
    public User(string userCPF, string username, string email, string password, string name, string lastName, Address address)
    {
        UserCPF = userCPF;
        Username = username;
        Email = email;
        Password = password;
        Name = name;
        LastName = lastName;
        Address = address;

        Validate();
    }

    public string UserCPF { get; private set; }
    public string Username { get; private set; }
    public string Email { get; private set; }
    public string Password { get; private set; }
    public string Name { get; private set; }
    public string LastName { get; private set; }
    public Address Address { get; private set; }

    public bool IsValid()
    {
        return errors.Count == 0;
    }

    public void Validate()
    {
        if(string.IsNullOrEmpty(Username)) errors.Add("Username cannot be empty!");
        if(string.IsNullOrEmpty(Email)) errors.Add("Email cannot be empty!");
        if(string.IsNullOrEmpty(Password) && Password.Length < 6) errors.Add("Username cannot be empity!");
    }
}