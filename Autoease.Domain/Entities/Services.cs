using Autoease.Domain.Entities.SeedWork;

namespace Autoease.Domain.Entities;

public sealed class Services : BaseEntity
{
    private Services() {}

    public Services(string description, int price)
    {
        Description = description;
        Price = price;
    }

    public string Description { get; set; } = null!;
    public decimal Price { get; set; }
}
