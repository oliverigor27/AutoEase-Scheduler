namespace Autoease.Domain.ValueObjects;
public class Appointment
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
    public Appointment(DateTime appointmentDate)
    {
        _appointmentDate = appointmentDate;
    }
}