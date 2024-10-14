using Autoease.Domain.Entities.SeedWork;
using Autoease.Domain.ValueObjects;

namespace Autoease.Domain.Entities.Aggregate;

public sealed class UserEntity : BaseEntity, IAggregateRoot
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

    public string UserIdCard { get; set; } = null!;
    public string Username { get;  set; } = null!;
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public Address Address { get; set; } = null!;
    public ICollection<Veichle> Veichle { get; set; } = null!;

    public void SetVeichle(Veichle veichle)
        => Veichle.Add(veichle);
}
