using Autoease.Domain.SeedWork;

namespace Autoease.Domain.AggregateModel.UserAggregate;

public sealed class Appointment : BaseEntity
{
    private Appointment() {}

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

    public DateTime AppointmentDate { get; private set; }
    public string Description { get; private set; } = null!;
    public string TypeOfService { get; private set; } = null!;
    public Veichle Veichle { get; private set; } = null!;
    public decimal? Budget { get; private set; }

    internal void SetBudget(Veichle veichle, decimal budget)
    {
        decimal newBudget = 0;

        if(budget is not 0)
            newBudget = veichle.Year.Year > 2020 ? budget - (0.30m * budget) : 0;

        Budget = newBudget;
    }

    internal void SetVeichle(Veichle veichle)
       => Veichle = veichle;
}
