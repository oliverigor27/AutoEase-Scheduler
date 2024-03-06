namespace Autoease.Domain.Entities;

public class BaseEntity
{
    public Guid Id { get; private set; }
    public DateTime CreatedAt => DateTime.Now;

    public BaseEntity() 
    {
            Id = Guid.NewGuid();
    }
}