using Microsoft.EntityFrameworkCore;

namespace Autoease.Domain.ValueObjects;

[Owned]
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

        IsDiscount();
    }

    public string Zipcode { get; private set; }
    public string Street { get; private set; }
    public int HouseNumber { get; private set; }
    public string City { get; private set; }
    public string State { get; private set; }
    public string Coutry { get; private set; }

    public object IsDiscount()
    {
        if(City == "Salvador" || City == "São Paulo")
        {
            List<Discount> discount = new()
            {
                new Discount { Message = "Desconto aplicável!", Value = 5 }
            };

            return discount;
        };
    
        return "Não Aplicável!";
    }
}