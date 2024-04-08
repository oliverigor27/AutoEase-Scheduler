using Autoease.Domain.Entities;
using Autoease.Domain.ValueObjects;

namespace Autoease.Domain.Aggregation;

public class Appointment : BaseEntity
{
    public Appointment()
    {
    }
    public Appointment(DateTime appointmentDate, string note, GarageEntity garage, UserEntity user, Veichle veichle)
    {
        AppointmentDate = appointmentDate;
        Note = note;
        Garage = garage;
        User = user;
        Veichle = veichle;
    }

    public DateTime AppointmentDate { get; private set; }
    public string Note { get; private set; }
    public GarageEntity Garage { get; private set; }
    public UserEntity User { get; private set; }
    public Veichle Veichle { get; private set; }
}