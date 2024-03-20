namespace Autoease.Domain.ValueObjects;

public class Veichle
{
    public Veichle(string band, int licensePlate, int year, string model)
    {
        Band = band;
        LicensePlate = licensePlate;
        Year = year;
        Model = model;
    }

    public string Band { get; private set; }
    public int LicensePlate { get; private set; }
    public int Year { get; private set; }
    public string Model { get; private set; }
}