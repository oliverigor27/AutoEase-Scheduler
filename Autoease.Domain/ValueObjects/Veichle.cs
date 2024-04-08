using Microsoft.EntityFrameworkCore;

namespace Autoease.Domain.ValueObjects;

[Owned]
public record Veichle
{
    public Veichle(string brand, string model, string year)
    {
        Brand = brand;
        Model = model;
        Year = year;
    }

    protected Veichle()
    {
        
    }

    public string Brand { get; private set; }
    public string Model { get; private set; }
    public string Year { get; private set; }
}