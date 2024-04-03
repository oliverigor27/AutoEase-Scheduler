namespace Autoease.Domain.Entities;

public class UserEntity : BaseEntity
{
    public string UserIdCard { get; private set; }
    public string Username { get; private set; }
    public string Email { get; private set; }
    public string Password { get; private set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public Guid AddressId { get; private set; }
    public Address Address { get; set; }

    
    protected UserEntity() {}
    public UserEntity(string userIdCard, string username, string email, string password, string firstName, string lastName, Guid addressId, Address address)
    {
        UserIdCard = userIdCard;
        Username = username;
        Email = email;
        Password = password;
        FirstName = firstName;
        LastName = lastName;
        AddressId = addressId;
        Address = address;
    }
}