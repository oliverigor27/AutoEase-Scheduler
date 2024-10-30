namespace Autoease.Domain.AggregateModel.GarageAggregate;

public record Address
{
    public string Street { get; private set; }
    public string City { get; private set; }
    public string State { get; private set; }
    public string Country { get; private set; }
    public string PostalCode { get; private set; }

    public Address(string street, string city, string state, string country, string postalCode)
    {
        Street = street;
        City = city;
        State = state;
        Country = country;
        PostalCode = postalCode;
    }    
}