using Autoease.Domain.ValueObjects;

namespace Autoease.Domain.Entities;

public sealed class GarageEntity : BaseEntity
{
    private GarageEntity() {}

    public GarageEntity(
        string garageRegister, 
        string garageName, 
        Address address, 
        string email,
        string password, 
        string phone, 
        DateTime openTime,
        DateTime closeTime, 
        List<Services> services
    )
    {
        GarageRegister = garageRegister;
        GarageName = garageName;
        Address = address;
        Email = email;
        Password = password;
        Phone = phone;
        OpenTime = openTime;
        CloseTime = closeTime;
        Services = services;
    }

    public required string GarageRegister { get; set; }
    public required string GarageName { get; set; }
    public required Address Address { get; set; }
    public required string Email { get; set; }
    public required string Password { get; set; }
    public required string Phone { get; set; }
    public required DateTime OpenTime { get; set; }
    public required DateTime CloseTime { get; set; }
    public required ICollection<Services> Services { get; set; }

    public void AddServices(Services service)
    {   
        Services.Add(service);
    }

    public void RemoveService(Services service)
        => Services.Remove(service);
}