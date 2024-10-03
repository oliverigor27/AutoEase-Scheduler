using Autoease.Domain.Entities.SeedWork;

namespace Autoease.Domain.Entities.Aggregate;

public sealed class Veichle : BaseEntity
{
    private Veichle() {}

    public Veichle(
        string model, 
        string plate, 
        string color, 
        DateTime year
    )
    {
        Model = model;
        Plate = plate;
        Color = color;
        Year = year;
    }

    public string Model { get; set; } = null!;
    public string Plate { get; set; } = null!;
    public string Color { get; set; } = null!;
    public DateTime Year { get; set; }
}