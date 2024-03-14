using Autoease.Domain.ValueObjects;

namespace Autoease.Domain.Entities;

public class User : BaseEntity
{
    private readonly List<string> errors = new();

    public Guid Id { get; private set; } = new Guid();
    public string Username { get; private set; }
    public string Email { get; private set; }
    public string Password { get; private set; }
    public List<string> Veichles { get; private set; }
    public Address Address { get; private set; }

    public bool IsValid()
    {
        return errors.Count == 0;
    }

    public void Validate()
    {

    }
}