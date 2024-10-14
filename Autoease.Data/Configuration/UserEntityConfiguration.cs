using Autoease.Domain.Entities.Aggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Autoease.Data.Configuration;

public class UserEntityConfiguration : IEntityTypeConfiguration<UserEntity>
{
    public void Configure(EntityTypeBuilder<UserEntity> builder)
    {
        builder.HasKey(user => user.Id)
            .HasName("user_id");

        builder.Property(user => user.UserIdCard)
            .HasColumnName("user_id_card")
            .IsRequired();

        builder.Property(user => user.Username)
            .HasColumnName("user_username")
            .IsRequired();

        builder.Property(user => user.Email)
            .HasColumnName("user_email")
            .IsRequired();

        builder.Property(user => user.Password)
            .HasColumnName("user_password")
            .IsRequired();

        builder.Property(user => user.FirstName)
            .HasColumnName("user_first_name")
            .IsRequired();

        builder.Property(user => user.LastName)
            .HasColumnName("user_last_name")
            .IsRequired();

        builder.Property(user => user.Address)
            .HasColumnName("user_address")
            .IsRequired();
        
        builder.Property(user => user.Created_At)
            .HasColumnName("created_at")
            .IsRequired();

        builder.HasMany<Veichle>()
            .WithOne()
            .HasForeignKey();

        builder.HasMany<Appointment>()
            .WithOne()
            .HasForeignKey();
    }
}
