using Autoease.Domain.Entities.Aggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Autoease.Data.Configuration;

public class AppointmentEntityConfiguration : IEntityTypeConfiguration<Appointment>
{
    public void Configure(EntityTypeBuilder<Appointment> builder)
    {
        builder.HasKey(a => a.Id)
            .HasName("appointment_id");
        
        builder.Property(a => a.AppointmentDate)
            .HasColumnName("appointment_date")
            .IsRequired();

        builder.Property(a => a.Description)
            .HasColumnName("appointment_description")
            .IsRequired();

        builder.Property(a => a.TypeOfService)
            .HasColumnName("appointment_type")
            .IsRequired();

        builder.Property(a => a.Created_At)
            .HasColumnName("created_at")
            .IsRequired();
    }
}
