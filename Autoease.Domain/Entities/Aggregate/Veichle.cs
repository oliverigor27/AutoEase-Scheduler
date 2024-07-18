namespace Autoease.Domain.Entities.Aggregate;

public class Veichle : BaseEntity
{
    public Veichle(string model, string plate, string color)
    {
        Model = model;
        Plate = plate;
        Color = color;
    }

    public string Model { get; private set; }
    public string Plate { get; private set; }
    public string Color { get; private set; }
}