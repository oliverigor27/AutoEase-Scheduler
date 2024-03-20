using Autoease.Domain.Entities;
using Autoease.Domain.Enum;
using Autoease.Domain.ValueObjects;

namespace Autoease.Domain.Aggregation;

public class Appointment : BaseEntity
{
    public Appointment(Appointment appointment_date, ServiceType serviceType, Veichle veichle, string description, Guid garageId, Garage garage, Guid userId, User user)
    {
        Appointment_date = appointment_date;
        ServiceType = serviceType;
        Veichle = veichle;
        Description = description;
        GarageId = garageId;
        Garage = garage;
        UserId = userId;
        User = user;
    }

    public Appointment Appointment_date { get; private set; }
    public ServiceType ServiceType { get; private set; }
    public Veichle Veichle { get; private set; }
    public string Description { get; private set; }
    public Guid GarageId { get; private set; }
    public Garage Garage { get; private set; }
    public Guid UserId { get; private set; }
    public User User { get; private set; }
}