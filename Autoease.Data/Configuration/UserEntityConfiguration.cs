using Autoease.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Autoease.Data.Configuration;

public class UserEntityConfiguration : IEntityTypeConfiguration<UserEntity>
{
    public void Configure(EntityTypeBuilder<UserEntity> builder)
    {
        builder.HasKey(user => user.Id)
            .HasName("id");

        builder.Property(user => user.UserIdCard)
            .HasColumnName("user_id_card")
            .IsRequired();

        builder.Property(user => user.Username)
            .HasColumnName("username")
            .IsRequired();

        builder.Property(user => user.Email)
            .HasColumnName("email")
            .IsRequired();

        builder.Property(user => user.Password)
            .HasColumnName("password")
            .IsRequired();

        builder.Property(user => user.FirstName)
            .HasColumnName("first_name")
            .IsRequired();

        builder.Property(user => user.LastName)
            .HasColumnName("last_name")
            .IsRequired();

        builder.Property(user => user.Address)
            .HasColumnName("address")
            .IsRequired();
        
        builder.Property(user => user.Created_At)
            .HasColumnName("created_at")
            .IsRequired();
    
    }
}
