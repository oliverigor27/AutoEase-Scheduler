namespace Autoease.Domain.Entities;

public class User : BaseEntity
{
    public Guid Id { get; private set; } = new Guid();
    public string Username { get; private set; }
    public string Email { get; private set; }
    public string Password { get; private set; }
    public List<string> Veichles { get; private set; }

}