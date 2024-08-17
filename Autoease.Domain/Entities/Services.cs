namespace Autoease.Domain.Entities;

public sealed class Services : BaseEntity
{
    private Services() {}

    public Services(string description, int price)
    {
        Description = description;
        Price = price;
    }

    public required string Description { get; set; }
    public required int Price { get; set; }
    public GarageEntity? Garage { get; set; }
}
