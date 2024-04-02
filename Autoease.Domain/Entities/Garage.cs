namespace Autoease.Domain.Entities;

using Autoease.Domain.ValueObjects;

public class Garage : BaseEntity 
{
    private readonly List<string> errors = new();

    public Garage()
    {
    }
    public Garage(string garageCNPJ, string name, Address address)
    {
        GarageCNPJ = garageCNPJ;
        Name = name;
        Address = address;

        Validate();
    }

    public string GarageCNPJ { get; private set; }
    public string Name { get; private set; }
    public Address Address { get; private set; }

    public bool IsValid() { return errors.Count == 0; }

    public void Validate()
    {
        if(string.IsNullOrEmpty(GarageCNPJ)) errors.Add("CNPJ Cannot be Empty");
        if(GarageCNPJ.Length < 11) errors.Add("CNPJ cannot be less than 11 characters");
    }


}