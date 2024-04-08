using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Autoease.Domain.ValueObjects;

namespace Autoease.Domain.Entities;

public class GarageEntity
{
    protected GarageEntity() {}
    public GarageEntity(string garageRegister, string garageName, Address address, string email, string phone, string businessHour, List<string> services)
    {
        GarageRegister = garageRegister;
        GarageName = garageName;
        Address = address;
        Email = email;
        Phone = phone;
        BusinessHour = businessHour;
        Services = services;
    }

    [Key]
    public string GarageRegister { get; private set; }
    public string GarageName { get; private set; }
    public Address Address { get; private set; }
    public string Email { get; private set; }
    public string Phone { get; private set; }
    public string BusinessHour { get; private set; }
    public List<string> Services { get; private set; }
}