namespace Autoease.Domain.SeedWork;

public class BaseEntity
{
    public int Id { get; private set; }
    public DateTime Created_At { get; private set; }

    public BaseEntity ()
    {
        Created_At = new DateTime();
    }
}