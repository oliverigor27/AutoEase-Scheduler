using Autoease.Domain.AggregateModel.SeedWork;
using Autoease.Domain.Enum;

namespace Autoease.Domain.AggregateModel.GarageAggregate;

public sealed class GarageEntity : BaseEntity
{
    private GarageEntity() {}

    public GarageEntity(
        string garageRegister, 
        string garageName, 
        Address address, 
        string email,
        string password,
        string description,
        string phone, 
        DateTime openTime,
        DateTime closeTime,
        ServicesCategories servicesCategories
    )
    {
        GarageRegister = garageRegister;
        GarageName = garageName;
        Address = address;
        Email = email;
        Password = password;
        Description = description;
        Phone = phone;
        OpenTime = openTime;
        CloseTime = closeTime;
        ServicesCategories = servicesCategories;
    }

    public string GarageRegister { get; set; } = null!;
    public string GarageName { get; set; } = null!;
    public Address Address { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
    public string Phone { get; set; } = null!;
    public string Description { get; set; } = null!;
    public DateTime OpenTime { get; set; }
    public DateTime CloseTime { get; set; }
    public ServicesCategories ServicesCategories { get; set; }
}