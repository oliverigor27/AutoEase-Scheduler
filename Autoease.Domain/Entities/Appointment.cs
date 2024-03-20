using Autoease.Domain.Enum;

namespace Autoease.Domain.Entities;

public class Appointment : BaseEntity
{
    public Appointment Appointment_date { get; private set; }
    public ServiceType ServiceType { get; private set; }
    public string Veichle { get; private set; }
    public string Description { get; set; }
    public Guid MechanicId { get; private set; }
    public Mechanic Mechanic { get; private set; }
    public Guid UserId { get; private set; }
    public User User { get; private set; }
}