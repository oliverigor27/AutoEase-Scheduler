using Autoease.Domain.ValueObjects;

namespace Autoease.Domain.Entities.Aggregate;

public sealed class Appointment : BaseEntity
{
    public Appointment(
        DateTime dateAppoinment, 
        Veichle veichle, 
        ICollection<Services> 
        services, 
        GarageEntity garage
    )
    {
        DateAppoinment = dateAppoinment;
        Veichle = veichle;
        Services = services;
        Garage = garage;
    }

    public DateTime DateAppoinment { get; private set; }
    public Veichle Veichle { get; private set; }
    public ICollection<Services> Services { get; private set; }
    public GarageEntity Garage { get; private set; }
}