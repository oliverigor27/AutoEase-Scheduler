namespace Autoease.Domain.Entities.Aggregate;

public sealed class Appointment : BaseEntity
{
    public Appointment(
        DateTime appointmentDate, 
        string description, 
        string typeOfService
    )
    {
        AppointmentDate = appointmentDate;
        Description = description;
        TypeOfService = typeOfService;
    }

    public required DateTime AppointmentDate { get; set; }
    public required string Description { get; set; }
    public required string TypeOfService { get; set; }   

}
