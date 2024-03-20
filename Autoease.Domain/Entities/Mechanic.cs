using Autoease.Domain.ValueObjects;

namespace Autoease.Domain.Entities;

public class Mechanic : BaseEntity 
{
    public string Name { get; private set; }
    public string LastName { get; private set; }
    public string Register { get; private set; }
    public Address Address { get; private set; }
}