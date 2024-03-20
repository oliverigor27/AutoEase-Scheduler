using Autoease.Domain.Entities;
using Autoease.Domain.Enum;

namespace Autoease.Domain.Aggregation;

public class Appointment : BaseEntity
{
    public Appointment Appointment_date { get; private set; }
    public ServiceType ServiceType { get; private set; }
    public string Veichle { get; private set; }
    public string Description { get; set; }
    public Guid GarageId { get; private set; }
    public Garage Garage { get; private set; }
    public Guid UserId { get; private set; }
    public User User { get; private set; }
}