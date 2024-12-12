using Autoease.Domain.AggregateModel.UserAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Autoease.Data.Configuration;

public class UserEntityConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(user => user.Id);

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

        builder.OwnsOne(user => user.Address, user => {
            user.Property(x => x.Street).HasColumnName($"user_{nameof(Address.Street)}").HasMaxLength(64);
            user.Property(x => x.PostalCode).HasColumnName($"user_{nameof(Address.PostalCode)}").HasMaxLength(64);
            user.Property(x => x.City).HasColumnName($"user_{nameof(Address.City)}").HasMaxLength(170);
            user.Property(x => x.State).HasColumnName($"user_{nameof(Address.State)}").HasMaxLength(100);
            user.Property(x => x.Country).HasColumnName($"user_{nameof(Address.Country)}").HasMaxLength(64);
        }).HasNoKey();
        
        builder.Property(user => user.Created_At)
            .HasColumnName("created_at")
            .IsRequired();

        builder.HasMany<Veichle>()
            .WithOne()
            .HasForeignKey(user => user.Id)
            .IsRequired();

        builder.Navigation(user => user.Veichle).UsePropertyAccessMode(PropertyAccessMode.Field);
    }
}
