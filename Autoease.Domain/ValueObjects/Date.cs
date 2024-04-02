using Microsoft.EntityFrameworkCore;

namespace Autoease.Domain.ValueObjects;

[Owned]
public class AppointmentDate
{
    private DateTime _appointmentDate;

    public DateTime Appointment_date
    {
        get { return _appointmentDate; }
        private set { _appointmentDate = value; }
    }

    public string AppointmentDateFormatted
    {
        get { return _appointmentDate.ToString("dd/MM/yyyy"); }
    }

    // Construtor
    public AppointmentDate(DateTime appointmentDate)
    {
        _appointmentDate = appointmentDate;
    }
}