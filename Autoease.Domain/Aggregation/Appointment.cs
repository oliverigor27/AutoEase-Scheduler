using Autoease.Domain.Entities;
using Autoease.Domain.ValueObjects;

namespace Autoease.Domain.Aggregation;

public class Appointment : BaseEntity
{
    public Appointment()
    {
    }
    public Appointment(DateTime appointmentDate, string note, Guid garageId, GarageEntity garage, Guid userId, UserEntity user, Veichle veichle)
    {
        AppointmentDate = appointmentDate;
        Note = note;
        GarageId = garageId;
        Garage = garage;
        UserId = userId;
        User = user;
        Veichle = veichle;
    }

    public DateTime AppointmentDate { get; private set; }
    public string Note { get; private set; }
    public Guid GarageId { get; private set; }
    public GarageEntity Garage { get; private set; }
    public Guid UserId { get; private set; }
    public UserEntity User { get; private set; }
    public Veichle Veichle { get; private set; }
}