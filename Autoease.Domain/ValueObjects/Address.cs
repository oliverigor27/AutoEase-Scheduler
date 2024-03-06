namespace Autoease.Domain.ValueObjects;

public record Address 
{
    public Address(string zipcode, string street, int houseNumber, string city, string state, string coutry)
    {
        Zipcode = zipcode;
        Street = street;
        HouseNumber = houseNumber;
        City = city;
        State = state;
        Coutry = coutry;
    }

    public string Zipcode { get; private set; }
    public string Street { get; private set; }
    public int HouseNumber { get; private set; }
    public string City { get; private set; }
    public string State { get; private set; }
    public string Coutry { get; private set; }
}