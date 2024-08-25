namespace Autoease.Domain.Entities.Aggregate;

public sealed class Veichle : BaseEntity
{
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

    public required string Model { get; set; }
    public required string Plate { get; set; }
    public required string Color { get; set; }
    public required DateTime Year { get; set; }
}