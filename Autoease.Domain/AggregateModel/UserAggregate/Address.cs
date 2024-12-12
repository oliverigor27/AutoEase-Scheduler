namespace Autoease.Domain.AggregateModel.UserAggregate;

public sealed class Address
{
    public Address(
        string street, 
        string city, 
        string state, 
        string country, 
        string postalCode
    )
    {
        Street = street;
        City = city;
        State = state;
        Country = country;
        PostalCode = postalCode;
    }    

    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
    public string PostalCode { get; set; }
}